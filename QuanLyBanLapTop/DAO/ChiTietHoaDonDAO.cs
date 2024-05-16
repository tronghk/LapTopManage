using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        private Connect conn = new Connect();
        public void addChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDon)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_addChiTietHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@quantityProduct", chiTietHoaDon.QuantityProduct);
            command.Parameters.AddWithValue("@unitPrice", chiTietHoaDon.UnitPrice);
            command.Parameters.AddWithValue("@intoMoney", chiTietHoaDon.IntoMoney);
            command.Parameters.AddWithValue("@moneyDown", chiTietHoaDon.MoneyDown);
            command.Parameters.AddWithValue("@idProduct", chiTietHoaDon.IdProduct);
            command.Parameters.AddWithValue("@idBill", chiTietHoaDon.IdBill);
            command.Connection = conn.Conn;

            command.ExecuteNonQuery();
            conn.Conn.Close();

        }
        public void updateChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDon)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_updateChiTietHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@quantityProduct", chiTietHoaDon.QuantityProduct);
            command.Parameters.AddWithValue("@unitPrice", chiTietHoaDon.UnitPrice);
            command.Parameters.AddWithValue("@intoMoney", chiTietHoaDon.IntoMoney);
            command.Parameters.AddWithValue("@moneyDown", chiTietHoaDon.MoneyDown);
            command.Parameters.AddWithValue("@idProduct", chiTietHoaDon.IdProduct);
            command.Parameters.AddWithValue("@idBill", chiTietHoaDon.IdBill);
            command.Connection = conn.Conn;

            command.ExecuteNonQuery();
            conn.Conn.Close();

        }
        public void deleteChiTietHoaDon(string idProduct, int idBill)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteChiTietHoaDon", conn.Conn);
            command.CommandType = CommandType.StoredProcedure;
          
            command.Parameters.AddWithValue("@idProduct", idProduct);
            command.Parameters.AddWithValue("@idBill", idBill);
            command.Connection = conn.Conn;

            command.ExecuteNonQuery();
            conn.Conn.Close();

        }
        public List<ChiTietHoaDonDTO> listDetailsBill(int idBill)
        {
           List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_ChiTietHoaDon where idBill = @idBill ";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idBill", idBill.ToString());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int quantityProduct = int.Parse(reader["quantityProduct"].ToString());
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    float intoMoney = float.Parse(reader["intoMoney"].ToString());
                    float moneyDown = float.Parse(reader["moneyDown"].ToString());
                    string idProduct = reader["idProduct"].ToString();
                    ChiTietHoaDonDTO chiTietHoaDonDTO;
                    chiTietHoaDonDTO = new ChiTietHoaDonDTO(quantityProduct,unitPrice,intoMoney,moneyDown,idProduct,idBill);
                    list.Add(chiTietHoaDonDTO);
                }
            }

            conn.Conn.Close();
            reader.Close();
            return list;
        }
    }
}
