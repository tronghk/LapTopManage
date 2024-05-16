using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static GUI.UtilsGUI;
using static BUS.CustomerManage;
using BUS;
using static BUS.BillManage;
using System.IO;

namespace GUI
{
    public partial class FormInfoPayment : Form
    {
        private ProductManage productManage = new ProductManage();
        private BillManage billManage = new BillManage();
        private int idBill;
        private string idCustomer = "";
        public FormInfoPayment(int idBill)
        {
            this.idBill = idBill;
            InitializeComponent();
            initializationDataCustomer();
            initializationDataTypePayment();
            initializationDetails();
            resetText();

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
        public void sumPayment(int idBill)
        {
            HoaDon b = bill(idBill);
            txt_sumPayment.Text = b.Pay.ToString("0.0");
        }
        public void initializationDetails()
        {
            tb_detailsBill.ColumnCount = 6;
            tb_detailsBill.Columns[0].Name = "Tên sản phẩm";
            tb_detailsBill.Columns[1].Name = "Đơn giá";
            tb_detailsBill.Columns[2].Name = "Số lượng mua";
            tb_detailsBill.Columns[3].Name = "Tổng tiền";
            tb_detailsBill.Columns[4].Name = "Tiền đã giảm";
            tb_detailsBill.Columns[5].Name = "Thành tiền";
            autoSizetb(tb_detailsBill);
            setDataDetailsBill(this.idBill);
            sumPayment(idBill);
        }
        public void setDataDetailsBill(int idBill)
        {
            this.tb_detailsBill.Rows.Clear();
            List<ChiTietHoaDonDTO> list = listDetailsBill(idBill);
            foreach (ChiTietHoaDonDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] {p.NameProduct, p.UnitPrice.ToString("0.0"),
                    item.QuantityProduct.ToString(), (item.IntoMoney).ToString("0.0"),
                    item.MoneyDown.ToString("0.0"),(item.IntoMoney-item.MoneyDown).ToString("0.0") };
                tb_detailsBill.Rows.Add(row);
            }

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

        public void openForm(Form f)
        {

            guna2Panel1.Controls.Clear();
            f.TopLevel = false;
            guna2Panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void eventClickCellCustomer(object sender, DataGridViewCellEventArgs e)
        {
            if (tb_customer.RowCount > 1)
                if (tb_customer.CurrentRow != null)
                {
                    int rowindex = tb_customer.CurrentCell.RowIndex;
                    if (tb_customer.Rows.Count - 2 >= rowindex)
                    {

                        string id = tb_customer.Rows[rowindex].Cells[0].Value.ToString();
                        string name = tb_customer.Rows[rowindex].Cells[1].Value.ToString();
                        string address = tb_customer.Rows[rowindex].Cells[2].Value.ToString();
                        string phone = tb_customer.Rows[rowindex].Cells[3].Value.ToString();
                        string email = tb_customer.Rows[rowindex].Cells[4].Value.ToString();
                        displayInfoCustomer(id, name, address, phone, email);
                        this.idCustomer = id;

                    }

                }
        }
        public void displayInfoCustomer(string id, string name, string address, string phone, string email)
        {
            txt_id.Text = id;
            txt_name.Text = name;
            txt_phone.Text = address;
            txt_address.Text = email;
            txt_email.Text = phone;
        }
        public void resetText()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            cbb_typePayment.SelectedIndex = 0;
        }
        public void initializationDataTypePayment()
        {
            string[] service = new string[] { "Trực tiếp", "Card", "Momo"
            };
            cbb_typePayment.DataSource = service;
            cbb_typePayment.SelectedIndex = 0;
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            resetText();
            this.idCustomer = "";
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            List<KhachHang> list = searchCustomer(search);
            setDataCustomer(list);
        }

        private void cbb_typePayment_SelectedIndexChanged(object sender, EventArgs e)
        {

            string text = "Loại thanh toán: " + cbb_typePayment.Text;
            txt_typePayment.Text = text;
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            HoaDon b = bill(this.idBill);
            b.Status = "Đã thanh toán";
            b.IdCustomer = this.idCustomer;
            billManage.updateBill(b);
            //in hoá đơn
            exportPdf(b.IdBill);
            displayBill();

        }
        public void displayBill()
        {
            FormBill fBill = new FormBill();
            guna2Panel1.Controls.Clear();
            fBill.TopLevel = false;
            guna2Panel1.Controls.Add(fBill);
            fBill.Dock = DockStyle.Fill;
            fBill.Show();
        }
        public void exportPdf(int idBill)
        {
            if (tb_detailsBill.Rows.Count > 0)

            {
                MessageBox.Show("Thanh toán thành công, mã hoá đơn: " + idBill, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
