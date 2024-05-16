using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUS.ProductManage;
using static Utils.Number;
using static Utils.Date;
using static BUS.export;
namespace BUS
{
    public class PromotionManage
    {
        private KhuyenMaiDAO khuyenMaiDAO  = new KhuyenMaiDAO();
        private SanPhamDAO sanPhamDAO = new SanPhamDAO();
        private ChiTietKhuyenMaiDAO chiTietKhuyenMaiDAO = new ChiTietKhuyenMaiDAO();
        public int idPromotion = -1;
        public List<ChiTietKhuyenMaiDTO> listDt = new List<ChiTietKhuyenMaiDTO>();
        public static List<KhuyenMaiDTO> listPromotion()
        {
            return new KhuyenMaiDAO().listPromotion();
        }
        public static List<ChiTietKhuyenMaiDTO> listDetailsPromotion(int id)
        {
            return new ChiTietKhuyenMaiDAO().listDetailsPromotion(id);
        }
        public List<KhuyenMaiDTO> searchPromotion(string s)
        {
            
                List<KhuyenMaiDTO> result = new List<KhuyenMaiDTO>();
                while (result.Count == 0)
                {
                    result = searchIdPromotion(s);
                    if (result.Count == 0)
                    {
                        result = searchNamePromotion(s);
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
        public List<KhuyenMaiDTO> searchIdPromotion(string s)
        {
            int length = s.Length;
            List<KhuyenMaiDTO> list = listPromotion();
            List<KhuyenMaiDTO> result = new List<KhuyenMaiDTO>();

            foreach (KhuyenMaiDTO item in list)
            {
                string id = item.IdPromotion + "";
                if(id == s)
                    result.Add(item);
            }
            return result;
        }
        public List<KhuyenMaiDTO> searchNamePromotion(string s)
        {
            int length = s.Length;
            List<KhuyenMaiDTO> list = listPromotion();
            List<KhuyenMaiDTO> result = new List<KhuyenMaiDTO>();

            foreach (KhuyenMaiDTO item in list)
            {
                string name = item.NamePromotion + "";
                if(name.Length >= length)
                {
                    name = name.Substring(0, length);
                    name = name.ToLower();
                    if (name.CompareTo(s.ToLower()) == 0)
                        result.Add(item);
                }
               
            }
            return result;
        }
        public List<SanPham> searchP(string s)
        {
            return searchProduct(s,listProduct());
        }
        public void addPromotion()
        {
            this.idPromotion = maxIdPromotion() + 1;
        }
        public int maxIdPromotion()
        {
            List<int> listId = new List<int>();
            foreach (KhuyenMaiDTO item in listPromotion())
            {
                listId.Add(item.IdPromotion);
            }
            return MaxNumber(listId);
        }
        public string savePromotion(string name, string status, DateTime dateStart, DateTime dateEnd)
        {
            if (name == "")
                return "error_name";
            string result = "";
            result += "success";
            KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO(this.idPromotion, name, status, dateStart, dateEnd);
            khuyenMaiDAO.addKhuyenMai(khuyenMaiDTO);
            saveDetailsPromotion(this.listDt);
            return result;
        }
        public void saveDetailsPromotion(List<ChiTietKhuyenMaiDTO> list) { 
            foreach (ChiTietKhuyenMaiDTO item in list)
            {
                chiTietKhuyenMaiDAO.addChiTietKhuyenMai(item);
            }
        }
        public string addDetailsPromotion(string idProduct, string discount)
        {
            if (idProduct == "")
                return "error_idNull";
            if(discount == "")
                return "error_discountNull";
            string result = "";
            if (!isFloat(discount))
                result += "error_discount";
            if (checkDuplicateDetailsPromotion(idProduct, this.idPromotion))
                result += "error_duplicate";
            if(result.Contains("error"))
                return result;
            result += "success";
            ChiTietKhuyenMaiDTO chiTietKhuyenMaiDTO = new ChiTietKhuyenMaiDTO(float.Parse(discount), "", idProduct, this.idPromotion);
            this.listDt.Add(chiTietKhuyenMaiDTO);
            return result;
            
        }
        public string updateDetailsPromotion(string idProduct, string discount)
        {
            if (idProduct == "")
                return "error_idNull";
            if (discount == "")
                return "error_discountNull";
            string result = "";
            if (!isFloat(discount))
                result += "error_discount";
            if (!checkDuplicateDetailsPromotion(idProduct, this.idPromotion))
                result += "error_duplicate";
            if (result.Contains("error"))
                return result;

            result += "success";
            ChiTietKhuyenMaiDTO chiTietKhuyenMaiDTO = new ChiTietKhuyenMaiDTO(float.Parse(discount), "", idProduct, this.idPromotion);
            updateDetailsPromotion(chiTietKhuyenMaiDTO);
            return result;

        }
        public void updateDetailsPromotion(ChiTietKhuyenMaiDTO ct)
        {
            foreach(ChiTietKhuyenMaiDTO value in this.listDt)
            {
                if(value.IdProduct == ct.IdProduct && value.IdPromotion == ct.IdPromotion)
                {
                    value.Discount = ct.Discount;
                    break;
                }
            }
        }
        public string deleteDetailsPromotion(string idProduct)
        {
            if (idProduct == "")
                return "error_idNull";
            string result = "";
            if (!checkDuplicateDetailsPromotion(idProduct, this.idPromotion))
                result += "error_duplicate";
            if (result.Contains("error"))
                return result;
            ChiTietKhuyenMaiDTO ct = null;
            foreach (ChiTietKhuyenMaiDTO value in this.listDt)
            {
                if (value.IdProduct == idProduct && value.IdPromotion == this.idPromotion)
                {
                    ct = value;
                    break;
                }
            }
            this.listDt.Remove(ct);
            return "success";

        }
        public bool checkDuplicateDetailsPromotion(string idProduct, int idPromotion)
        {
            foreach(ChiTietKhuyenMaiDTO value in this.listDt){
                if(value.IdProduct == idProduct && value.IdPromotion == idPromotion)
                    return true;
            }
            return false;
        }
        public string exportPromotionExcel(string idPromotion)
        {
            if (idPromotion == "")
                return "error";
            List<ChiTietKhuyenMaiDTO> listDtP = listDetailsPromotion(int.Parse(idPromotion));
            List<SanPham> listP = new List<SanPham>();
            foreach(ChiTietKhuyenMaiDTO value in listDtP)
            {
                listP.Add(sanPhamDAO.searchId(value.IdProduct));
            }
            Dictionary<string, string> listExcel = new Dictionary<string, string>();
            for(int i = 0; i < listDtP.Count; i++)
            {
                listExcel.Add(listP[i].NameProduct, listDtP[i].Discount+"");
            }
           return exportExcelPromotion(listExcel, idPromotion);
            
        }

    }
}
