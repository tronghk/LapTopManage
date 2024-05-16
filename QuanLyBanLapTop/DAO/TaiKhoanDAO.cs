using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class TaiKhoanDAO
    {
        private Connect connect = new Connect();
        public UserDTO searchUser(UserDTO us)
        {
           
            
            connect.Conn.Open();
            SqlCommand sqlCommand = new SqlCommand("proc_login", connect.Conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@user", us.UserName);
            sqlCommand.Parameters.AddWithValue("@pass", us.Password);

            sqlCommand.Connection = connect.Conn;

            SqlDataReader reader = sqlCommand.ExecuteReader();
            UserDTO user = null;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string idUser = reader["idUser"].ToString();
                    string UserName = reader["UserName"].ToString();
                    string Password = reader["Password"].ToString();
                    int idQuyen = int.Parse(reader["idQuyen"].ToString());
                    user = new UserDTO(idUser, UserName, Password, idQuyen);
                }
                

            }
            reader.Close();
            connect.Conn.Close();
            return user;
        }
        public void addImage(string idProduct,string temp)
        {
            connect.Conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connect.Conn;
            string query = "update Tbl_SanPham set "+
                "image = @image" + " where idProduct = @idProduct";
            command.Parameters.AddWithValue("@idProduct",idProduct);
            command.Parameters.AddWithValue("@image", temp);
            command.CommandText = query;
            
            command.ExecuteNonQuery();
            connect.Conn.Close();
        }
        public void addUser(UserDTO us)
        {
            
            connect.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.Conn;
            string query = @"insert into Tbl_TaiKhoan(idUser, UserName, Password, idQuyen)" +
                " values(@idUser,@UserName,@Password,@idQuyen)";
            command.CommandText = query;
            command.Parameters.AddWithValue("@UserName", us.UserName);
            command.Parameters.AddWithValue("@Password", us.Password);
            command.Parameters.AddWithValue("@idUser", us.Id);
            command.Parameters.AddWithValue("@idQuyen", us.IdQuyen);
            command.Connection = connect.Conn;
            command.ExecuteNonQuery();
            connect.Conn.Close();
        }
        public List<UserDTO> listUser()
        {
            List<UserDTO> list = new List<UserDTO>();
            connect.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connect.Conn;
            string query = "select * from Tbl_TaiKhoan";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read())
                {
                    string idUser = reader["idUser"].ToString();
                    string UserName = reader["UserName"].ToString();
                    string Password = reader["Password"].ToString();
                    int idQuyen = int.Parse(reader["idQuyen"].ToString());
                    UserDTO us = new UserDTO(idUser, UserName, Password, idQuyen);
                    list.Add(us);
                }
            }
            reader.Close();
            connect.Conn.Close();
            return list;
        }
       
    }
}
