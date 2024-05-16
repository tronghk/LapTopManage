using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private Connect conn = new Connect();
        // thêm 1 nhà cung cấp
        public void addSupplier(NhaCungCapDTO ncc)
        {
            // kết nối với connect
            conn.Conn.Open();
            // tạo lớp kết nối sqlCommand 
            SqlCommand command = new SqlCommand("Proc_addSupplier", conn.Conn);
            // đặt tên biến
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idSupplier", ncc.IdSupplier);
            command.Parameters.AddWithValue("@nameSupplier", ncc.NameSupplier);
            command.Connection = conn.Conn;
            // tạo biến reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void deleteSupplier(string IdSupplier)
        {
            conn.Conn.Open();
            SqlCommand command = new SqlCommand("Proc_deleteSupplier", conn.Conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idSupplier", IdSupplier);
            command.Connection = conn.Conn;
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }

        public void updateSupplier(NhaCungCapDTO ncc)
        {
            // kết nối với connect
            conn.Conn.Open();
            // tạo lớp kết nối sqlCommand 
            SqlCommand command = new SqlCommand("Proc_updateSupplier", conn.Conn);
            // đặt tên biến
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idSupplier", ncc.IdSupplier);
            command.Parameters.AddWithValue("@nameSupplier", ncc.NameSupplier);
            command.Connection = conn.Conn;
            // tạo biến reader
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Conn.Close();
        }
        public NhaCungCapDTO searchToId(string idSupplier)
        {
            conn.Conn.Open();
            NhaCungCapDTO p = null;
            // tạo lớp kết nối sqlCommand 
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_NhaCungCap where idSupplier = @idSupplier";
            command.CommandText = query;
            command.Parameters.AddWithValue("idSupplier", idSupplier);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nameSupplier = reader["nameSupplier"].ToString();
                    p = new NhaCungCapDTO(idSupplier, nameSupplier);
                }
            }
            reader.Close();
            conn.Conn.Close();
            command.Connection.Close();
            return p;

        }
        public List<NhaCungCapDTO> listSupplier()
        {
            conn.Conn.Open();
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();
            NhaCungCapDTO p = null;
            // tạo lớp kết nối sqlCommand 
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_NhaCungCap ";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string nameSupplier = reader["nameSupplier"].ToString();
                    string idSupplier = reader["idSupplier"].ToString();
                    p = new NhaCungCapDTO(idSupplier, nameSupplier);
                    list.Add(p);
                }
            }
            reader.Close();
            conn.Conn.Close();
            command.Connection.Close();
            return list;

        }
    }
}
