using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDao
    {
        private Connect conn = new Connect();
        
        // thêm 1 quyền
        public void addNhanVien(NhanVien nv)
        {
            //kết nối với connect
            conn.Conn.Open();

            //tạo lớp kết nối sqlCommand
            SqlCommand command = new SqlCommand("Proc_addEmployee", conn.Conn);
            //proc lát mình tạo trong sqlServer
            //đặt tên biến 
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idEmployee", nv.Id);
            command.Parameters.AddWithValue("@nameEmployee", nv.Name);
            command.Parameters.AddWithValue("@serviceEmployee", nv.ServiceEmployee);
            command.Parameters.AddWithValue("@phoneNumber", nv.Phone);
            command.Parameters.AddWithValue("@salaryEmployee", nv.SalaryEmployee);
            command.Parameters.AddWithValue("@birthday", nv.Birthday);
            command.Parameters.AddWithValue("@totalSales", nv.TotalSales);
            command.Parameters.AddWithValue("@quantityBillPay", nv.QuantityBillPay);
            command.Parameters.AddWithValue("@idUser", nv.IdUser);
            command.Connection = conn.Conn;
            // tạo biến reader 
            command.ExecuteNonQuery();

            conn.Conn.Close();
            // xong giờ qua tạo biến proc là ok;
        }

        public void updateNhanVien(NhanVien nv)
        {
           
            //kết nối với connect
            conn.Conn.Open();

            //tạo lớp kết nối sqlCommand
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = "update Tbl_NhanVien set nameEmployee = @nameEmployee, serviceEmployee = @serviceEmployee," +
                " phoneNumber = @phoneNumber, salaryEmployee = @salaryEmployee, birthday =@birthday, totalSales = @totalSales" +
                ", quantityBillPay = @quantityBillPay where  idEmployee = @idEmployee";
            command.CommandText = query;
            command.Parameters.AddWithValue("@idEmployee", nv.Id);
            command.Parameters.AddWithValue("@nameEmployee", nv.Name);
            command.Parameters.AddWithValue("@serviceEmployee", nv.ServiceEmployee);
            command.Parameters.AddWithValue("@phoneNumber", nv.Phone);
            command.Parameters.AddWithValue("@salaryEmployee", nv.SalaryEmployee);
            command.Parameters.AddWithValue("@birthday", nv.Birthday);
            command.Parameters.AddWithValue("@totalSales", nv.TotalSales);
            command.Parameters.AddWithValue("@quantityBillPay", nv.QuantityBillPay);
            command.ExecuteNonQuery();

            conn.Conn.Close();
            // xong giờ qua tạo biến proc là ok;
        }

        public void deleteEmployee(string id)
        {
            //kết nối với connect
            conn.Conn.Open();

            //tạo lớp kết nối sqlCommand
            SqlCommand command = new SqlCommand("Proc_deleteEmployee", conn.Conn);
            //proc lát mình tạo trong sqlServer
            //đặt tên biến 
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idEmployee", id);
            command.Connection = conn.Conn;
            // tạo biến reader 
            command.ExecuteNonQuery();

            conn.Conn.Close();
            // xong giờ qua tạo biến proc là ok;
        }
        public List<NhanVien> listEmployee()
        {
            List<NhanVien> list = new List<NhanVien>();
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            string query = " select * from Tbl_NhanVien";
            command.Connection = conn.Conn;
            command.CommandText = query;
           SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string idEmployee = reader["idEmployee"].ToString();
                    string nameEmployee = reader["nameEmployee"].ToString();
                    string serviceEmployee = reader["serviceEmployee"].ToString();
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    string phoneNumber = reader["phoneNumber"].ToString();
                    float salaryEmployee = float.Parse(reader["salaryEmployee"].ToString());
                    float totalSales = float.Parse(reader["totalSales"].ToString());
                    int quantityBillPay = int.Parse(reader["quantityBillPay"].ToString());
                    string idUser = reader["idUser"].ToString();
                    NhanVien employee = new NhanVien(idEmployee, nameEmployee, serviceEmployee, birthday, phoneNumber, totalSales, quantityBillPay, idUser, salaryEmployee);
                    list.Add(employee);
                }
            }
            reader.Close();
            command.Dispose();
            conn.Conn.Close();
            return list;
        }
        public NhanVien searchEmployee(string idEmployee)
        {

            conn.Conn.Close();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @" select * from Tbl_NhanVien where idEmployee = @idEmployee";
            
            command.CommandText = query;
            command.Parameters.AddWithValue("@idEmployee", idEmployee);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    string nameEmployee = reader["nameEmployee"].ToString();
                    string serviceEmployee = reader["serviceEmployee"].ToString();
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    string phoneNumber = reader["phoneNumber"].ToString();
                    float salaryEmployee = float.Parse(reader["salaryEmployee"].ToString());
                    float totalSales = float.Parse(reader["totalSales"].ToString());
                    int quantityBillPay = int.Parse(reader["quantityBillPay"].ToString());
                    string idUser = reader["idUser"].ToString();
                    NhanVien employee = new NhanVien(idEmployee, nameEmployee, serviceEmployee, birthday, phoneNumber, totalSales, quantityBillPay, idUser, salaryEmployee);
                    return employee;
                }
            }
            reader.Close();
            command.Dispose();
            conn.Conn.Close();
            return null;
        }
        public NhanVien searchEmployeeIdUser(string idUser)
        {

            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn.Conn;
            string query = @" select * from Tbl_NhanVien where idUser = @idUser";

            command.CommandText = query;
            command.Parameters.AddWithValue("@idUser", idUser);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    string nameEmployee = reader["nameEmployee"].ToString();
                    string serviceEmployee = reader["serviceEmployee"].ToString();
                    DateTime birthday = DateTime.Parse(reader["birthday"].ToString());
                    string phoneNumber = reader["phoneNumber"].ToString();
                    float salaryEmployee = float.Parse(reader["salaryEmployee"].ToString());
                    float totalSales = float.Parse(reader["totalSales"].ToString());
                    int quantityBillPay = int.Parse(reader["quantityBillPay"].ToString());
                    string idEmployee = reader["idEmployee"].ToString();
                    NhanVien employee = new NhanVien(idEmployee, nameEmployee, serviceEmployee, birthday, phoneNumber, totalSales, quantityBillPay, idUser, salaryEmployee);
                    return employee;
                }
            }
            reader.Close();
            command.Dispose();
            conn.Conn.Close();
            return null;
        }
        public void updateTotalSalesEmployee(string idEmployee, float sumMoney)
        {
            
            
            conn.Conn.Open();
            SqlCommand command = new SqlCommand();
            
            command.Connection = conn.Conn;
            NhanVien employee = searchEmployee(idEmployee);
            
            string query = @" update Tbl_NhanVien set quantityBillPay = @quantityBillPay, totalSales = @totalSales where idEmployee = @idEmployee";
            command.CommandText = query;
            command.Parameters.AddWithValue("@quantityBillPay", employee.QuantityBillPay+1); 
            command.Parameters.AddWithValue("@totalSales", employee.TotalSales + sumMoney);
            command.Parameters.AddWithValue("@idEmployee", employee.Id);
            command.ExecuteNonQuery();

            command.Dispose();
            conn.Conn.Close();
        }
    }

    
}
