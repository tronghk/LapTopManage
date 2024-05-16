using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DanhMucLapTopDAO
    {
        private Connect conn = new Connect();

        // them 1 danh muc
        public void addDanhMucLapTop(DanhMucLapTopDTO dm)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_addTypeProduct", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", dm.IdTypeProduct);
            command.Parameters.AddWithValue("@name", dm.NameTypeProduct);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void updateDanhMucLapTop(DanhMucLapTopDTO dm)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_updateTypeProduct", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", dm.IdTypeProduct);
            command.Parameters.AddWithValue("@name", dm.NameTypeProduct);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void deleteDanhMucLapTop(int id)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_deleteTypeProduct", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }
        public List<DanhMucLapTopDTO> listTypeProduct()
        {
            List<DanhMucLapTopDTO> listTypeProduct = new List<DanhMucLapTopDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_DanhMucLapTop";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idTypeProduct = int.Parse(reader["idTypeProduct"].ToString());
                    string nameTypeProduct = reader["nameTypeProduct"].ToString();
                    DanhMucLapTopDTO danhMucLapTopDTO = new DanhMucLapTopDTO(idTypeProduct, nameTypeProduct);
                    listTypeProduct.Add(danhMucLapTopDTO);
                }
            }

            conn.Conn.Close();
            reader.Close();
            return listTypeProduct;
        }
        public int searchIdTypeProduct(string nameTypeProduct)
        {
            int idTypePoroduct = 0;
            
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_DanhMucLapTop where nameTypeProduct = @nameTypeProduct";
           
            command.CommandText = query;
            command.Parameters.AddWithValue("@nameTypeProduct", nameTypeProduct);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idTypePoroduct = int.Parse(reader["idTypeProduct"].ToString());
                    break;
                }
            }

            conn.Conn.Close();
            reader.Close();
            return idTypePoroduct;
        }
        public DanhMucLapTopDTO searchNameProduct(int idTypeProduct)
        {
           
            DanhMucLapTopDTO type = null;
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_DanhMucLapTop where idTypeProduct = @idTypeProduct";

            command.CommandText = query;
            command.Parameters.AddWithValue("@idTypeProduct", idTypeProduct);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string name = reader["nameTypeProduct"].ToString();
                    type = new DanhMucLapTopDTO(idTypeProduct, name);
                    break;
                }
            }

            conn.Conn.Close();
            reader.Close();
            return type;
        }

    }
}
