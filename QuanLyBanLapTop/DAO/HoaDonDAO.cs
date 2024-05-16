using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private Connect conn = new Connect();
        public void addHoaDon(HoaDon hd)
        {
            
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_addHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idBill", hd.IdBill);
            command.Parameters.AddWithValue("@dateBill", hd.DateBill);
            command.Parameters.AddWithValue("@sumPay", hd.SumPay);
            command.Parameters.AddWithValue("@typePay", hd.TypePay);
            command.Parameters.AddWithValue("@discountMoney", hd.DiscountMoney);
            command.Parameters.AddWithValue("@pay", hd.Pay);
            command.Parameters.AddWithValue("@status", hd.Status);
            command.Parameters.AddWithValue("@idEmployee", hd.IdEmployee);
            command.Parameters.AddWithValue("@idCustomer", hd.IdCustomer);
            command.Connection = conn.Conn;
            command.ExecuteReader();
            conn.Conn.Close();
        }

        public void updateHoaDon(HoaDon hd)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_updateHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idBill", hd.IdBill);
            command.Parameters.AddWithValue("@dateBill", hd.DateBill);
            command.Parameters.AddWithValue("@sumPay", hd.SumPay);
            command.Parameters.AddWithValue("@typePay", hd.TypePay);
            command.Parameters.AddWithValue("@discountMoney", hd.DiscountMoney);
            command.Parameters.AddWithValue("@pay", hd.Pay);
            command.Parameters.AddWithValue("@status", hd.Status);
            command.Parameters.AddWithValue("@idEmployee", hd.IdEmployee);
            command.Parameters.AddWithValue("@idCustomer", hd.IdCustomer);
            command.Connection = conn.Conn;
            command.ExecuteReader();
            conn.Conn.Close();
        }
        public void updateBillToCustomer(string idCustomer)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;

            string query = "update Tbl_HoaDon set idCustomer = @s where idCustomer = @idCustomer";
            command.CommandText = query;
            command.Parameters.AddWithValue("@s", "");
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public void updateBillToStatus(HoaDon b)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "update Tbl_HoaDon set status = @status, idCustomer = @idCustomer where idBill = @idBill";
            command.CommandText = query;
            command.Parameters.AddWithValue("@status", b.Status);
            command.Parameters.AddWithValue("@idCustomer", b.IdCustomer);
            command.Parameters.AddWithValue("@idBill", b.IdBill);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public void updateBillToEmployee(string idEmployee)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;

            string query = "update Tbl_HoaDon set idEmployee = @s where idEmployee = @idEmployee";
            command.CommandText = query;
            command.Parameters.AddWithValue("@s", "");
            command.Parameters.AddWithValue("@idEmployee", idEmployee);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public void deleteHoaDon(int idBill)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idBill", idBill);
            command.Connection = conn.Conn;
            command.ExecuteReader();
            conn.Conn.Close();
        }

        public List<HoaDon> listBill()
        {
            List<HoaDon> listBill = new List<HoaDon>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_HoaDon";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   int idBill = int.Parse(reader["idBill"].ToString());
                    DateTime dateBill = DateTime.Parse(reader["dateBill"].ToString());
                   float sumPay = float.Parse(reader["sumPay"].ToString());
                    string typePay = reader["typePay"].ToString();
                    float discountMoney = float.Parse(reader["discountMoney"].ToString());
                    float pay = float.Parse(reader["pay"].ToString());
                    string status = reader["status"].ToString();
                    string idEmployee = reader["idEmployee"].ToString();
                    string idCustomer = reader["idCustomer"].ToString();
                    HoaDon hoaDon = new HoaDon(idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer);
                    listBill.Add(hoaDon);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listBill;
        }
        public List<HoaDon> listBillInEmployee(string idEmployee)
        {
            List<HoaDon> listBill = new List<HoaDon>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HoaDon where idEmployee = @idEmployee";
            command.Parameters.AddWithValue("@idEmployee", idEmployee);
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idBill = int.Parse(reader["idBill"].ToString());
                    DateTime dateBill = DateTime.Parse(reader["dateBill"].ToString());
                    float sumPay = float.Parse(reader["sumPay"].ToString());
                    string typePay = reader["typePay"].ToString();
                    float discountMoney = float.Parse(reader["discountMoney"].ToString());
                    float pay = float.Parse(reader["pay"].ToString());
                    string status = reader["status"].ToString();
                    string idCustomer = reader["idCustomer"].ToString();
                    HoaDon hoaDon = new HoaDon(idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer);
                    listBill.Add(hoaDon);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listBill;
        }

        public List<HoaDon> listBillInCustomer(string idCustomer)
        {
            List<HoaDon> listBill = new List<HoaDon>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HoaDon where idCustomer = @idCustomer";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idBill = int.Parse(reader["idBill"].ToString());
                    DateTime dateBill = DateTime.Parse(reader["dateBill"].ToString());
                    float sumPay = float.Parse(reader["sumPay"].ToString());
                    string typePay = reader["typePay"].ToString();
                    float discountMoney = float.Parse(reader["discountMoney"].ToString());
                    float pay = float.Parse(reader["pay"].ToString());
                    string status = reader["status"].ToString();
                    string idEmployee = reader["idEmployee"].ToString();
                    HoaDon hoaDon = new HoaDon(idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer);
                    listBill.Add(hoaDon);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listBill;
        }
        public HoaDon searchIdBill(int idBill)
        {
            
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HoaDon where idBill = @idBill";
            command.Parameters.AddWithValue("@idBill", idBill);
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DateTime dateBill = DateTime.Parse(reader["dateBill"].ToString());
                    float sumPay = float.Parse(reader["sumPay"].ToString());
                    string typePay = reader["typePay"].ToString();
                    float discountMoney = float.Parse(reader["discountMoney"].ToString());
                    float pay = float.Parse(reader["pay"].ToString());
                    string status = reader["status"].ToString();
                    string idEmployee = reader["idEmployee"].ToString();
                    string idCustomer = reader["idCustomer"].ToString();
                    HoaDon hoaDon = new HoaDon(idBill, dateBill, sumPay, typePay, discountMoney, pay, status, idEmployee, idCustomer);
                    return hoaDon;
                }
            }

            conn.Conn.Close();
            reader.Close();
            return null;
        }
        public float sumMoneyInIdCustomer(string idCustomer)
        {
            float sumMoney = 0;
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HoaDon where idCustomer = @idCustomer";
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sumMoney += float.Parse(reader["pay"].ToString());
                }
            }

            conn.Conn.Close();
            reader.Close();
            return sumMoney;
        }
        public float quantityBill(string idCustomer)
        {
            float count = 0;
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HoaDon where idCustomer = @idCustomer";
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count++;
                }
            }

            conn.Conn.Close();
            reader.Close();
            return count;
        }

    }
}
