using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Number;
using static Utils.Date;

namespace BUS
{
    public class ProductSupply
    {
        private PhieuNhapKho phieuNhapKho;
        private PhieuNhapKhoDAO phieuNhapKhoDAO = new PhieuNhapKhoDAO();
        private ChiTietNhapKhoDAO chiTietNhapKho = new ChiTietNhapKhoDAO();
        private List<ChiTietNhapKhoDTO> listDtReceipt = new List<ChiTietNhapKhoDTO>();
        public static List<PhieuNhapKho> listReceipt()
        {
            return new PhieuNhapKhoDAO().listReceipt();
        }
        public static List<ChiTietNhapKhoDTO> listDetailsReceipt(string idReceipt)
        {
            return new ChiTietNhapKhoDAO().listDetailsReceipt(int.Parse(idReceipt));
        }
        public void addReceipt()
        {
            phieuNhapKho = new PhieuNhapKho();
            phieuNhapKho.IdReceipt = maxIdReceipt();
        }
        public int maxIdReceipt()
        {
            int max = 0;
            foreach(PhieuNhapKho value in listReceipt())
            {
                if (max < value.IdReceipt)
                    max = value.IdReceipt;
            }
            return max + 1;
        }
        public string addDetailsReceipt(string quantityActual, string quantityRequest, string unitPrice, string intoMoney, string idProduct) 
        {
            if (!isNumber(quantityActual))
            {
                return "error_quantity";
            }
            ChiTietNhapKhoDTO dt = new ChiTietNhapKhoDTO(this.phieuNhapKho.IdReceipt,  int.Parse(quantityRequest), int.Parse(quantityActual),
                float.Parse(unitPrice), float.Parse(intoMoney), idProduct);
            this.listDtReceipt.Add(dt);
            return "success";
        }
        public string updateDetailsReceipt(string idCoupon, string quantityActual, string quantityRequest, string unitPrice, string intoMoney, string idProduct)
        {
            if (!isNumber(quantityActual))
            {
                return "error_quantity";
            }
            ChiTietNhapKhoDTO dt = new ChiTietNhapKhoDTO(this.phieuNhapKho.IdReceipt , int.Parse(quantityRequest), int.Parse(quantityActual),
                float.Parse(unitPrice), float.Parse(intoMoney), idProduct);
            this.updateDetailsReceipt(dt);
            updateSumpay(dt.QuantityActual, dt.IdProduct);
            return "success";
        }
        public void updateDetailsReceipt(ChiTietNhapKhoDTO ct)
        {
            foreach(ChiTietNhapKhoDTO value in this.listDtReceipt)
            {
                if(value.IdProduct == ct.IdProduct && value.IdReceipt == ct.IdReceipt)
                {
                    value.QuantityActual = ct.QuantityActual;
                }
            }
        }
        public string deleteDetailsReceipt(string idProduct)
        {
            if (idProduct == "")
                return "error_idNull";
            foreach (ChiTietNhapKhoDTO value in this.listDtReceipt)
            {
                if (value.IdProduct == idProduct && value.IdReceipt == this.phieuNhapKho.IdReceipt)
                {
                    this.listDtReceipt.Remove(value);
                }
            }
            updateSumpay(0, idProduct);
            return "success";

        }
        public void updateSumpay(int quantity, string idProduct)
        {
            foreach (ChiTietNhapKhoDTO value in this.listDtReceipt)
            {
                if(value.IdProduct == idProduct && value.IdReceipt == this.phieuNhapKho.IdReceipt)
                {
                    this.phieuNhapKho.SumPay -= value.UnitPrice * value.QuantityActual;
                    this.phieuNhapKho.SumPay += value.UnitPrice * quantity;
                }
                    
            }
        }
        public string saveSupply(string date)
        {
            if (!checkDate(date))
                return "error_date";
            foreach(ChiTietNhapKhoDTO value in this.listDtReceipt)
            {
                chiTietNhapKho.addDetailReceipt(value);
            }
            phieuNhapKhoDAO.addReceipt(this.phieuNhapKho);
            return "success";
        }

    }
}
