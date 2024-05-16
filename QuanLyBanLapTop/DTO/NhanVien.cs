using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class NhanVien : NguoiDTO
    {
        private string serviceEmployee;
        private DateTime birthday;
        private float totalSales;
        private int quantityBillPay;
        private string idUser;
        private float salaryEmployee;



        public string IdUser{
            get { return idUser; }
            set { idUser = value; }
        }
        public float SalaryEmployee
        {
            get { return salaryEmployee; }
            set { salaryEmployee = value; }
        }


        public string ServiceEmployee
        {
            get { return serviceEmployee; }
            set { serviceEmployee = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public float TotalSales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }




        public int QuantityBillPay
        {
            get { return quantityBillPay; }
            set { quantityBillPay = value; }
        }

        public NhanVien (string idEmployee, string nameEmployee, string serviceEmployee, DateTime birthday, string phoneNumber, float totalSales, int quantityBillPay, string idUser, float salaryEmployee)
            : base(idEmployee,nameEmployee,phoneNumber)
        {
            
            ServiceEmployee = serviceEmployee;
            Birthday = birthday;
            TotalSales = totalSales;
            QuantityBillPay = quantityBillPay;
            IdUser = idUser;
            SalaryEmployee = salaryEmployee;
 
        }
    }
    

}