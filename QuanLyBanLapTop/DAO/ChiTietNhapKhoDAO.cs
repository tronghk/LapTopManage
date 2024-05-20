using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietNhapKhoDAO
    {
        private Connect conn = new Connect();
        // thêm 1 nhà cung cấp
        public void addDetailReceipt(ChiTietNhapKhoDTO ctnk)
        {
            // kết nối với connect
            conn.Conn.Open();
            // tạo lớp kết nối sqlCommand 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.Conn;
            string query = @"insert into Tbl_ChiTietNhapKho (idReceipt, quantityRequest, quantityActual, unitPrice, intoMoney, idProduct)
                values (@idReceipt, @quantityRequest, @quantityActual, @unitPrice, @intoMoney, @idProduct)";
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@idReceipt", ctnk.IdReceipt);
            sqlCommand.Parameters.AddWithValue("@quantityRequest", ctnk.QuantityRequest);
            sqlCommand.Parameters.AddWithValue("@quantityActual", ctnk.QuantityActual);
            sqlCommand.Parameters.AddWithValue("@unitPrice", ctnk.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@intoMoney", ctnk.IntoMoney);
            sqlCommand.Parameters.AddWithValue("@idProduct", ctnk.IdProduct);
            conn.Conn.Close();
        }

        public void deleteDetailReceipt(int IdReceipt, int IdCoupon)
        {
            // kết nối với connect
            conn.Conn.Open();
            // tạo lớp kết nối sqlCommand 
            SqlCommand command = new SqlCommand("Proc_deleteDetailReceipt", conn.Conn);
            // đặt tên biến
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idReceipt", IdReceipt);
            command.Parameters.AddWithValue("@idCoupon", IdCoupon);
            command.Connection = conn.Conn;
            // tạo biến reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void updateDetailReceipt(ChiTietNhapKhoDTO ctnk)
        {
            // kết nối với connect
            conn.Conn.Open();
            // tạo lớp kết nối sqlCommand 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn.Conn;
            string query = @"update Tbl_ChiTietNhapKho set quantityRequest = @quantityRequest, quantityActual = @quantityActual, unitPrice = @unitPrice, intoMoney = @intoMoney
                where idReceipt = @idReceipt and idProduct  = @idProduct ";
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@idReceipt", ctnk.IdReceipt);
            sqlCommand.Parameters.AddWithValue("@quantityRequest", ctnk.QuantityRequest);
            sqlCommand.Parameters.AddWithValue("@quantityActual", ctnk.QuantityActual);
            sqlCommand.Parameters.AddWithValue("@unitPrice", ctnk.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@intoMoney", ctnk.IntoMoney);
            sqlCommand.Parameters.AddWithValue("@idProduct", ctnk.IdProduct);

            sqlCommand.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public List<ChiTietNhapKhoDTO> listDetailsReceipt(int idReceipt)
        {
            List<ChiTietNhapKhoDTO> listDTReceipt = new List<ChiTietNhapKhoDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_ChiTietNhapKho where idReceipt = @idReceipt";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idReceipt", idReceipt.ToString());

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int quantityRequest = int.Parse(reader["quantityRequest"].ToString());
                    int quantityActual = int.Parse(reader["quantityActual"].ToString());
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    float intoMoney = float.Parse(reader["intoMoney"].ToString());
                    string idProduct = reader["idProduct"].ToString();
                    ChiTietNhapKhoDTO chiTietNhapKhoDTO = new ChiTietNhapKhoDTO(idReceipt, quantityRequest, quantityActual, unitPrice, intoMoney, idProduct);
                    listDTReceipt.Add(chiTietNhapKhoDTO);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listDTReceipt;
        }
    }
}
