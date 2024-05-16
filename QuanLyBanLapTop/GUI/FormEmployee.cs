using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.UtilsGUI;
using static BUS.EmployeeManage;
using System.Xml.Linq;
using static GUI.FormMainMenu;

namespace GUI
{
    public partial class FormEmployee : Form
    {
        FormInfoEmployee fInfoEmployee;
        EmployeeManage employeeManage = new EmployeeManage();
        private int index = -1;
        public FormEmployee()
        {
            InitializeComponent();
            initializationDataEmployee();
            initializationDataTopEmployee();
            initializationDataServiceEmployee();
        }
        public void initializationDataEmployee()
        {
            tb_employee.ColumnCount = 6;
            tb_employee.Columns[0].Name = "Mã nhân viên";
            tb_employee.Columns[1].Name = "Tên nhân viên";
            tb_employee.Columns[2].Name = "Chức vụ";
            tb_employee.Columns[3].Name = "Sinh nhật";
            tb_employee.Columns[4].Name = "Số điện thoại";
            tb_employee.Columns[5].Name = "Lương";
            autoSizetb(tb_employee);
            setDataEmployee(listEmployee());
        }
        public void initializationDataServiceEmployee()
        {
            string[] service = new string[] { "Quản lý", "Nhân viên kỹ thuật", "Nhân viên bán hàng"
            ,"Nhân viên thu ngân","Chăm sóc khách hàng"};
            cbb_service.DataSource = service;
            cbb_service.SelectedIndex = 0;
        }
        public void initializationDataTopEmployee()
        {
            tb_topEmployee.ColumnCount = 3;
            tb_topEmployee.Columns[0].Name = "Tên nhân viên";
            tb_topEmployee.Columns[1].Name = "Tổng hoá đơn";
            tb_topEmployee.Columns[2].Name = "Doanh thu";
            autoSizetb(tb_topEmployee);
            setDataTopEmployee();
        }
        public void setDataEmployee(List<NhanVien> list)
        {
            tb_employee.Rows.Clear();

            foreach (NhanVien item in list)
            {

                string[] row = new string[] { item.Id, item.Name,item.ServiceEmployee,item.Birthday.ToString(),item.Phone,
                    item.SalaryEmployee.ToString("0.0")
                   };
                tb_employee.Rows.Add(row);
            }
        }
        public void setDataTopEmployee()
        {
            List<NhanVien> list = employeeManage.topEmployee();
            foreach (NhanVien item in list)
            {
                string[] row = new string[] {item.Name,item.QuantityBillPay.ToString(),item.TotalSales.ToString("0.0") };
                tb_topEmployee.Rows.Add(row);
            }

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            List<NhanVien> list = searchEmployee(search);
            setDataEmployee(list);
        }

        private void eventClickCellEmployee(object sender, DataGridViewCellEventArgs e)
        {
            if (tb_employee.RowCount > 1)
                if (tb_employee.CurrentRow != null)
                {
                    int rowindex = tb_employee.CurrentCell.RowIndex;
                    if (tb_employee.Rows.Count - 2 >= rowindex)
                    {
                        tb_employee.ReadOnly = true;
                        string id = tb_employee.Rows[rowindex].Cells[0].Value.ToString();
                        string name = tb_employee.Rows[rowindex].Cells[1].Value.ToString();
                        string service = tb_employee.Rows[rowindex].Cells[2].Value.ToString();
                        string birthday = tb_employee.Rows[rowindex].Cells[3].Value.ToString();
                        string phone = tb_employee.Rows[rowindex].Cells[4].Value.ToString();
                        string salary = tb_employee.Rows[rowindex].Cells[5].Value.ToString();
                        displayInfoEmployee(id, name, service, birthday, phone, salary);
                        eventClickEmployee(id, rowindex);
                    }

                }
        }
        public int returnIndexService(string name)
        {
            string[] service = new string[] { "Quản lý", "Nhân viên kỹ thuật", "Nhân viên bán hàng"
            ,"Nhân viên thu ngân","Chăm sóc khách hàng"};
            int index = 0;
            foreach (string s in service)
            {
                if (name == s)
                    break;
                index++;
            }
            return index;
        }
        public void displayInfoEmployee(string id, string name, string service, string birthday, string phone, string salary)
        {
            inp_id.Text = id;
            inp_name.Text = name;
            inp_phone.Text = phone;
            inp_salary.Text = float.Parse(salary).ToString("0.0");
            date_birthday.Text = DateTime.Parse(birthday).ToString();
            cbb_service.SelectedIndex = returnIndexService(service);
        }
        public void resetText()
        {
            inp_id.Text = "";
            inp_name.Text = "";
            inp_salary.Text = "";
            inp_phone.Text = "";
            date_birthday.Text = DateTime.Today.ToString();
            cbb_service.SelectedIndex = 0;
        }
        public void resetError()
        {
            error_id.Text = "";
            error_name.Text = "";
            error_phone.Text = "";
            error_salary.Text = "";
            txt_success.Text = "";
        }
        public void eventClickEmployee(string idEmployee, int index)
        {
            if (index == this.index)
            {
                this.index = -1;
                this.fInfoEmployee = new FormInfoEmployee(idEmployee);
                guna2Panel1.Controls.Clear();
                fInfoEmployee.TopLevel = false;
                //pnlBody.Controls.Add(guna2Panel2);
                guna2Panel1.Controls.Add(fInfoEmployee);
                fInfoEmployee.Dock = DockStyle.Fill;
                fInfoEmployee.Show();
                displayPanel(null);
            }
            else
            {
                this.index = index;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {            
            string id = inp_id.Text;
            string name = inp_name.Text;
            string service = cbb_service.Text;
            DateTime birthday = DateTime.Parse(date_birthday.Text);
            string phone = inp_phone.Text;
            string salary = inp_salary.Text;
            string result = employeeManage.addEmployee(id, name, service, birthday, phone, salary);
            eventResult(result, "add");
        }
        public void eventResult(string result, string word)
        {
            resetError();
            if (result.Contains("error_isNull"))
                error_id.Text = "!Mã rỗng";
            if (result.Contains("error_nameNull"))
                error_name.Text = "!Tên rỗng";
            if (result.Contains("error_duplicateId"))
                if (word == "add")
                    error_id.Text = "Trùng lặp mã";
                else
                    error_id.Text = "Không tìm thấy NV";
            if (result.Contains("error_phone"))
                error_phone.Text = "SĐT không hợp lệ";
            if (result.Contains("error_float"))
                error_salary.Text = "Lương không hợp lệ";
            if (result == "success")
            {
                if (word == "add")
                    txt_success.Text = "Đã thêm nhân viên";
                else if (word == "edit")
                    txt_success.Text = "Đã sửa nhân viên";
                else
                {
                    txt_success.Text = "Đã xoá nhân viên";
                    resetText();
                    
                }
                setDataEmployee(listEmployee());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = inp_id.Text;
            string name = inp_name.Text;
            string service = cbb_service.Text;
            DateTime birthday = DateTime.Parse(date_birthday.Text);
            string phone = inp_phone.Text;
            string salary = inp_salary.Text;
            string result = employeeManage.updateEmployee(id, name, service, birthday, phone, salary);
            eventResult(result, "edit");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = inp_id.Text;
            string result = employeeManage.deleteEmployee(id);
            eventResult(result, "delete");
        }
    }
}
