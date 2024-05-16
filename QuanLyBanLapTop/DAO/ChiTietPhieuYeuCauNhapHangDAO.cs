using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuYeuCauNhapHangDAO
    {
        private Connect conn = new Connect();   
        

        public void addDetailCoupon(ChiTietPhieuYeuCauNhapHangDTO ct)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_addDetailCoupon",conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@quantityImport", ct.QuantityImport);
            command.Parameters.AddWithValue("@unitPrice", ct.UnitPrice);
            command.Parameters.AddWithValue("@intoMoney", ct.IntoMoney);
            command.Parameters.AddWithValue("@idCoupon", ct.IdCoupon);
            command.Parameters.AddWithValue("@idProduct", ct.IdProduct);
            command.ExecuteReader();
            conn.Conn.Close();
        }

        public void updateDetailCoupon(ChiTietPhieuYeuCauNhapHangDTO ct)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_updateDetailCoupon", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@quantityImport", ct.QuantityImport);
            command.Parameters.AddWithValue("@unitPrice", ct.UnitPrice);
            command.Parameters.AddWithValue("@intoMoney", ct.IntoMoney);
            command.Parameters.AddWithValue("@idCoupon", ct.IdCoupon);
            command.Parameters.AddWithValue("@idProduct", ct.IdProduct);
            command.ExecuteReader();
            conn.Conn.Close();
        }

        public void deleteDetailCoupon(string idProduct, int idCoupon)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteDetailCoupon", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCoupon", idCoupon);
            command.Parameters.AddWithValue("@idProduct", idProduct);
            command.ExecuteReader();
            conn.Conn.Close();
        }
        public List<ChiTietPhieuYeuCauNhapHangDTO> listDetailsCoupon(int idCoupon)
        {
            List<ChiTietPhieuYeuCauNhapHangDTO> listDTCoupon = new List<ChiTietPhieuYeuCauNhapHangDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_ChiTietPhieuYcNhapHang where idCoupon = @idCoupon ";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idCoupon", idCoupon.ToString());

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string idProduct = reader["idProduct"].ToString();
                    int quantityImport = int.Parse(reader["quantityImport"].ToString());
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    float intoMoney = float.Parse(reader["intoMoney"].ToString());
                    ChiTietPhieuYeuCauNhapHangDTO chiTietPhieuYeuCauNhapHangDTO = new ChiTietPhieuYeuCauNhapHangDTO(idProduct,idCoupon,quantityImport,unitPrice, intoMoney);
                    listDTCoupon.Add(chiTietPhieuYeuCauNhapHangDTO);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listDTCoupon;
        }
    }
}
