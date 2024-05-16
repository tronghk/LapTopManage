using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhuyenMaiDTO
    {
        private float discount;
        private string status;
        private string idProduct;
        private int idPromotion;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        public int IdPromotion
        {
            get { return idPromotion; }
            set { idPromotion = value; }
        }
        public ChiTietKhuyenMaiDTO(float discount, string status, string idProduct, int idPromotion)
        {
            Discount = discount;
            Status = status;
            IdProduct = idProduct;
            IdPromotion = idPromotion;
        }
    }
}
