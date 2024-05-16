using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Phone;

namespace BUS
{
    public class CustomerManage
    {
        private KhachHangDAO khachHangDAO = new KhachHangDAO();
        private HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public static List<KhachHang> listCustomer()
        {
            List<KhachHang> list = new KhachHangDAO().listCustomer();
            list.RemoveAt(0);
            return list;
        }
        public string addCustomer(string id, string name, string address, string phoneNumber, string email)
        {
            if (id == "")
                return "error_isNull";
            if (name == "")
                return "error_nameNull";
            string result = "";
            if (checkIdCustomer(id))
                result = "error_duplicateId";
            phoneNumber = changePhoneNumber(phoneNumber);
            if (phoneNumber.Contains("error"))
                result += "error_phone";
            if (result.Contains("error"))
                return result;
            result = "success";
            KhachHang customer = new KhachHang(id, name, address, phoneNumber, email);
            khachHangDAO.addKhachHang(customer);
            return result;
        }
        public string updateCustomer(string id, string name, string address, string phoneNumber, string email)
        {
            if (id == "")
                return "error_isNull";
            if (name == "")
                return "error_nameNull";
            string result = "";
            if (!checkIdCustomer(id))
                result = "error_duplicateId";
            phoneNumber = changePhoneNumber(phoneNumber);
            if (phoneNumber.Contains("error"))
                result += "error_phone";
            if (result.Contains("error"))
                return result;
            result = "success";
            KhachHang customer = new KhachHang(id, name, address, phoneNumber, email);
            khachHangDAO.updateKhachHang(customer);
            return result;
        }
        public string deleteCustomer(string id)
        {
            if (id == "")
                return "error_isNull";
            
            string result = "";
            if (!checkIdCustomer(id))
                result = "error_duplicateId";
           
            if (result.Contains("error"))
                return result;
            result = "success";
            hoaDonDAO.updateBillToCustomer(id);
            khachHangDAO.deleteKhachHang(id);

            return result;
        }
        public bool checkIdCustomer(string id)
        {
            foreach (KhachHang value in listCustomer())
            {
                if (value.Id == id)
                    return true;
            }
            return false;
        }

        public static List<KhachHang> searchCustomer(string s)
        {
            List<KhachHang> result = new List<KhachHang>();
            while (result.Count == 0)
            {
                result = searchId(s);
                if (result.Count == 0)
                {
                    result = searchName(s);
                }
                if (result.Count == 0)
                {
                    result = searchPhone(s);
                }
                if (s.Length <= 1)
                {
                    break;
                }
                else
                {
                    s = s.Substring(0, s.Length - 1);
                }
            }
            return result;
        }
        public static List<KhachHang> searchId(string s)
        {
            List<KhachHang> list = listCustomer();
            
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang value in list)
            {
                string id = value.Id;
                if (id == s)
                {
                    result.Add(value);
                    break;
                }
            }
           
            return result;


        }
        public static List<KhachHang> searchName(string s)
        {
            List<KhachHang> list = listCustomer();
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang value in list)
            {
                string name = value.Name;
                if (name.Length >= s.Length)
                {
                    if (name.Substring(0, s.Length).ToLower().CompareTo(s.ToLower()) == 0)
                        result.Add(value);
                }
            }
            return result;


        }
        public static List<KhachHang> searchPhone(string s)
        {
            List<KhachHang> list = listCustomer();
            List<KhachHang> result = new List<KhachHang>();
            foreach (KhachHang value in list)
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
        public List<Dictionary<string, string>> topCustomer()
        {
            List<KhachHang> listCu = listCustomer();
            var map = sumMoneyInCustomer(listCu);
            
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            foreach(var value in map)
            {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("name", khachHangDAO.searchNameCustomer(value.Key).Name);
                dict.Add("sumBill", hoaDonDAO.quantityBill(value.Key).ToString());
                dict.Add("sumMoney", value.Value.ToString());
                result.Add(dict);
            }
            return result;
        }
        public Dictionary<string,float> sumMoneyInCustomer(List<KhachHang> listCu)
        {
            var result = new Dictionary<string, float>();
            foreach(KhachHang value in listCu)
            {
                result.Add(value.Id, hoaDonDAO.sumMoneyInIdCustomer(value.Id));
            }
            
            return sortSumMoney(result);
        }
        public Dictionary<string, float> sortSumMoney(Dictionary<string, float> list)
        {
            int length = list.Count;
            var result = new Dictionary<string, float>();
            for (int i = 0; i < length; i++)
            {
               
                float max = 0;
                string id = "";
                foreach (var value in list)
                {
                    if (value.Value >= max)
                    {
                        max = value.Value;
                        id = value.Key;
                        
                    }
                    
                }
                result.Add(id, max);
                list.Remove(id);
                
            }
           
            return result;
        }

        public List<HoaDon> searchBillInCustomer(string s)
        {
            return new HoaDonDAO().listBillInCustomer(s);
        }
        public KhachHang searchCustomerToId(string idCustomer)
        {
            return khachHangDAO.searchNameCustomer(idCustomer);
        }
    }
}
