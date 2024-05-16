using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Date;
using static Utils.Number;
using static BUS.TypeProductManage;
using static BUS.ProductBrandManagement;

namespace BUS
{
    public class ProductManage
    {
        private SanPhamDAO sanPhamDAO = new SanPhamDAO();
        public static List<SanPham> list = new List<SanPham>();

        

        public ProductManage()
        {
            list = listProduct();
        }
       
        public string addProduct(string idProduct, string nameProduct, string unitPrice, string quantityProduct, string statusProduct, string typeProduct, string idManufactutre, string image)
        {
            string result = "";
            if (idProduct == "")
                return "error_idNull";
            if (nameProduct == "")
                return "error_nameNull";

            if (checkIdProduct(idProduct))
                result += "error_duplicateId";
            if(!isNumber(quantityProduct))
                result += "error_quantity";
            if(!isFloat(unitPrice))
                result += "error_unitPrice";
            if (result.Contains("error"))
                return result;
            if(int.Parse(quantityProduct) < 0)
            {
                return "error_quantity";
            }
            if (float.Parse(unitPrice) < 0)
            {
                return "error_unitPrice";
            }
            result = "success";
            if (int.Parse(quantityProduct) != 0)
                statusProduct = "Còn hàng";
            else
                statusProduct = "Hết hàng";
            SanPham sp = new SanPham(idProduct, nameProduct, float.Parse(unitPrice),
                int.Parse(quantityProduct), statusProduct,  changeIndexToType(typeProduct), changeIndexToManu(idManufactutre), image);
            this.sanPhamDAO.addProcduct(sp);
            return result;
        }
        public int changeIndexToType(string index)
        {
            List<DanhMucLapTopDTO> listType = listTypeProduct();
            return listType[int.Parse(index)].IdTypeProduct;
        }
        public int changeIndexToManu(string index)
        {
            List<HangSanPhamDTO> list = listBrand();
            
            return list[int.Parse(index)].IdManufactutre;
        }
        public string updateProduct(string idProduct, string nameProduct, string unitPrice, string quantityProduct, string statusProduct, string typeProduct, string idManufactutre, string image)
        {
            
            if (idProduct == "")
                return "error_idNull";
            if (idProduct == "")
                return "error_nameNull";
            string result = "";
            if (!isNumber(quantityProduct))
                result += "error_quantity";
            if (!isFloat(unitPrice))
                result += "error_unitPrice";
            if (!checkIdProduct(idProduct))
                result = "error_duplicateId";
            if (result.Contains("error"))
                return result;
            if (int.Parse(quantityProduct) < 0)
            {
                return "error_quantity";
            }
            if (float.Parse(unitPrice) < 0)
            {
                return "error_unitPrice";
            }
            if (int.Parse(quantityProduct) != 0)
                statusProduct = "Còn hàng";
            else
                statusProduct = "Hết hàng";
            SanPham sp = new SanPham(idProduct, nameProduct, float.Parse(unitPrice),
                int.Parse(quantityProduct), statusProduct, changeIndexToType(typeProduct), changeIndexToManu(idManufactutre), image);
            this.sanPhamDAO.updateProcduct(sp);

            return "success";
        }
        public string deleteProduct(string idProduct)
        {
            if (idProduct == "")
                return "error_idNull";
            string result = "";
            if (!checkIdProduct(idProduct))
                result = "error_notFoundID";

            result = "success";

            this.sanPhamDAO.deleteProcduct(idProduct);

            return result;
        }
        public bool checkIdProduct(string id)
        {
            foreach(SanPham value in listProduct())
            {
                if (value.IdProduct == id)
                    return true;
            }
            return false;
        }
        
        public static List<SanPham> listProduct()
        {
            List<SanPham> listSp = new SanPhamDAO().listProduct();
            return listSp;
        }
        public static void addQuantity(int quantity, string idProdcut)
        {
            SanPhamDAO sp = new SanPhamDAO();
            List<SanPham> listP = sp.listProduct();
            foreach (SanPham value in listP)
            {
                if( value.IdProduct == idProdcut)
                {
                    value.QuantityProduct += quantity;
                    sp.updateProcduct(value);
                    break;
                }
            }
        }
        public static void deleteQuantity(int quantity, string idProdcut)
        {
            SanPhamDAO sp = new SanPhamDAO();
            List<SanPham> listP = sp.listProduct();
            foreach (SanPham value in listP)
            {
                if (value.IdProduct == idProdcut)
                {
                    value.QuantityProduct -= quantity;
                    sp.updateProcduct(value);
                    break;
                }
            }
        }
        public static List<SanPham> searchProduct(string s, List<SanPham> list)
        {
            
            List<SanPham> listP = new List<SanPham>();
            while (listP.Count == 0)
            {
                listP = searchInId(s, list);
                if (listP.Count == 0)
                {
                    listP = searchInName(s, list);
                }
                if (listP.Count == 0)
                {
                    listP = searchInType(s, list);
                }
                if (listP.Count == 0)
                {
                    listP = searchInManu(s, list);
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
            return listP;
        }
        public static List<SanPham> searchInName(string s, List<SanPham> listP)
        {
            int length = s.Length;
            List<SanPham> list = new List<SanPham>();

            foreach (SanPham value in listP)
            {
                string sOb = value.NameProduct.ToString();
                if (sOb.Length >= length)
                {
                    sOb = sOb.Substring(0, length);
                    sOb =  sOb.ToLower();
                    if (s.ToLower() == sOb)
                    {
                        list.Add(value);
                    }
                }

            }
            return list;
        }
        public static List<SanPham> searchInQuantity(string s, List<SanPham> listP)
        {
            int length = s.Length;
            List<SanPham> list = new List<SanPham>();

            foreach (SanPham value in listP)
            {
                string sOb = value.QuantityProduct.ToString();
                if (sOb.Length >= length)
                {
                    if (s.CompareTo(sOb.Substring(0, length)) == 0)
                    {
                        list.Add(value);
                    }
                }

            }
            return list;
        }
        public static List<SanPham> searchInId(string s, List<SanPham> listP)
        {
            int length = s.Length;
            List<SanPham> list = new List<SanPham>();
            foreach (SanPham value in listP)
            {
                string sOb = value.IdProduct.ToString();
                if (sOb.Length >= length)
                {
                    sOb = sOb.Substring(0, length);
                    if (s == sOb)
                    {
                        list.Add(value);
                    }
                }

            }
            return list;
        }
        public static List<SanPham> searchInManu(string s, List<SanPham> listP)
        {
            int length = s.Length;
            List<SanPham> list = new List<SanPham>();
            List<HangSanPhamDTO> listHang = listBrand();
            
            List<HangSanPhamDTO> listManuSearch = new List<HangSanPhamDTO>();
            foreach(HangSanPhamDTO value in listHang)
            {
                string sOb = value.NameManufacturer.ToString();
                if (sOb.Length >= length)
                {
                    sOb = sOb.Substring(0, length);
                    sOb = sOb.ToLower();

                    if (s.ToLower() == sOb)
                    {
                        listManuSearch.Add(value);
                    }
                }
            }
            foreach (SanPham value in listP)
            {
               foreach(HangSanPhamDTO item in listManuSearch)
                {
                    if(item.IdManufactutre == value.IDManuFacture)
                    {
                        list.Add(value);
                        break;
                    }

                }

            }
            return list;
        }


        public static List<SanPham> searchInType(string s, List<SanPham> listP)
        {
            int length = s.Length;
            List<SanPham> list = new List<SanPham>();
            List<DanhMucLapTopDTO> listDanhMuc = listTypeProduct();
            List<DanhMucLapTopDTO> listTypeSearch = new List<DanhMucLapTopDTO>();
            foreach (DanhMucLapTopDTO value in listDanhMuc)
            {
                string sOb = value.NameTypeProduct.ToString();
                if (sOb.Length >= length)
                {

                    sOb = sOb.Substring(0, length);
                    sOb = sOb.ToLower();

                    if (s.ToLower() == sOb)
                    {
                        listTypeSearch.Add(value);
                    }
                }
            }
            foreach (SanPham value in listP)
            {
                foreach (DanhMucLapTopDTO valueP in listTypeSearch)
                    if (value.IdTypeProduct == valueP.IdTypeProduct)
                    {
                        list.Add(value);
                        break;
                    }

            }
            return list;
        }
        public SanPham searchId(string id)
        {
           foreach(SanPham value in listProduct())
            {
                if (value.IdProduct == id)
                    return value;
            }
            return null;
        }
    }
}
