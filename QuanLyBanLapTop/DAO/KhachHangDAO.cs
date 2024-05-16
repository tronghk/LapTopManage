using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Globalization;

namespace DAO
{
    public class KhachHangDAO
    {
        private Connect conn = new Connect();
        // thêm 1 quyền
        public void addKhachHang(KhachHang kh)
        {
            conn.Conn.Close();
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_addKhachHang", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCustomer", kh.Id);
            command.Parameters.AddWithValue("@nameCustomer", kh.Name);
            command.Parameters.AddWithValue("@address", kh.Address);
            command.Parameters.AddWithValue("@phoneNumber", kh.Phone);
            command.Parameters.AddWithValue("@email", kh.Email);
            command.Connection = conn.Conn;
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public void updateKhachHang(KhachHang kh)
        {
            conn.Conn.Close();
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_updateKhachHang", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCustomer", kh.Id);
            command.Parameters.AddWithValue("@nameCustomer", kh.Name);
            command.Parameters.AddWithValue("@address", kh.Address);
            command.Parameters.AddWithValue("@phoneNumber", kh.Phone);
            command.Parameters.AddWithValue("@email", kh.Email);
            command.Connection = conn.Conn;
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public void deleteKhachHang(string idCustomer)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteKhachHang", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            command.Connection = conn.Conn;
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public List<KhachHang> listCustomer()
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            List<KhachHang> list = new List<KhachHang>();
            string query = "select * from Tbl_KhachHang";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string idCustomer = reader["idCustomer"].ToString();
                    string nameCustomer = reader["nameCustomer"].ToString();
                    string address = reader["address"].ToString();
                    string phoneNumber = reader["phoneNumber"].ToString();
                    string email = reader["email"].ToString();
                    KhachHang customer = new KhachHang(idCustomer, nameCustomer, address, phoneNumber, email);
                    list.Add(customer);
                }
            }
            reader.Close();
            conn.Conn.Close();
            return list;
        }
        public KhachHang searchNameCustomer(string idCustomer)
        {
            conn.Conn.Close();
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            List<KhachHang> list = new List<KhachHang>();
            string query = @"select * from Tbl_KhachHang where idCustomer = @idCustomer";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idCustomer", idCustomer);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nameCustomer = reader["nameCustomer"].ToString();
                    string address = reader["address"].ToString();
                    string phoneNumber = reader["phoneNumber"].ToString();
                    string email = reader["email"].ToString();
                    KhachHang customer = new KhachHang(idCustomer, nameCustomer, address, phoneNumber, email);
                    return customer;
                }
            }
            reader.Close();
            conn.Conn.Close();
            return null;
        }
    }
}
