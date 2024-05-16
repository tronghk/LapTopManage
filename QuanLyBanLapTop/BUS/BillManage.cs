using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillManage
    {
        public static List<ChiTietHoaDonDTO> listDetailsBill(int idBill)
        {
            ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
            List<ChiTietHoaDonDTO> list = chiTietHoaDonDAO.listDetailsBill(idBill);
            return list;
        }
        public static List<HoaDon> listBill()
        {
            List<HoaDon> list = new HoaDonDAO().listBill();
            
            return list;
        }
        public List<HoaDon> searchBill(string s, List<HoaDon> list)
        {
            List<HoaDon> result = new List<HoaDon>();
            while (result.Count == 0)
            {
                result = searchIdBill(s, list);
                if (result.Count == 0)
                {
                    result = searchDateBill(s, list);
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
        public List<HoaDon> searchIdBill(string s, List<HoaDon> result) {
            int length = s.Length;
            List<HoaDon> list = new List<HoaDon>();
            foreach (HoaDon value in result)
            {
                string id = value.IdBill+"";
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
        public List<HoaDon> searchDateBill(string s, List<HoaDon> list)
        {
            List<HoaDon> result = new List<HoaDon>();
            result = searchDateDayBill(s,list);
            if(result.Count == 0)
                result = searchDateMonthBill(s,list);
            if(result.Count == 0)
                result = searchDateYearsBill(s,list);
            return result;
            
        }
        public List<HoaDon> searchDateDayBill(string s, List<HoaDon> result)
        {
            
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
        public List<HoaDon> searchDateMonthBill(string s, List<HoaDon> result)
        {
            
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
        public List<HoaDon> searchDateYearsBill(string s, List<HoaDon> result)
        {
            
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
        public static HoaDon bill(int idBill)
        {
            return new HoaDonDAO().searchIdBill(idBill);
        }
        public void updateBill(HoaDon bill)
        {
            new HoaDonDAO().updateBillToStatus(bill);
        }


    }
}
