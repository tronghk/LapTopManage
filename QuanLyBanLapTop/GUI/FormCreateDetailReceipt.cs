using BUS;
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
using static BUS.ProductManage;
using DTO;
using System.Security.AccessControl;
using System.IO;
using static GUI.FormMainMenu;
using static BUS.SupplierManager;

namespace GUI
{
    public partial class FormCreateDetailReceipt : Form
    {
        private ImportProduct importProduct = new ImportProduct();
        private ProductManage productManage = new ProductManage();
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        private TypeProductManage typeProductManage = new TypeProductManage();
        private PurchaseProduct purchaseProduct = new PurchaseProduct();
        FormWareHouse fWarehouse;
        public FormCreateDetailReceipt()
        {
            InitializeComponent();
            importProduct.addCoupon();
            initializationDataProduct();
            initializationDataDt();
            initializationDataSupplier();

        }
        public void initializationDataProduct()
        {
            
            tb_product.ColumnCount = 5;
            tb_product.Columns[0].Name = "ID";
            tb_product.Columns[1].Name = "Tên sản phẩm";
            tb_product.Columns[2].Name = "Đơn giá";
            tb_product.Columns[3].Name = "Loại sản phẩm";
            tb_product.Columns[4].Name = "Hãng sản phẩm";

            autoSizetb(tb_product);
            setDataProduct(listProduct());
        }
        public void initializationDataSupplier()
        {
            List<NhaCungCapDTO> list = listSupplier();
            int index = 0;

            foreach (NhaCungCapDTO p in list)
            {
                this.cbb_supplier.Items.Insert(index++, p.NameSupplier);
            }
            cbb_supplier.SelectedIndex = 0;
        }
        public void initializationDataDt()
        {
            
            tb_details.ColumnCount = 5;
            tb_details.Columns[0].Name = "Mã sản phẩm";
            tb_details.Columns[1].Name = "Tên sản phẩm";
            tb_details.Columns[2].Name = "Số lượng nhập";
            tb_details.Columns[3].Name = "Đơn giá";
            tb_details.Columns[4].Name = "Tổng tiền";

            autoSizetb(tb_details);
        }
        public void setDataDetails(List<ChiTietPhieuYeuCauNhapHangDTO> list)
        {
            tb_details.Rows.Clear();
            foreach (ChiTietPhieuYeuCauNhapHangDTO value in list)
            {
                SanPham p = productManage.searchId(value.IdProduct);
                string[] row = new string[] { p.IdProduct, p.NameProduct,
                    value.QuantityImport.ToString(),p.UnitPrice.ToString("0.0"),value.IntoMoney.ToString("0.0")};
                tb_details.Rows.Add(row);
            }
        }

        public void setDataProduct(List<SanPham> listp)
        {

            this.tb_product.Rows.Clear();
            foreach (SanPham p in listp)
            {
                string nameManu = productBrandManagement.searchId(p.IDManuFacture.ToString());
                string nameType = typeProductManage.nameType(p.IdTypeProduct);
                string[] row = new string[] { p.IdProduct, p.NameProduct,
                    p.UnitPrice.ToString("0.0"),nameType,nameManu};
                tb_product.Rows.Add(row);
            }
        }

        private void eventClickCell(object sender, DataGridViewCellEventArgs e)
        {
            resetText();
            if (tb_product.SelectedCells.Count > 0)
            {
                int rowindex = tb_product.CurrentCell.RowIndex;
                if (rowindex <= tb_product.Rows.Count - 2)
                {
                    string idProduct = tb_product.Rows[rowindex].Cells[0].Value.ToString();
                    SanPham p = productManage.searchId(idProduct);
                    displayInfoProduct(p);
                }


            }
        }
        public void resetText()
        {
            inp_idProduct.Text = "";
            inp_nameProduct.Text = "";
            inp_quantity.Text = "";
            inp_quantitya.Text = "";
            inp_summoney.Text = "";
            inp_unitprice.Text = "";

        }
        public void displayInfoProduct(SanPham p)
        {
            inp_idProduct.Text = p.IdProduct;
            inp_nameProduct.Text = p.NameProduct;
            inp_quantitya.Text = p.QuantityProduct.ToString();
            string sumMoney = purchaseProduct.intoMoney(p.UnitPrice, inp_quantity.Text).ToString("0.0");
            if (sumMoney.Contains("-1"))
                inp_summoney.Text = sumMoney;
            else inp_summoney.Text = "";
            inp_unitprice.Text = p.UnitPrice.ToString("0.0");
            if (p.Image != "")
            {
                img_product.Load(path + p.Image);
            }
            else
            {
                img_product.Image = null;
            }

        }

        private void inp_searchProduct_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_searchProduct.Text;
            List<SanPham> listP = searchProduct(search, listProduct());
            setDataProduct(listP);
        }

        private void btn_addDetails_Click(object sender, EventArgs e)
        {
            string idProduct = inp_idProduct.Text;
            string quantity = inp_quantity.Text;
            string unitPrice = inp_unitprice.Text;
            string intoMoney = inp_summoney.Text;
            string result = importProduct.addDetailsCoupon(idProduct,quantity,unitPrice,intoMoney);
            eventResultBtn(result, "add");
           
        }
        public void eventResultBtn(string result, string word)
        {
            if (result.Contains("error_idNull"))
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (result.Contains("error_quantity"))
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (result.Contains("error_duplicateId"))
            {
                if (word == "add")
                    MessageBox.Show("Sản phẩm đã có trong danh sách", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Sản phẩm chưa có trong danh sách", "Thông báo", MessageBoxButtons.OK);

            }

            else
            {
                if (word == "add")
                    MessageBox.Show("Đã thêm chi tiết", "Thông báo", MessageBoxButtons.OK);
                else if (word == "edit")
                    MessageBox.Show("Đã sửa chi tiết", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Đã xoá chi tiết", "Thông báo", MessageBoxButtons.OK);
                setDataDetails(importProduct.listDt);
            }
        }

        private void btn_editDetails_Click(object sender, EventArgs e)
        {
            string idProduct = inp_idProduct.Text;
            string quantity = inp_quantity.Text;
            string unitPrice = inp_unitprice.Text;
            string intoMoney = inp_summoney.Text;
            string result = importProduct.updateDetailsCoupon(idProduct, quantity, unitPrice, intoMoney);
            eventResultBtn(result, "edit");
        }

        private void btn_deleteDetails_Click(object sender, EventArgs e)
        {
            string idProduct = inp_idProduct.Text;
            string quantity = inp_quantity.Text;
            string unitPrice = inp_unitprice.Text;
            string intoMoney = inp_summoney.Text;
            string result = importProduct.deleteDetailsCoupon(idProduct);
            eventResultBtn(result, "delete");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetText();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            fWarehouse = new FormWareHouse();
            guna2Panel1.Controls.Clear();
            fWarehouse.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(fWarehouse);
            fWarehouse.Dock = DockStyle.Fill;
            fWarehouse.Show();
        }

        private void btn_savePromotion_Click(object sender, EventArgs e)
        {
            importProduct.saveCoupon(idSupplier(cbb_supplier.SelectedIndex));
            fWarehouse = new FormWareHouse();
            guna2Panel1.Controls.Clear();
            fWarehouse.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(fWarehouse);
            fWarehouse.Dock = DockStyle.Fill;
            fWarehouse.Show();
        }
        public string idSupplier(int index)
        {
            string idSupplier = null;
            int i = 0;
            foreach(NhaCungCapDTO value in listSupplier())
            {
                if (i == index)
                    idSupplier = value.IdSupplier;
            }
            return idSupplier;
        }

        private void inp_quantity_TextChanged(object sender, EventArgs e)
        {
            string idProduct = inp_idProduct.Text;
            if(idProduct != "")
            {
                string quantity = inp_quantity.Text;
                float unitPrice = float.Parse(inp_unitprice.Text);
                float intoMoney = purchaseProduct.intoMoney(unitPrice, quantity);
                if(intoMoney > 0)
                {
                    inp_summoney.Text = intoMoney.ToString("0.0");
                }
                else
                {
                    inp_summoney.Text = "";
                }

            }
            
        }
    }
}
