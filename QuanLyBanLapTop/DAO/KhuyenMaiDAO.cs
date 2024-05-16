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
        public class KhuyenMaiDAO
    {
        private Connect conn = new Connect();
        
        public void addKhuyenMai(KhuyenMaiDTO khuyenMai)
        {
          
            conn.Conn.Open();
           
            SqlCommand command = new SqlCommand("Proc_addKhuyenMai", conn.Conn);
            
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idPromotion", khuyenMai.IdPromotion);
            command.Parameters.AddWithValue("@namePromotion", khuyenMai.NamePromotion);
            command.Parameters.AddWithValue("@status", khuyenMai.Status);
            command.Parameters.AddWithValue("@startDay", khuyenMai.StartDay);
            command.Parameters.AddWithValue("@endDay", khuyenMai.EndDay);
            command.Connection = conn.Conn;
          
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }
        public void updateKhuyenMai(KhuyenMaiDTO khuyenMai)
        {

            conn.Conn.Open();

            SqlCommand command = new SqlCommand("Proc_updateKhuyenMai", conn.Conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idPromotion", khuyenMai.IdPromotion);
            command.Parameters.AddWithValue("@namePromotion", khuyenMai.NamePromotion);
            command.Parameters.AddWithValue("@status", khuyenMai.Status);
            command.Parameters.AddWithValue("@startDay", khuyenMai.StartDay);
            command.Parameters.AddWithValue("@endDay", khuyenMai.EndDay);
            command.Connection = conn.Conn;

            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }
        public void deleteKhuyenMai(int idPromotion)
        {

            conn.Conn.Open();

            SqlCommand command = new SqlCommand("Proc_deleteKhuyenMai", conn.Conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idPromotion", idPromotion);
           
            command.Connection = conn.Conn;

            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public List<KhuyenMaiDTO> listPromotion()
        {
            List<KhuyenMaiDTO> listPromotion = new List<KhuyenMaiDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_KhuyenMai";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idPromotion = int.Parse(reader["idPromotion"].ToString());
                    string namePromotions = reader["namePromotions"].ToString();
                    string status = reader["status"].ToString();
                    DateTime startDay = DateTime.Parse(reader["startDay"].ToString());
                    DateTime endDay = DateTime.Parse(reader["endDay"].ToString());
                    KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO(idPromotion, namePromotions, status, startDay, endDay);
                    listPromotion.Add(khuyenMaiDTO);

                }
            }

            conn.Conn.Close();
            reader.Close();
            return listPromotion;
        }

    }
}
