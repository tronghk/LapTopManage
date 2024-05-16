using DAO;
using DocumentFormat.OpenXml.Bibliography;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductStatistics
    {
        private NhanVienDao employeeDao = new NhanVienDao();
        private HoaDonDAO billDao = new HoaDonDAO();
        public Dictionary<string, string> overview(string year)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            string quantityEmployee = this.quantityEmployee();
            string quantityProduct = this.quantityProduct();
            string total = this.totalRevenue(this.totalRevenueYear(year));
            string quantityCustomer = this.quantityCustomer();

            map.Add("employee", quantityEmployee);
            map.Add("product",quantityProduct);
            map.Add("total", total);
            map.Add("customer",quantityCustomer);
            return map;

        }
        public string quantityEmployee()
        {
            List<NhanVien> listEmployee = employeeDao.listEmployee();
            return listEmployee.Count +"";
        }
        public List<HoaDon> totalRevenueYear(string year)
        {
            List<HoaDon> listBill = billDao.listBill();
            List<HoaDon> result = new List<HoaDon>();
            foreach (HoaDon hoaDon in listBill)
            {
                if (hoaDon.DateBill.Year.ToString() == year)
                    result.Add(hoaDon);
            }
            return result;
        }
        public List<HoaDon> totalRevenueMonth(string month, string year)
        {
            List<HoaDon> listBillYear = totalRevenueYear(year);
            List<HoaDon> result = new List<HoaDon>();
            foreach (HoaDon hoaDon in listBillYear)
            {
                if (hoaDon.DateBill.Year.ToString() == year && hoaDon.DateBill.Month.ToString() == month)
                    result.Add(hoaDon);
            }
            return result;
        }
        public string totalRevenue(List<HoaDon> listBillYear)
        {
            float sum = 0;
            
            foreach(HoaDon hoaDon in listBillYear)
            {
                sum += hoaDon.SumPay;
            }
            return sum + "";
        }
        public string quantityProduct()
        {
            return new SanPhamDAO().listProduct().Count + "";
        }
        public string quantityCustomer()
        {
            return new KhachHangDAO().listCustomer().Count + "";
        }
        public Dictionary<string, string> totalMonth(string year)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
           
            
            for( int i = 1; i < 13; i++)
            {
                List<HoaDon> listBillMonth = totalRevenueMonth(i+"", year);
                string sum = totalRevenue(listBillMonth);
                result.Add(i+"", sum);
            }
            return result;
        }
        public List<Dictionary<string, string>> topProduct(string year)
        {
            
            List<HoaDon> listBillYear = totalRevenueYear(year);
            List<SanPham> listProduct = new SanPhamDAO().listProduct();
            List<ChiTietHoaDonDTO> listDetailsBillInYear = this.listDeitalsBillInYear(listBillYear);
            Dictionary<string, float> totalProduct = this.totalProductInYear(listDetailsBillInYear, listProduct);
            Dictionary<string, float> topTotalProduct = this.topTotalProduct(totalProduct);
            List<Dictionary<string, string>> result = topProduct(listDetailsBillInYear, topTotalProduct);
            return result;
        }
        public List<ChiTietHoaDonDTO> listDeitalsBillInYear(List<HoaDon> listBillYear)
        {
            List<ChiTietHoaDonDTO> result = new List<ChiTietHoaDonDTO>();
            foreach(HoaDon hoaDon in listBillYear)
            {
                List<ChiTietHoaDonDTO> list = new ChiTietHoaDonDAO().listDetailsBill(hoaDon.IdBill);
                foreach(ChiTietHoaDonDTO value in list)
                {
                    result.Add(value);
                }
            }
            return result;
        }
        public Dictionary<string, float> totalProductInYear(List<ChiTietHoaDonDTO> list, List<SanPham> listProduct)
        {
            Dictionary<string, float> result = new Dictionary<string, float>();
            foreach(SanPham sanPham in listProduct)
            {
                float sum = 0;
                foreach(ChiTietHoaDonDTO value in list)
                {
                    if (value.IdProduct == sanPham.IdProduct)
                        sum += value.IntoMoney;
                }
                result.Add(sanPham.IdProduct, sum );
            }
              return result;
        }
        public Dictionary<string, float> topTotalProduct(Dictionary<string, float> list)
        {
            var items = from pair in list
                        orderby pair.Value descending
                        select pair;
            Dictionary<string, float> result = new Dictionary<string, float>();
            foreach (KeyValuePair<string,float> item in items)
            {
                result.Add(item.Key, item.Value);
            }
            return result;
        }
        public List<Dictionary<string, string>> topProduct(List<ChiTietHoaDonDTO> listDetailsProduct, Dictionary<string, float> listTopProduct)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach(var value in listTopProduct)
            {
                int quantity = 0;
                SanPham sanPham = new SanPhamDAO().searchId(value.Key);
                foreach(ChiTietHoaDonDTO item in listDetailsProduct)
                {
                    if(sanPham.IdProduct == item.IdProduct)
                    {
                        quantity += item.QuantityProduct;
                    }
                }
                Dictionary<string, string> map = new Dictionary<string, string>();

                map.Add("name", sanPham.NameProduct);
                map.Add("total", value.Value + "");
                map.Add("quantity", quantity + "");
                result.Add(map);
            }
            return result;
        }
    }
}
