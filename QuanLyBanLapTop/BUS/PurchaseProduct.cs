using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Utils.Number;
using static BUS.Login;
using static BUS.ProductManage;
using static BUS.BillManage;
using static BUS.Login;
namespace BUS
{
   
    public class PurchaseProduct
    {
        private SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private DanhMucLapTopDAO danhMucLapTopDAO = new DanhMucLapTopDAO();
        public int idBill = -1;
        private HoaDon hoaDon;
        public List<ChiTietHoaDonDTO> listChiTietHoaDonDTO = new List<ChiTietHoaDonDTO>();
        private HangSanPhamDAO HangSPDAO = new HangSanPhamDAO();
        private KhuyenMaiDAO khuyenMaiDAO = new KhuyenMaiDAO();
        private ChiTietKhuyenMaiDAO chiTietKhuyenMaiDAO = new ChiTietKhuyenMaiDAO();
        private ChiTietHoaDonDAO chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        private HoaDonDAO hoaDonDAO = new HoaDonDAO();
        
        public List<ChiTietHoaDonDTO> listDetails()
        {
            return listChiTietHoaDonDTO;
        }
        public string addDetailsProduct(string quantity, string idProduct)
        {
            
            if (idProduct == null)
                return "error_idNull";
            string result = "";
           
            if (!isNumber(quantity))
                result += "error_quantity";
            
            result += checkQuantityProduct(quantity,idProduct);
           
            if (checkDuplicateDetails(idProduct))
                result += "error_duplicate";
            
            if (result.Contains("error"))
            {
                return result;
            }
            else
            {
               
                if (idBill == -1)
                {
                    
                    this.addBill();
                }
                // thêm chi tiết
                SanPham p = sanPhamDAO.searchId(idProduct);
                

                float intoMoney = this.intoMoney(p.UnitPrice, quantity);
                float sumMoney = this.sumMoney(p.IdProduct, quantity, p.UnitPrice);
                ChiTietHoaDonDTO detailsBill = new ChiTietHoaDonDTO(int.Parse(quantity), p.UnitPrice,
                    intoMoney, intoMoney-sumMoney, idProduct, idBill);
                this.listChiTietHoaDonDTO.Add(detailsBill);
                
                addDetailsToBill(detailsBill);

                result += "success";
                return result;
            }
        }
        public bool checkDuplicateDetails(string id)
        {
            List<ChiTietHoaDonDTO> list = this.listChiTietHoaDonDTO;
            foreach(ChiTietHoaDonDTO detailsBill in list)
            {
                if(detailsBill.IdBill == this.idBill && detailsBill.IdProduct == id)
                    return true;
            }
            return false;
        }
        public string checkQuantityProduct(string qtt, string idProduct)
        {
            string result = "";
            try
            {
                int quantity = int.Parse(qtt);
            
                if (quantity <= 0)
                    result =  "error_quantity";
                List<SanPham> listSp = sanPhamDAO.listProduct();
                foreach(SanPham value in listSp)
                {
                    if(value.IdProduct == idProduct)
                    {
                        if(value.QuantityProduct < quantity)
                        {
                            result =  "error_quantity";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "error_quantity";
            }
            return result;
        }

        public string updateDetailsProduct(string quantity, string idProduct)
        {
            if (idProduct == null)
                return "error_idNull";
            string result = "";
            if (!isNumber(quantity))
                result += "error_quantity";
            if (!checkDuplicateDetails(idProduct))
                result += "error_duplicate";
            result += checkQuantityProduct(quantity, idProduct);
            if (result.Contains("error"))
            {
                return result;
            }
            else
            {
                SanPham p = sanPhamDAO.searchId(idProduct);


                float intoMoney = this.intoMoney(p.UnitPrice, quantity);
                float sumMoney = this.sumMoney(p.IdProduct, quantity, p.UnitPrice);
                updateDetailsProduct(int.Parse(quantity), idProduct, this.idBill, intoMoney, intoMoney- sumMoney, p.UnitPrice);
                result += "success";
            }
            return result;
        }
        public string deleteDetailsProduct(string idProduct)
        {
            ChiTietHoaDonDTO ct = null;
            if (idProduct == null)
                return "error_idNull";
            foreach (ChiTietHoaDonDTO value in this.listChiTietHoaDonDTO)
            {
               
                if (value.IdProduct == idProduct && value.IdBill == idBill)
                {
                    this.deleteDetailsToBill(value);
                    ct = value;
                }
            }
            if(ct != null)
            {
                this.listChiTietHoaDonDTO.Remove(ct);
            }
            return "success";

        }
        public List<SanPham> searchP(string s)
        {
            return searchProduct(s, filterProductOtherZero());
        }
        public List<SanPham> filterProduct(string nameManufacture, string nameType)
        {
            if(nameManufacture == "Tất cả" && nameType == "Tất cả"){
                return sanPhamDAO.listProduct();
            }
            else if(nameManufacture == "Tất cả")
            {
                return searchInType(nameType,listProduct());
            }
            else if(nameType == "Tất cả")
            {
                return searchInManu(nameManufacture,listProduct());
            }
            else
            {
                List<SanPham> listOfManu = filterInManu(nameManufacture);
                List<SanPham> listOfType = filterInType(nameType);
                List<SanPham> list = new List<SanPham>();
                foreach(SanPham valueType in listOfType)
                {
                    foreach(SanPham valueManu in listOfManu)
                    {
                        if(valueManu.IdProduct == valueType.IdProduct)
                            list.Add(valueManu);
                    }
                }
                return list;
            }
            
        }
        public static  List<SanPham> filterProductOtherZero()
        {
            List<SanPham> listFilter = new List<SanPham>();
            List<SanPham> listAll = listProduct();
            foreach(SanPham value in listAll)
            {
                if(value.QuantityProduct != 0)
                {
                    listFilter.Add(value);
                }
            }
            return listFilter;
        }

        public static List<SanPham> filterInType(string idType)
        {
            return new SanPhamDAO().searchType(int.Parse(idType));
        }
        public List<SanPham> filterInManu(string name)
        {
            if (name == "Tất cả")
                return sanPhamDAO.listProduct();
            return sanPhamDAO.searchManufacturer(this.idManuProduct(name));
        }
        public static List<SanPham> filterInManuToId(string idManu)
        {
            return new SanPhamDAO().searchManufacturer(int.Parse(idManu));
        }


        public void updateDetailsProduct(int quantity, string idProduct, int idBill, float intoMoney, float moneyDown, float unitPrice)
        {
            foreach(ChiTietHoaDonDTO value in this.listChiTietHoaDonDTO)
            {
                if(value.IdProduct == idProduct && value.IdBill == idBill)
                {
                    this.deleteDetailsToBill(value);
                    value.QuantityProduct = quantity;
                    value.IntoMoney = intoMoney;
                    value.MoneyDown = moneyDown;
                    value.UnitPrice = unitPrice;
                    this.addDetailsToBill(value);
                }
            }
        }
        public void addBill()
        {
            List<int> listInt = new List<int>();
            List<HoaDon> listHoaDon = listBill();
            
            foreach (HoaDon hoaDon in listHoaDon)
            {
                listInt.Add(hoaDon.IdBill);
            }
            NhanVien employee = new NhanVienDao().searchEmployeeIdUser(currentAcc.Id);
            this.idBill = MaxNumber(listInt)+1;
            DateTime dateToday = DateTime.Today;
            this.hoaDon = new HoaDon();
            this.hoaDon.IdBill = this.idBill;
            this.hoaDon.DateBill = dateToday;
            this.hoaDon.Pay = 0;
            this.hoaDon.TypePay ="";
            this.hoaDon.SumPay = 0;
            this.hoaDon.Status = "Chưa thanh toán";
            this.hoaDon.IdEmployee = employee.Id ;
            this.hoaDon.IdCustomer = "";
            this.hoaDon.DiscountMoney = 0;
        }


        public static int idTypeProduct(string typeProduct)
        {
            return new DanhMucLapTopDAO().searchIdTypeProduct(typeProduct);

        }
        public int idManuProduct(string name)
        {
            return HangSPDAO.searchIdManuProduct(name);

        }
        public float intoMoney(float unitPrice, string quantity)
        {

            float sumMoney = 0;
            try
            {
                int num = int.Parse(quantity);
                sumMoney = (num * unitPrice);

            }catch(Exception ex)
            {
                return -1;
            }
            return sumMoney;
        }
        public float moneyDown(string idProduct)
        {
            List<ChiTietKhuyenMaiDTO> listDt = this.detailsPromotionToday(this.promotionToday());
            float down = 0;
            foreach(ChiTietKhuyenMaiDTO item in listDt)
            {
                if(item.IdProduct == idProduct)
                {
                    down = item.Discount;
                    break;
                }
            }
            return down;
        }
        public float sumMoney(string idProduct, string quantity, float unitPrice)
        {
            try
            {
                int qtt = int.Parse(quantity);
                float discout = this.moneyDown(idProduct);

                return qtt * unitPrice - qtt * unitPrice * discout / 100;
            }catch(Exception ex)
            {
                return 0;
            }
        }
        public List<KhuyenMaiDTO> promotionToday()
        {
            List<KhuyenMaiDTO> list = khuyenMaiDAO.listPromotion();
            List<KhuyenMaiDTO> listToday = khuyenMaiDAO.listPromotion();
            DateTime today = DateTime.Today;
            foreach (KhuyenMaiDTO item in list)
            {
                if(item.StartDay <= today && item.EndDay >= today)
                {
                    listToday.Add(item);
                }
            }
            return listToday;
        }
        public List<ChiTietKhuyenMaiDTO> detailsPromotionToday(List<KhuyenMaiDTO> list)
        {
            List<ChiTietKhuyenMaiDTO> listDt = new List<ChiTietKhuyenMaiDTO>();
            foreach (KhuyenMaiDTO item in list)
            {
                foreach(ChiTietKhuyenMaiDTO value in chiTietKhuyenMaiDAO.listDetailsPromotion(item.IdPromotion))
                {
                    listDt.Add(value);
                }
            }
            return listDt;
        }
        public string downProduct(string id)
        {
            foreach(ChiTietKhuyenMaiDTO item in detailsPromotionToday(promotionToday())){
                if (item.IdProduct == id)
                    return item.Discount.ToString();
            }
            return null;
        }
        public string linkImage(string idProduct)
        {
            return sanPhamDAO.searchId(idProduct).Image;

        }
        public string saveOrder()
        {
            
            if(idBill == -1)
            {
                return "error_notFoundBill";
            }
            this.hoaDon.IdEmployee = currentAcc.Id;
            new NhanVienDao().updateTotalSalesEmployee(this.hoaDon.IdEmployee, this.hoaDon.SumPay);
            this.hoaDonDAO.addHoaDon(this.hoaDon);
            foreach (ChiTietHoaDonDTO value in this.listChiTietHoaDonDTO)
            {
               chiTietHoaDonDAO.addChiTietHoaDon(value);
                deleteQuantity(value.QuantityProduct, value.IdProduct);
            }
            restartBill();
            
            return null;
        }
        public void restartBill()
        {
            this.idBill = -1;
            this.hoaDon = null;
            this.listChiTietHoaDonDTO = new List<ChiTietHoaDonDTO>();
        }

        private void deleteQuantity(int quantityProduct, string idProduct)
        {
           foreach(SanPham value in sanPhamDAO.listProduct())
            {
                if(value.IdProduct == idProduct)
                {
                    value.QuantityProduct -= quantityProduct;
                    sanPhamDAO.updateProcduct(value);
                    break;
                }
            }
        }

        public Dictionary<string, string> infoBill()
        {
            var map = new Dictionary<string, string>();
            map.Add("quantity", (this.sumQuantity() + ""));
            map.Add("moneyDown", (this.hoaDon.DiscountMoney+""));
            map.Add("pay", (this.hoaDon.Pay + ""));
            return map;
        }
        public int sumQuantity()
        {
            int count = 0;
            foreach(ChiTietHoaDonDTO value in this.listChiTietHoaDonDTO)
            {
                count += value.QuantityProduct;
            }
            return count;
        }
        public void addDetailsToBill(ChiTietHoaDonDTO ct)
        {
            this.hoaDon.SumPay += intoMoney(ct.UnitPrice, (ct.QuantityProduct + ""));
            this.hoaDon.Pay += sumMoney(ct.IdProduct, (ct.QuantityProduct+""), ct.UnitPrice);
            this.hoaDon.DiscountMoney = this.hoaDon.SumPay - this.hoaDon.Pay;
        }
        public void deleteDetailsToBill(ChiTietHoaDonDTO ct)
        {
            this.hoaDon.SumPay -= intoMoney(ct.UnitPrice, (ct.QuantityProduct + ""));
            this.hoaDon.Pay -= sumMoney(ct.IdProduct, (ct.QuantityProduct + ""), ct.UnitPrice);
            this.hoaDon.DiscountMoney = this.hoaDon.SumPay - this.hoaDon.Pay;
        }
    }
}
