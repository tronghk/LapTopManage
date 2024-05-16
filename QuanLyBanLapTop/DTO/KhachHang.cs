using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class KhachHang : NguoiDTO
    {
        private string address;
        private string email;



        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public KhachHang(string idCustomer, string nameCustomer, string address, string phoneNumber, string email)
            : base(idCustomer, nameCustomer, phoneNumber)
        {
            Address = address;
            Email = email;
        }
    }

}