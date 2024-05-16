using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BUS.ProductManage;
using static Utils.Number;

namespace BUS
{
    public class ProductBrandManagement
    {
        private HangSanPhamDAO hangSanPhamDAO = new HangSanPhamDAO();
        public static List<HangSanPhamDTO> listBrand()
        {
            return new HangSanPhamDAO().listBrandProduct();
        }
        public List<SanPham> filterProductInBrand(string idBrand)
        {
            return searchInManu(idBrand, listProduct());
        }
        public string addBrandProduct(string idManu, string name)
        {
            if (idManu == "")
                return "error_idNull";
            if (!isNumber(idManu))
            {
                return "error_idNumber";
            }
            if (checkDuplicateId(int.Parse(idManu)))
            {
                return "error_duplicateId";
            }
            HangSanPhamDTO typeP = new HangSanPhamDTO(int.Parse(idManu), name);
            hangSanPhamDAO.addHangSanPham(typeP);
            return "success";
        }
        public string updateBrandProduct(string idManu, string name)
        {
            if (idManu == "")
                return "error_idNull";
            if (!isNumber(idManu))
            {
                return "error_idNumber";
            }
            if (!checkDuplicateId(int.Parse(idManu)))
            {
                return "error_duplicateId";
            }
            HangSanPhamDTO typeP = new HangSanPhamDTO(int.Parse(idManu), name);
            hangSanPhamDAO.updateHangSanPham(typeP);
            return "success";
        }
        public string deleteBrandProduct(string idManu)
        {
            if (idManu == "")
                return "error_idNull";
            if (!isNumber(idManu))
            {
                return "error_idNumber";
            }
            if (!checkDuplicateId(int.Parse(idManu)))
            {
                return "error_duplicateId";
            }
            hangSanPhamDAO.deleteHangSanPham(int.Parse(idManu));
            return "success";
        }
        public bool checkDuplicateId(int idType)
        {
            foreach (HangSanPhamDTO value in listBrand())
            {
                if (value.IdManufactutre == idType)
                    return true;
            }
            return false;

        }
        public List<HangSanPhamDTO> searchBrand(string s)
        {
            List<HangSanPhamDTO> result = new List<HangSanPhamDTO>();
            while (result.Count == 0)
            {
                result = searchIdBand(s);
                if (result.Count == 0)
                {
                    result = searchNameBrand(s);
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
        public List<HangSanPhamDTO> searchIdBand(string s)
        {
            int length = s.Length;
            List<HangSanPhamDTO> list = listBrand();
            List<HangSanPhamDTO> result = new List<HangSanPhamDTO>();

            foreach (HangSanPhamDTO item in list)
            {
                string id = item.IdManufactutre + "";
                if (id == s)
                    result.Add(item);
            }
            return result;
        }
        public List<HangSanPhamDTO> searchNameBrand(string s)
        {
            int length = s.Length;
            List<HangSanPhamDTO> list = listBrand();
            List<HangSanPhamDTO> result = new List<HangSanPhamDTO>();

            foreach (HangSanPhamDTO item in list)
            {
                string name = item.NameManufacturer + "";
                if (name.Length >= length)
                {
                    name = name.Substring(0, length);
                    name = name.ToLower();
                    if (name.CompareTo(s.ToLower()) == 0)
                        result.Add(item);
                }

            }
            return result;
        }
        public string searchId(string id)
        {
            return hangSanPhamDAO.searchManuProduct(id).NameManufacturer;
        }
    }
}
