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
    public class TypeProductManage
    {
        private DanhMucLapTopDAO danhMucLapTopDAO = new DanhMucLapTopDAO();
        public static List<DanhMucLapTopDTO> listTypeProduct()
        {

            return new DanhMucLapTopDAO().listTypeProduct();
        }
        public List<SanPham> filterProductInType(string idType)
        {
            return searchInType(idType,listProduct());
        }
        public string addTypeProduct(string idType, string name)
        {
            if (idType == "")
                return "error_idNull";
            if (!isNumber(idType))
            {
                return "error_idNumber";
            }
            if (checkDuplicateId(int.Parse(idType)))
            {
                return "error_duplicateId";
            }
            DanhMucLapTopDTO typeP = new DanhMucLapTopDTO(int.Parse(idType), name);
            danhMucLapTopDAO.addDanhMucLapTop(typeP);
            return "success";
        }
        public string updateTypeProduct(string idType, string name)
        {
            if (idType == "")
                return "error_idNull";
            if (!isNumber(idType))
            {
                return "error_idNumber";
            }
            if (!checkDuplicateId(int.Parse(idType)))
            {
                return "error_duplicateId";
            }
            DanhMucLapTopDTO typeP = new DanhMucLapTopDTO(int.Parse(idType), name);
            danhMucLapTopDAO.updateDanhMucLapTop(typeP);
            return "success";
        }
        public string deleteTypeProduct(string idType)
        {
            if (idType == "")
                return "error_idNull";
            if (!isNumber(idType))
            {
                return "error_idNumber";
            }
            if (!checkDuplicateId(int.Parse(idType)))
            {
                return "error_duplicateId";
            }
            new SanPhamDAO().deleteProcductToIdType(idType);
            danhMucLapTopDAO.deleteDanhMucLapTop(int.Parse(idType));
            return "success";
        }
        
        public bool checkDuplicateId(int idType) { 
            foreach(DanhMucLapTopDTO value in listTypeProduct())
            {
                if(value.IdTypeProduct == idType)
                    return true;
            }    
            return false;

        }
        public List<DanhMucLapTopDTO> searchType(string s)
        {
            List<DanhMucLapTopDTO> result = new List<DanhMucLapTopDTO>();
            while (result.Count == 0)
            {
                result = searchIdType(s);
                if (result.Count == 0)
                {
                    result = searchNameType(s);
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
        public List<DanhMucLapTopDTO> searchIdType(string s)
        {
            int length = s.Length;
            List<DanhMucLapTopDTO> list = listTypeProduct();
            List<DanhMucLapTopDTO> result = new List<DanhMucLapTopDTO>();

            foreach (DanhMucLapTopDTO item in list)
            {
                string id = item.IdTypeProduct + "";
                if (id == s)
                    result.Add(item);
            }
            return result;
        }
        public List<DanhMucLapTopDTO> searchNameType(string s)
        {
            int length = s.Length;
            List<DanhMucLapTopDTO> list = listTypeProduct();
            List<DanhMucLapTopDTO> result = new List<DanhMucLapTopDTO>();

            foreach (DanhMucLapTopDTO item in list)
            {
                string name = item.NameTypeProduct + "";
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
        public string nameType(int id)
        {
            return danhMucLapTopDAO.searchNameProduct(id).NameTypeProduct;
        }

    }
}
