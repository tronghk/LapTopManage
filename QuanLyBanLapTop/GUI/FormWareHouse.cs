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
using static BUS.ImportProduct;

namespace GUI
{
    public partial class FormWareHouse : Form
    {
        private SupplierManager supplierManager = new SupplierManager();
        private ImportProduct importProduct = new ImportProduct();
        private ProductManage productManage = new ProductManage();
        FormCreateDetailReceipt formCreateDetailReceipt;
        public FormWareHouse()
        {
            InitializeComponent();
            initializationDataReceipt();
            initializationDataDetailsReceipt();
        }
        public void initializationDataReceipt()
        {
            tb_receipt.ColumnCount = 4;
            tb_receipt.Columns[0].Name = "Mã nhập kho";
            tb_receipt.Columns[1].Name = "Thời gian nhập";
            tb_receipt.Columns[2].Name = "Tổng tiền";
            tb_receipt.Columns[3].Name = "Nhà cung cấp";

            autoSizetb(tb_receipt);
            setDataReceipt(listCoupon());

        }
        public void initializationDataDetailsReceipt()
        {
            tb_detailsP.ColumnCount = 4;
            tb_detailsP.Columns[0].Name = "Tên sản phẩm";
            tb_detailsP.Columns[1].Name = "Số lượng nhập";
            tb_detailsP.Columns[2].Name = "Đơn giá";
            tb_detailsP.Columns[3].Name = "Tổng tiền";
            autoSizetb(tb_detailsP);
        }
        public void setDataReceipt(List<PhieuYeuCauNhapHang> list)
        {
           
            tb_receipt.Rows.Clear();
            foreach (PhieuYeuCauNhapHang item in list)
            {
                NhaCungCapDTO supplier = supplierManager.searchIdSupplier(item.IdSupplier);
                string[] row = new string[] { item.IdCoupon.ToString(),item.DateAdded.ToString(),item.IntoMoney.ToString("0.0"),
                    supplier.NameSupplier
                   };
                tb_receipt.Rows.Add(row);
            }
        }
        public void setDataDetailsReceipt(int idReceipt)
        {
            this.tb_detailsP.Rows.Clear();
            List<ChiTietPhieuYeuCauNhapHangDTO> list = listDtCoupon(idReceipt.ToString());
            foreach (ChiTietPhieuYeuCauNhapHangDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] { p.NameProduct, item.QuantityImport.ToString(), item.UnitPrice.ToString("0.0")
                ,item.IntoMoney.ToString("0.0")};
                tb_detailsP.Rows.Add(row);
            }

        }

        private void btn_addCoupon_Click(object sender, EventArgs e)
        {
            FormCreateDetailReceipt formCreateDetailCoupon = new FormCreateDetailReceipt();
            guna2Panel1.Controls.Clear();
            formCreateDetailCoupon.TopLevel = false;
            guna2Panel1.Controls.Add(formCreateDetailCoupon);
            formCreateDetailCoupon.Dock = DockStyle.Fill;
            formCreateDetailCoupon.Show();
        }

        private void eventClickCell(object sender, DataGridViewCellEventArgs e)
        {
            tb_detailsP.Rows.Clear();
            if (tb_receipt.RowCount > 1)
                if (tb_receipt.CurrentRow != null)
                {
                    int rowindex = tb_receipt.CurrentCell.RowIndex;
                    if (tb_receipt.Rows.Count - 2 >= rowindex)
                    {
                        int idRecepit = int.Parse(tb_receipt.Rows[rowindex].Cells[0].Value.ToString());

                        setDataDetailsReceipt(idRecepit);
                    }

                }
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string text = this.inp_search.Text;
            List<PhieuYeuCauNhapHang> list = importProduct.searchId(text);
            setDataReceipt(list);
        }

        private void btn_addCoupon_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //formCreateDetailPromotion.ShowDialog();
            //this.Show();
            this.formCreateDetailReceipt = new FormCreateDetailReceipt();
            guna2Panel1.Controls.Clear();
            formCreateDetailReceipt.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(formCreateDetailReceipt);
            formCreateDetailReceipt.Dock = DockStyle.Fill;
            formCreateDetailReceipt.Show();
        }
    }
}
