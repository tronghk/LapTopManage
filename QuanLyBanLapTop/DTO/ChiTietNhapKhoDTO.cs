using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietNhapKhoDTO
    {
        private int quantityRequest;
        private int quantityActual;
        private float unitPrice;
        private float intoMoney;   
        private int idReceipt;
        private string idProduct;


        public string IdProduct { 
            get { return idProduct; }
            set { idProduct = value; }
        }
        public int QuantityRequest
        {
            get { return quantityRequest; }
            set { quantityRequest = value; }
        }

        public int QuantityActual
        {
            get { return quantityActual; }
            set { quantityActual = value; }
        }

        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public float IntoMoney
        {
            get { return intoMoney; }
            set { intoMoney = value; }
        }

        public int IdReceipt
        {
            get { return idReceipt; }
            set { idReceipt = value; }
        }

        public ChiTietNhapKhoDTO(int idReceipt, int quantityRequest, int quantityActual, float unitPrice, float intoMoney, string idProduct)
        {
            this.QuantityRequest = quantityRequest;
            this.QuantityActual = quantityActual;
            this.UnitPrice = unitPrice;
            this.IntoMoney = intoMoney;
            this.IdReceipt = idReceipt;
            this.idProduct = idProduct;
        }
    }
}
