using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUS.export;

namespace BUS
{
    public class PaymentOrders
    {
        private int idBill;
        private KhachHangDAO khachHangDAO = new KhachHangDAO();
        private HoaDon bill;
        private HoaDonDAO hoaDonDAO = new HoaDonDAO();
        private ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        private SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private NhanVienDao nv = new NhanVienDao();
        
        public PaymentOrders(int idBill)
        {
            this.idBill = idBill;
            this.bill = new HoaDonDAO().searchIdBill(idBill);
        }
        public List<KhachHang> searchCustomer(string s)
        {
            List<KhachHang> result = new List<KhachHang>();
            while(result.Count == 0)
            {
                result = searchIdCustomer(s);
                if(result.Count == 0)
                {
                    result = searchNameCustomer(s);
                }
                if (result.Count == 0)
                {
                    result = searchPhoneCustomer(s);
                }
                if(s.Length > 1)
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
        public List<KhachHang> searchNameCustomer(string s)
        {
            int length = s.Length;
            List<KhachHang> listC = khachHangDAO.listCustomer();
            List<KhachHang> listSearch = new List<KhachHang>();
            foreach (KhachHang khachHang in listC)
            {
                string name = khachHang.Name;
                if( name.Length >= length)
                {
                    name = name.Substring(0, length);
                    if(name.CompareTo(s) == 0)
                    {
                        listSearch.Add(khachHang);
                    }
                }
            }
            return listSearch;
        }
        public List<KhachHang> searchIdCustomer(string s)
        {
            int length = s.Length;
            List<KhachHang> listC = khachHangDAO.listCustomer();
            List<KhachHang> listSearch = new List<KhachHang>();
            foreach (KhachHang khachHang in listC)
            {
                string Id = khachHang.Id;
                if (Id.Length >= length)
                {
                    Id = Id.Substring(0, length);
                    if (Id.CompareTo(s) == 0)
                    {
                        listSearch.Add(khachHang);
                    }
                }
            }
            return listSearch;
        }
        public List<KhachHang> searchPhoneCustomer(string s)
        {
            int length = s.Length;
            List<KhachHang> listC = khachHangDAO.listCustomer();
            List<KhachHang> listSearch = new List<KhachHang>();
            foreach (KhachHang khachHang in listC)
            {
                string Phone = khachHang.Phone;
                if (Phone.Length >= length)
                {
                    Phone = Phone.Substring(0, length);
                    if (Phone.CompareTo(s) == 0)
                    {
                        listSearch.Add(khachHang);
                    }
                }
            }
            return listSearch;
        }
        public Dictionary<string,string> infoBill()
        {
            Dictionary<string,string> map = new Dictionary<string,string>();
            map.Add("SumPay", (bill.SumPay+""));
            map.Add("DiscoutMoney", (bill.DiscountMoney + ""));
            map.Add("Pay", (bill.Pay + ""));
            map.Add("TypePay", bill.TypePay);
            return map;
        }
        public void updateTypePay(string s)
        {
            bill.TypePay = s;  
            hoaDonDAO.updateHoaDon(bill);
        }
        public void updateStatusBill(string idCustomer)
        {
            bill.Status = "Đã thanh toán";
            bill.IdCustomer = idCustomer;
            hoaDonDAO.updateHoaDon(bill);
        }
        public void payment(string idCustomer, string export)
        {
            updateStatusBill(idCustomer);
            //nv.updateTotalSalesEmployee(this.bill.IdEmployee, this.bill.Pay);
            if (export != null)
            {
                exportBill(this.idBill);
            }
        }
        public static void exportBill(int idBill)
        {
            HoaDon bill = new HoaDonDAO().searchIdBill(idBill);
            List<ChiTietHoaDonDTO> listDt = new ChiTietHoaDonDAO().listDetailsBill(idBill);
            List<SanPham> listP = new List<SanPham>();
            foreach(ChiTietHoaDonDTO value in listDt)
            {
                listP.Add(new SanPhamDAO().searchId(value.IdProduct));
            }
            exportBillExcel(bill, listDt, listP);
        }

    }
}
