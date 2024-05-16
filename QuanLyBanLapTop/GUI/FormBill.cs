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
using static BUS.BillManage;
using static BUS.PaymentOrders;

namespace GUI
{
    public partial class FormBill : Form
    {
        public BillManage billManage = new BillManage();
        private ProductManage productManage = new ProductManage();
        private EmployeeManage employeeManage = new EmployeeManage();
        private int idBill = -1;
        private FormInfoPayment fInfoPayment;
        public FormBill()
        {
            InitializeComponent();
            initializationDataBill();
            initializationDetails();


        }
        public void initializationDataBill()
        {
            tb_bill.ColumnCount = 8;
            tb_bill.Columns[0].Name = "ID";
            tb_bill.Columns[1].Name = "Ngày tạo";
            tb_bill.Columns[2].Name = "Tổng tiền";
            tb_bill.Columns[3].Name = "Tiền đã giảm";
            tb_bill.Columns[4].Name = "Tiền phải trả";
            tb_bill.Columns[5].Name = "Trạng thái";
            tb_bill.Columns[6].Name = "Loại thanh toán";
            tb_bill.Columns[7].Name = "Người thanh toán";

            autoSizetb(tb_bill);
            setDataBill(listBill());

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
        }
        public void setDataDetailsBill(int idBill)
        {
            this.tb_detailsBill.Rows.Clear();
            List<ChiTietHoaDonDTO> list = listDetailsBill(idBill);
            foreach (ChiTietHoaDonDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] {p.NameProduct, p.UnitPrice.ToString("0.0"),
                    item.QuantityProduct.ToString(), (item.MoneyDown+item.IntoMoney).ToString("0.0"),
                    item.MoneyDown.ToString("0.0"),item.IntoMoney.ToString("0.0") };
                tb_detailsBill.Rows.Add(row);
            }

        }
        public void setDataBill(List<HoaDon> listBill)
        {

            this.tb_bill.Rows.Clear();
            foreach (HoaDon value in listBill)
            {
                NhanVien employee = employeeManage.searchToId(value.IdEmployee);
                string[] row = new string[] {value.IdBill.ToString(), value.DateBill.Day+"/"+value.DateBill.Month+"/"+value.DateBill.Year,
                    value.SumPay.ToString("0.0"),value.DiscountMoney.ToString("0.0"),value.Pay.ToString("0.0")
                ,value.Status,value.TypePay,employee.Name};
                tb_bill.Rows.Add(row);
            }
        }


        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_titleProduct_Click(object sender, EventArgs e)
        {

        }


        private void tb_detailsBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clickCellBill(object sender, DataGridViewCellEventArgs e)
        {

            if (tb_bill.RowCount > 1)
                if (tb_bill.CurrentRow != null)
                {
                    int rowindex = tb_bill.CurrentCell.RowIndex;
                    
                    if (rowindex <= tb_bill.RowCount-2)
                    {
                        this.idBill = int.Parse(tb_bill.Rows[rowindex].Cells[0].Value.ToString());
                        setDataDetailsBill(this.idBill);
                    }

                }
        }

        private void tb_detailsBill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            
            if (tb_bill.RowCount > 1)
                if (tb_detailsBill.RowCount > 1)
                    if (tb_bill.CurrentRow != null)
                    {
                        exportBill(this.idBill);
                        MessageBox.Show("Đã in hoá đơn, mã hoá đơn" + idBill, "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Không thể in", "Thông báo", MessageBoxButtons.OK);

        }


        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            string text = this.inp_search.Text;
            List<HoaDon> list = billManage.searchBill(text,listBill());
            setDataBill(list);
        }

        private void tb_bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (this.idBill != -1)
            {
                HoaDon b = bill(this.idBill);
                if (b.Status != "Đã thanh toán")
                {
                    this.fInfoPayment = new FormInfoPayment(this.idBill);

                    guna2Panel1.Controls.Clear();
                    fInfoPayment.TopLevel = false;
                    guna2Panel1.Controls.Add(fInfoPayment);
                    fInfoPayment.Dock = DockStyle.Fill;
                    fInfoPayment.Show();
                }
                else
                {
                    MessageBox.Show("Hoá đơn đã được thanh toán", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
