using BUS;
using DTO;
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
using static BUS.CustomerManage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormCustomer : Form
    {
        FormInfoCustomer fInfoCustomer;
        private CustomerManage customerManage = new CustomerManage();
        private int index = -1;
        public FormCustomer()
        {
            InitializeComponent();
            initializationDataCustomer();
            initializationDataTopCustomer();
            
        }
        public void initializationDataCustomer()
        {
            tb_customer.ColumnCount = 5;
            tb_customer.Columns[0].Name = "Mã khách hàng";
            tb_customer.Columns[1].Name = "Tên khách hàng";
            tb_customer.Columns[2].Name = "Địa chỉ";
            tb_customer.Columns[3].Name = "Số điện thoại";
            tb_customer.Columns[4].Name = "Email";
            autoSizetb(tb_customer);
            setDataCustomer(listCustomer());
        }
        public void initializationDataTopCustomer()
        {
            tb_topCustomer.ColumnCount = 3;
            tb_topCustomer.Columns[0].Name = "Tên khách hàng";
            tb_topCustomer.Columns[1].Name = "Tổng hoá đơn";
            tb_topCustomer.Columns[2].Name = "Doanh số";
            autoSizetb(tb_topCustomer);
            setDataTopCustomer();
        }
        public void setDataCustomer(List<KhachHang> list)
        {
            tb_customer.Rows.Clear();
            
            foreach (KhachHang item in list)
            {
                
                string[] row = new string[] { item.Id, item.Name,item.Address,item.Phone,item.Email
                   };
                tb_customer.Rows.Add(row);
            }
        }
        public void setDataTopCustomer()
        {
            List<Dictionary<string, string>> list = customerManage.topCustomer();
            foreach (Dictionary<string, string> item in list)
            {
                string name = item["name"];
                string sumBill = item["sumBill"];
                string total = float.Parse(item["sumMoney"]).ToString("0.0");
                string [] row = new string[] {name,sumBill,total};
                tb_topCustomer.Rows.Add(row);
            }

        }
        

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            resetText();
            resetError();
            inp_idCustomer.ReadOnly = false;
            
        }

        private void eventSearchCustomer(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            List<KhachHang> list = searchCustomer(search);
            setDataCustomer(list);
        }

        private void eventClickCellCustomer(object sender, DataGridViewCellEventArgs e)
        {

            if (tb_customer.RowCount > 1)
                if (tb_customer.CurrentRow != null)
                {
                    int rowindex = tb_customer.CurrentCell.RowIndex;
                    if (tb_customer.Rows.Count - 2 >= rowindex)
                    {
                        inp_idCustomer.ReadOnly = true;
                        string id = tb_customer.Rows[rowindex].Cells[0].Value.ToString();
                        string name = tb_customer.Rows[rowindex].Cells[1].Value.ToString();
                        string address = tb_customer.Rows[rowindex].Cells[2].Value.ToString();
                        string phone = tb_customer.Rows[rowindex].Cells[3].Value.ToString();
                        string email = tb_customer.Rows[rowindex].Cells[4].Value.ToString();
                        displayInfoCustomer(id, name, address, phone, email);
                        eventClickCustomer(id,rowindex);
                    }

                }
        }
        public void eventClickCustomer(string idCustomer, int index)
        {
            if(index == this.index)
            {
                index = -1;
                this.fInfoCustomer = new FormInfoCustomer(idCustomer);
                guna2Panel1.Controls.Clear();
                fInfoCustomer.TopLevel = false;
                //pnlBody.Controls.Add(guna2Panel2);
                guna2Panel1.Controls.Add(fInfoCustomer);
                fInfoCustomer.Dock = DockStyle.Fill;
                fInfoCustomer.Show();
            }
            else
            {
                this.index = index;
            }
        }
        public void displayInfoCustomer(string id, string name, string address, string phone, string email)
        {
            inp_idCustomer.Text = id;
            inp_name.Text = name;
            inp_address.Text = address;
            inp_email.Text = email;
            inp_phone.Text = phone;
        }
        public void resetText()
        {
            inp_idCustomer.Text = "";
            inp_name.Text = "";
            inp_address.Text = "";
            inp_email.Text = "";
            inp_phone.Text = "";
        }
        public void resetError()
        {
            error_id.Text = "";
            error_name.Text = "";
            error_phone.Text = "";
            txt_success.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = inp_idCustomer.Text;
            string name = inp_name.Text;
            string address = inp_address.Text;
            string phone = inp_phone.Text;
            string email = inp_email.Text;
            string result = customerManage.addCustomer(id, name, address, phone, email);
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
                    error_id.Text = "Không tìm thấy KH";
            if (result.Contains("error_phone"))
                error_phone.Text = "SĐT không hợp lệ";
            if(result == "success")
            {
                if (word == "add")
                    txt_success.Text = "Đã thêm khách hàng";
                else if (word == "edit")
                    txt_success.Text = "Đã sửa khách hàng";
                else
                    txt_success.Text = "Đã xoá khách hàng";
                setDataCustomer(listCustomer());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = inp_idCustomer.Text;
            string name = inp_name.Text;
            string address = inp_address.Text;
            string phone = inp_phone.Text;
            string email = inp_email.Text;
            string result = customerManage.updateCustomer(id, name, address, phone, email);
            eventResult(result, "edit");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = inp_idCustomer.Text;
            string result = customerManage.deleteCustomer(id);
            eventResult(result, "delete");
        }
    }
}
