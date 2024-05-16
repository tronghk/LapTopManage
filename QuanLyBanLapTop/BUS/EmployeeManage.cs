using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Date;
using static Utils.Number;
using static Utils.Phone;
using static BUS.Login;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace BUS
{
    public class EmployeeManage
    {
        private NhanVienDao nvDAO = new NhanVienDao();
       public static List<NhanVien> listEmployee()
        {
            return removeNullEmployee();
        }
        public static List<NhanVien> removeNullEmployee()
        {
            List<NhanVien> list = new NhanVienDao().listEmployee();
            int index = 0;
            foreach (NhanVien v in list)
            {
                if (v.Id == "")
                    break;
                index++;
            }
            list.RemoveAt(index);
            return list;
        }
        public string addEmployee(string idEmployee, string nameEmployee, string serviceEmployee, DateTime birthday, string phoneNumber, string salaryEmployee)
        {
            if(idEmployee == "")
                return "error_isNull";
            if (nameEmployee == "")
                return "error_nameNull";
            string result = "";
            if (checkIdEmployee(idEmployee))
                result = "error_duplicateId";
            phoneNumber = changePhoneNumber(phoneNumber);
            if (phoneNumber.Contains("error"))
                result += "error_phone";
            if (!isFloat(salaryEmployee))
                result += "error_float";
            if (result.Contains("error"))
                return result;
            result = "success";
            NhanVien employee = new NhanVien(idEmployee, nameEmployee, serviceEmployee, birthday, phoneNumber, 0, 0,idEmployee, float.Parse(salaryEmployee));
            new Login().addUser(idEmployee, "1234", serviceEmployee);
            nvDAO.addNhanVien(employee);
            return result;

        }
        public string updateEmployee(string idEmployee, string nameEmployee, string serviceEmployee, DateTime birthday, string phoneNumber, string salaryEmployee)
        {
            if (idEmployee == "")
                return "error_isNull";
            if (nameEmployee == "")
                return "error_nameNull";
            string result = "";
            if (!checkIdEmployee(idEmployee))
                result = "error_duplicateId";
            phoneNumber = changePhoneNumber(phoneNumber);
            if (phoneNumber.Contains("error"))
                result += "error_phone";
            if (!isFloat(salaryEmployee))
                result += "error_float";
            if (result.Contains("error"))
                return result;
            result = "success";
            NhanVien employee = new NhanVien(idEmployee, nameEmployee, serviceEmployee, birthday, phoneNumber, 0, 0, idEmployee, float.Parse(salaryEmployee));
            nvDAO.updateNhanVien(employee);
            return result;

        }
        public string deleteEmployee(string idEmployee)
        {
            if (idEmployee == "")
                return "error_isNull";
            if (!checkIdEmployee(idEmployee))
               return "error_duplicateId";
            nvDAO.deleteEmployee(idEmployee);
            new HoaDonDAO().updateBillToEmployee(idEmployee);
            return "success";

        }

        public bool checkIdEmployee(string id)
        {
            foreach(NhanVien value in listEmployee())
            {
                if (value.Id == id)
                    return true;
            }
            return false;
        }
       public static List<NhanVien> searchEmployee(string s)
        {
            List<NhanVien> result = new List<NhanVien> ();
            while(result.Count == 0)
            {
                result = searchId(s);
                if(result.Count  == 0)
                {
                    result = searchName(s);
                }
                if (result.Count == 0)
                {
                    result = searchService(s);
                }
                if (result.Count == 0)
                {
                    result = searchPhone(s);
                }
                if (s.Length <= 1)
                   break;
                else
                    s = s.Substring(0, s.Length - 1);
            }
            return result;
        }
        public static List<NhanVien> searchId(string s)
        {
            List<NhanVien> list = listEmployee();
            List<NhanVien> result = new List<NhanVien> ();
            foreach(NhanVien value in list)
            {
                string id = value.Id;
                if(id == s)
                {
                    result.Add(value);
                    break;
                }
            }
            return result;


        }
        public static List<NhanVien> searchName(string s)
        {
            List<NhanVien> list = listEmployee();
            List<NhanVien> result = new List<NhanVien>();
            foreach (NhanVien value in list)
            {
                string name = value.Name;
                if(name.Length >= s.Length)
                {
                    if(name.Substring(0, s.Length).ToLower().CompareTo(s.ToLower()) == 0)
                        result.Add(value);
                }
            }
            return result;


        }
        public static List<NhanVien> searchService(string s)
        {
            List<NhanVien> list = listEmployee();
            List<NhanVien> result = new List<NhanVien>();
            foreach (NhanVien value in list)
            {
                string service = value.ServiceEmployee;
                if (service.Length >= s.Length)
                {
                    if (service.Substring(0, s.Length).ToLower().CompareTo(s.ToLower()) == 0)
                        result.Add(value);
                }
            }
            return result;


        }
        public static List<NhanVien> searchPhone(string s)
        {
            List<NhanVien> list = listEmployee();
            List<NhanVien> result = new List<NhanVien>();
            foreach (NhanVien value in list)
            {
                string phone = value.Phone;
                if (phone.Length >= s.Length)
                {
                    if (phone.Substring(0, s.Length).CompareTo(s) == 0)
                        result.Add(value);
                }
            }
            return result;


        }
        public List<NhanVien> topEmployee()
        {
            List<NhanVien> list = listEmployee();
            List<NhanVien> listSort = new List<NhanVien>();
            int length = list.Count;
            for (int i = 0; i < length; i++)
            {
                float max = list[0].TotalSales;
                int index = 0;
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j].TotalSales > max)
                    {
                        max = list[j].TotalSales;
                        index = j;
                    }
                   
                }
                listSort.Add(list[index]);
                list.RemoveAt(index);
            }
            return listSort;
        }
        public List<HoaDon> searchBillInEmployee(string s)
        {
            return new HoaDonDAO().listBillInEmployee(s);
        }
        public NhanVien searchIdEmployee(string idEmployee)
        {
            return new NhanVienDao().searchEmployee(idEmployee);
        }
        public List<HoaDon> searchBillInEmployee(string s, string idEmployee)
        {
            List<HoaDon> result = new List<HoaDon>();
            while (result.Count == 0)
            {
                result = searchIdBill(s, idEmployee);
                if (result.Count == 0)
                {
                    result = searchDateBill(s, idEmployee);
                }
                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        public List<HoaDon> searchIdBill(string s, string idEmployee)
        {
            int length = s.Length;
            List<HoaDon> result = new HoaDonDAO().listBillInEmployee(idEmployee);
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon value in result)
            {
                string id = value.IdBill + "";
                if (id.Length >= length)
                {
                    id = id.Substring(0, length);
                    if (id.CompareTo(s) == 0)
                    {
                        list.Add(value);
                    }
                }
            }
            return list;

        }
        public List<HoaDon> searchDateBill(string s, string idEmployee)
        {
            List<HoaDon> result = new List<HoaDon>();
            result = searchDateDayBill(s, idEmployee);
            if (result.Count == 0)
                result = searchDateMonthBill(s, idEmployee);
            if (result.Count == 0)
                result = searchDateYearsBill(s, idEmployee);
            return result;

        }
        public List<HoaDon> searchDateDayBill(string s, string idEmployee)
        {
            List<HoaDon> result = new HoaDonDAO().listBillInEmployee(idEmployee);
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon value in result)
            {
                string day = value.DateBill.Day + "";
                if (day == s)
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public List<HoaDon> searchDateMonthBill(string s, string idEmployee)
        {
            List<HoaDon> result = new HoaDonDAO().listBillInEmployee(idEmployee);
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon value in result)
            {
                string month = value.DateBill.Month + "";
                if (month == s)
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public List<HoaDon> searchDateYearsBill(string s, string idEmployee)
        {
            List<HoaDon> result = new HoaDonDAO().listBillInEmployee(idEmployee);
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon value in result)
            {
                string year = value.DateBill.Year + "";
                if (year == s)
                {
                    list.Add(value);
                }
            }
            return list;
        }
        public NhanVien searchToId(string idEmployee)
        {
            return nvDAO.searchEmployee(idEmployee);
        }
       
    }
}
