using DAO;
using DTO;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Utils.Number;
using static BUS.ProductManage;

namespace BUS
{
    public class ImportProduct
    {
        private PhieuYeuCauNhapHang phieuYeuCauNhapHang;
        public List<ChiTietPhieuYeuCauNhapHangDTO> listDt = new List<ChiTietPhieuYeuCauNhapHangDTO>();
        private PhieuYeuCauNhapHangDAO phieuYeuCauNhapHangDAO = new PhieuYeuCauNhapHangDAO();
        private ChiTietPhieuYeuCauNhapHangDAO ctDAO = new ChiTietPhieuYeuCauNhapHangDAO();
        private SanPhamDAO sanPhamDAO = new SanPhamDAO();

        
        public static List<PhieuYeuCauNhapHang> listCoupon()
        {
            return new PhieuYeuCauNhapHangDAO().listCoupon();
        }
        public static List<ChiTietPhieuYeuCauNhapHangDTO> listDtCoupon(string idCoupon)
        {
            return new ChiTietPhieuYeuCauNhapHangDAO().listDetailsCoupon(int.Parse(idCoupon));
        }
        public void addCoupon()
        {
            phieuYeuCauNhapHang = new PhieuYeuCauNhapHang();
            int idCoupon = maxId();
            this.phieuYeuCauNhapHang.IdCoupon = idCoupon;

        }
        public string addDetailsCoupon(string idProduct, string quantity, string unitPrice, string intoMoney)
        {
            if (idProduct == "")
                return "error_idNull";
            if (checkDuplicateId(idProduct))
                return "error_duplicateId";
            string result = "";
            if (!isNumber(quantity))
                result = "error_quantity";
            result = "success";

            ChiTietPhieuYeuCauNhapHangDTO chiTietPhieuYeuCauNhapHangDTO = new ChiTietPhieuYeuCauNhapHangDTO(idProduct, this.phieuYeuCauNhapHang.IdCoupon,
                int.Parse(quantity), float.Parse(unitPrice), float.Parse(intoMoney));
            this.listDt.Add(chiTietPhieuYeuCauNhapHangDTO);
            return result;
        }
        public bool checkDuplicateId(string idProduct)
        {
            foreach (ChiTietPhieuYeuCauNhapHangDTO value in this.listDt)
                if (value.IdProduct == idProduct)
                    return true;
            return false;
        }
        public string updateDetailsCoupon(string idProduct, string quantity, string unitPrice, string intoMoney)
        {
            if (idProduct == "")
                return "error_idNull";
            if (!checkDuplicateId(idProduct))
                return "error_duplicateId";
            if (!isNumber(quantity))
                return "error_quantity";

            string result = "success";

            ChiTietPhieuYeuCauNhapHangDTO chiTietPhieuYeuCauNhapHangDTO = new ChiTietPhieuYeuCauNhapHangDTO(idProduct, this.phieuYeuCauNhapHang.IdCoupon,
                int.Parse(quantity), float.Parse(unitPrice), float.Parse(intoMoney));
            updateProduct(chiTietPhieuYeuCauNhapHangDTO);
            return result;
        }
        public void updateProduct(ChiTietPhieuYeuCauNhapHangDTO p)
        {
            foreach(ChiTietPhieuYeuCauNhapHangDTO value in listDt)
            {
                if (value.IdProduct == p.IdProduct && value.IdCoupon == p.IdCoupon)
                {
                    value.QuantityImport = p.QuantityImport;
                    value.IntoMoney = p.IntoMoney;
                }
                    
            }
        }
        public string deleteDetailsCoupon(string idProduct)
        {
            if (idProduct == "")
                return "error_idNull";
            if (!checkDuplicateId(idProduct))
                return "error_duplicateId";
            string result = "success";

            int index = 0;
            foreach (ChiTietPhieuYeuCauNhapHangDTO value in this.listDt)
            {
                if (value.IdCoupon == this.phieuYeuCauNhapHang.IdCoupon && value.IdProduct == idProduct)
                {
                    this.deleteDetailsCoupon(value);
                    break;
                }
                index++;
            }
            listDt.RemoveAt(index);

            return result;
        }
        public void deleteDetailsCoupon(ChiTietPhieuYeuCauNhapHangDTO ct)
        {
            this.phieuYeuCauNhapHang.IntoMoney -= ct.IntoMoney;
        }
        public void updateDetailsCoupon(ChiTietPhieuYeuCauNhapHangDTO ct)
        {
            foreach (var item in this.listDt)
            {
                if (item.IdProduct == ct.IdProduct && item.IdCoupon == ct.IdCoupon)
                {
                    item.QuantityImport = ct.QuantityImport;
                    item.IntoMoney = ct.IntoMoney;
                    updateSumCoupon(item, ct);
                    break;
                }
            }
        }
        public int maxId()
        {
            int max = 0;
            foreach (PhieuYeuCauNhapHang value in listCoupon())
            {
                if (value.IdCoupon > max) max = value.IdCoupon;
            }
            return max + 1;
        }
        public void sumIntoMoney(float intoMoney)
        {
            this.phieuYeuCauNhapHang.IntoMoney += intoMoney;
        }
        public void updateSumCoupon(ChiTietPhieuYeuCauNhapHangDTO dtOld, ChiTietPhieuYeuCauNhapHangDTO dtNew)
        {
            this.phieuYeuCauNhapHang.IntoMoney -= dtOld.IntoMoney;
            this.phieuYeuCauNhapHang.IntoMoney += dtNew.IntoMoney;

        }
        public void saveCoupon(string idSupplier)
        {
            this.phieuYeuCauNhapHang.IdSupplier = idSupplier;
            this.phieuYeuCauNhapHang.DateAdded = DateTime.Now;
            this.phieuYeuCauNhapHang.IntoMoney = sumReceipt();
            phieuYeuCauNhapHangDAO.addCoupon(this.phieuYeuCauNhapHang);
            foreach (ChiTietPhieuYeuCauNhapHangDTO value in this.listDt)
            {
                SanPham p = sanPhamDAO.searchId(value.IdProduct);
                p.QuantityProduct = p.QuantityProduct + value.QuantityImport;
                sanPhamDAO.updateProcduct(p);
                ctDAO.addDetailCoupon(value);
            }
        }
        public float sumReceipt()
        {
            float sum = 0;
            foreach(ChiTietPhieuYeuCauNhapHangDTO value in listDt)
            {
                sum += value.IntoMoney;
            }
            return sum;
        }
        public List<PhieuYeuCauNhapHang> searchId(string s)
        {
            List<PhieuYeuCauNhapHang> list = listCoupon();
            List<PhieuYeuCauNhapHang> result = new List<PhieuYeuCauNhapHang>();
            while (list.Count == 0)
            {
                result = searchId(s, list);
                if(s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
            }
            return result;
        }
        public List<PhieuYeuCauNhapHang> searchId(string s, List<PhieuYeuCauNhapHang> list)
        {
            List<PhieuYeuCauNhapHang> result = new List<PhieuYeuCauNhapHang>();
            int length = s.Length; 
            foreach (PhieuYeuCauNhapHang value in list)
            {
                if (value.IdCoupon.ToString().Length >= length)
                {
                    string temp = value.IdCoupon.ToString();
                    temp = temp.Substring(0, length);
                    if (temp == s)
                        result.Add(value);
                }

                
            }
            return result;
        }
        


}
}
