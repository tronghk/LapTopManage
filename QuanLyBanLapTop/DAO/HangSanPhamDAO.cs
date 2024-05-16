using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HangSanPhamDAO
    {
        private Connect conn = new Connect();

        public void addHangSanPham(HangSanPhamDTO hsp)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_addManufacture", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", hsp.IdManufactutre);
            command.Parameters.AddWithValue("@name", hsp.NameManufacturer);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void updateHangSanPham(HangSanPhamDTO hsp)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_updateManufacture", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", hsp.IdManufactutre);
            command.Parameters.AddWithValue("@name", hsp.NameManufacturer);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void deleteHangSanPham(int id)
        {
            // ket noi voi connect
            conn.Conn.Open();
            // tao lop ket noi sqlCommand
            SqlCommand command = new SqlCommand("Proc_deleteManufacture", conn.Conn);
            // dat ten bien
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.Connection = conn.Conn;
            // tao bien reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }
        public int searchIdManuProduct(string nameManufactutre)
        {
            int id = 0;

            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HangSP where nameManufactutre = @nameManufactutre";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@nameManufactutre", nameManufactutre);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = int.Parse(reader["idManufactutre"].ToString());
                    break;
                }
            }

            conn.Conn.Close();
            reader.Close();
            return id;
        }
        public HangSanPhamDTO searchManuProduct(string idManufactutre)
        {
            conn.Conn.Close();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_HangSP where idManufactutre = @idManufactutre";

            command.CommandText = query;
            command.Parameters.AddWithValue("@idManufactutre", idManufactutre);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = int.Parse(reader["idManufactutre"].ToString());
                    string name = reader["nameManufactutre"].ToString();
                    return new HangSanPhamDTO(id, name);
                    
                }
            }

            conn.Conn.Close();
            reader.Close();
            return null;
        }
        public List<HangSanPhamDTO> listBrandProduct()
        {
            List<HangSanPhamDTO> listBrandProduct = new List<HangSanPhamDTO>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_HangSP";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int idManufactutre = int.Parse(reader["idManufactutre"].ToString());
                    string nameManufactutre = reader["nameManufactutre"].ToString();
                    HangSanPhamDTO brand = new HangSanPhamDTO(idManufactutre, nameManufactutre);
                    listBrandProduct.Add(brand);
                }
            }

            conn.Conn.Close();
            reader.Close();
            return listBrandProduct;
        }
    }
}
