using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private Connect conn = new Connect();

        public void addProcduct( SanPham sp)
        {
            
            conn.Conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "insert into Tbl_SanPham (idProduct,nameProduct,unitPrice" +
                ",quantityProduct,statusProduct,idTypeProduct," +
                "idManufactutre,image)" + " values(@idProduct,@nameProduct," +
                "@unitPrice,@quantityProduct,@statusProduct, @idTypeProduct," +
                "@idManufactutre,@image)";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idProduct", sp.IdProduct);
            command.Parameters.AddWithValue("@nameProduct", sp.NameProduct);
            command.Parameters.AddWithValue("@unitPrice", sp.UnitPrice);
            command.Parameters.AddWithValue("@quantityProduct", sp.QuantityProduct);
            command.Parameters.AddWithValue("@statusProduct", sp.StatusProduct);
            command.Parameters.AddWithValue("@idTypeProduct", sp.IdTypeProduct);
            command.Parameters.AddWithValue("@idManufactutre", sp.IDManuFacture);
            command.Parameters.AddWithValue("@image", sp.Image);


            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public void updateProcduct(SanPham sp)
        {
            conn.Conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "update Tbl_SanPham set nameProduct = @nameProduct," +
                " unitPrice = @unitPrice, quantityProduct = @quantityProduct," +
                "statusProduct = @statusProduct, idTypeProduct = @idTypeProduct," +
                "idManufactutre = @idManufactutre," +
                "image = @image" + " where idProduct = @idProduct";

            command.CommandText = query;
            command.Parameters.AddWithValue("@idProduct", sp.IdProduct);
            command.Parameters.AddWithValue("@nameProduct", sp.NameProduct);
            command.Parameters.AddWithValue("@unitPrice", sp.UnitPrice);
            command.Parameters.AddWithValue("@quantityProduct", sp.QuantityProduct);
            command.Parameters.AddWithValue("@statusProduct", sp.StatusProduct);
            command.Parameters.AddWithValue("@idTypeProduct", sp.IdTypeProduct);
            command.Parameters.AddWithValue("@idManufactutre", sp.IDManuFacture);
            command.Parameters.AddWithValue("@image", sp.Image);

            command.ExecuteNonQuery();

            conn.Conn.Close();
        }

        public void deleteProcduct(string id)
        {
            conn.Conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "delete from Tbl_SanPham where idProduct = @idProduct";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idProduct", id);

            command.ExecuteNonQuery();

            conn.Conn.Close();
        }
        public void deleteProcductToIdType(string idTypeProduct)
        {
            conn.Conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "delete from Tbl_SanPham where idTypeProduct = @idTypeProduct";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idTypeProduct", idTypeProduct);

            command.ExecuteNonQuery();

            conn.Conn.Close();
        }
        public List<SanPham> listProduct()
        {
            List<SanPham> listSp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "select * from Tbl_SanPham";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   
                    string idProduct = reader["idProduct"].ToString();
                    string nameProduct = reader["nameProduct"].ToString();
                    
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    int quantityProduct = int.Parse(reader["quantityProduct"].ToString());
                    string statusProduct = reader["statusProduct"].ToString();
                    int idTypeProduct = int.Parse(reader["idTypeProduct"].ToString());
                    int idManufactutre = int.Parse(reader["idManufactutre"].ToString());
                    string image = reader["image"].ToString();
                    SanPham sp = new SanPham(idProduct, nameProduct, unitPrice, quantityProduct, statusProduct, idTypeProduct, idManufactutre, image);
                    listSp.Add(sp);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listSp;
        }
        public List<SanPham> searchType(int idTypeProduct)
        {
            List<SanPham> listSp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_SanPham where idTypeProduct = @idTypeProduct";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@idTypeProduct", idTypeProduct);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    string idProduct = reader["idProduct"].ToString();
                    string nameProduct = reader["nameProduct"].ToString();
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    int quantityProduct = int.Parse(reader["quantityProduct"].ToString());
                    string statusProduct = reader["statusProduct"].ToString();
                    int idManufactutre = int.Parse(reader["idManufactutre"].ToString());
                    string image = reader["image"].ToString();
                    SanPham sp = new SanPham(idProduct, nameProduct, unitPrice, quantityProduct, statusProduct, idTypeProduct, idManufactutre, image);
                    listSp.Add(sp);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listSp;

        }
        public List<SanPham> searchManufacturer(int idManufactutre)
        {
            List<SanPham> listSp = new List<SanPham>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_SanPham where idManufactutre = @idManufactutre";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@idManufactutre", idManufactutre);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    string idProduct = reader["idProduct"].ToString();
                    string nameProduct = reader["nameProduct"].ToString();
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    int quantityProduct = int.Parse(reader["quantityProduct"].ToString());
                    string statusProduct = reader["statusProduct"].ToString();
                    int idTypeProduct = int.Parse(reader["idTypeProduct"].ToString());
                    string image = reader["image"].ToString();
                    SanPham sp = new SanPham(idProduct, nameProduct, unitPrice, quantityProduct, statusProduct, idTypeProduct, idManufactutre, image);
                    listSp.Add(sp);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listSp;

        }
        public SanPham searchId(string idProduct)
        {
            SanPham p = null;
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"select * from Tbl_SanPham where idProduct = @idProduct";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@idProduct", idProduct);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    
                    string nameProduct = reader["nameProduct"].ToString();
                    float unitPrice = float.Parse(reader["unitPrice"].ToString());
                    int quantityProduct = int.Parse(reader["quantityProduct"].ToString());
                    string statusProduct = reader["statusProduct"].ToString();
                    int idTypeProduct = int.Parse(reader["idTypeProduct"].ToString());
                    int idManufactutre = int.Parse(reader["idManufactutre"].ToString());
                    string image = reader["image"].ToString();
                    SanPham sp = new SanPham(idProduct, nameProduct, unitPrice, quantityProduct, statusProduct, idTypeProduct, idManufactutre, image);
                    p = new SanPham(idProduct, nameProduct, unitPrice, quantityProduct, statusProduct, idTypeProduct, idManufactutre, image);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return p;

        }

    }
}
