using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BUS.ProductManage;
using static BUS.PurchaseProduct;
using static BUS.ProductBrandManagement;
using System.Xml.Linq;
using Guna.UI2.AnimatorNS;
using System.Collections;
using System.IO;
using static GUI.FormMainMenu;

namespace GUI
{
    
    public partial class FormSell : Form
    {
        private string idProduct = null;
        private ProductManage productManage = new ProductManage();
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        public PurchaseProduct purchaseProduct = new PurchaseProduct();
        private TypeProductManage typeProductManage = new TypeProductManage();
        private FormInfoPayment fInfoPayment;

        public FormSell()
        {
            InitializeComponent();
            initializationDataProduct();
            initializationDataCt();
            
        }

        public void initializationDataProduct()
        {
            tb_product.ColumnCount = 6;
            tb_product.Columns[0].Name = "ID";
            tb_product.Columns[1].Name = "Tên sản phẩm";
            tb_product.Columns[2].Name = "Đơn giá";
            tb_product.Columns[3].Name = "Số lượng tồn";
            tb_product.Columns[4].Name = "Loại sản phẩm";
            tb_product.Columns[5].Name = "Hãng sản phẩm";
            autoSizetb(tb_product);
            setDataProduct(filterProductOtherZero());
            setDataFacturer();
        }
        public static void autoSizetb(DataGridView tb)
        {
            tb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        public void initializationDataCt()
        {
            tb_order.ColumnCount = 7;
            tb_order.Columns[0].Name = "ID";
            tb_order.Columns[1].Name = "Tên sản phẩm";
            tb_order.Columns[2].Name = "Đơn giá";
            tb_order.Columns[3].Name = "Số lượng mua";
            tb_order.Columns[4].Name = "Tổng tiền";
            tb_order.Columns[5].Name = "Tiền giảm";
            tb_order.Columns[6].Name = "Thành tiền";
            autoSizetb(tb_order);
        }
        public void setDataDetailsProduct()
        {
            this.tb_order.Rows.Clear();
            List<ChiTietHoaDonDTO> list = purchaseProduct.listDetails();
            foreach (ChiTietHoaDonDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] {p.IdProduct, p.NameProduct, p.UnitPrice.ToString("0.0"),
                    item.QuantityProduct.ToString(), (item.MoneyDown+item.IntoMoney).ToString("0.0"),
                    item.MoneyDown.ToString("0.0"),item.IntoMoney.ToString("0.0") };
                tb_order.Rows.Add(row);
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
                    p.UnitPrice.ToString("0.0"),p.QuantityProduct.ToString(),nameType,nameManu};
                tb_product.Rows.Add(row);
            }
        }
        public void setDataFacturer()
        {
            List<HangSanPhamDTO> list = listBrand();
            this.cbb_manufacturer.Items.Insert(0, "Tất cả");
            
            int index = 1;

            foreach(HangSanPhamDTO p in list)
            {
                this.cbb_manufacturer.Items.Insert(index++, p.NameManufacturer);
            }
        }

        private void gvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tb_product_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            resetText();
            if (tb_product.SelectedCells.Count > 0)
            {
              int rowindex = tb_product.CurrentCell.RowIndex;
                if (rowindex <= tb_product.RowCount - 2)
                {
                    this.idProduct = tb_product.Rows[rowindex].Cells[0].Value.ToString();
                    SanPham p = productManage.searchId(this.idProduct);
                    displayInfoProduct(p, null,0);
                    changeValueCombobox(p.IDManuFacture.ToString());
                }

            }
           
        }
        public void displayInfoProduct(SanPham p,string work,int quantity)
        {
            
            this.id_product.Text = p.IdProduct;
            this.inp_nameProduct.Text = p.NameProduct;
            this.inp_unitPrice.Text = p.UnitPrice.ToString("0.0");
            string discount = purchaseProduct.downProduct(p.IdProduct);
            if(discount != null)
                this.inp_sales.Text = discount+"%";
            else
                this.inp_sales.Text = "";
            float sumMoney = purchaseProduct.sumMoney(p.IdProduct, this.inp_quantity.Text, p.UnitPrice);
            this.inp_total.Text = sumMoney.ToString("0.0");
            if(work == "edit")
            {
                this.inp_quantity.Text = quantity.ToString();
            }
            else{
                this.inp_quantity.Text = "";
            }
            if (p.Image != "")
            {
                img_avatarProduct.Load(path + p.Image);
            }
            else
            {
                img_avatarProduct.Image = null;
            }

        }
        public void changeValueCombobox(string idFacturer)
        {
            List<HangSanPhamDTO> list = listBrand();
            int index = 1;
            string name = productBrandManagement.searchId(idFacturer);
            foreach (HangSanPhamDTO item in list)
            {
                if(item.NameManufacturer == name)
                {
                    cbb_manufacturer.SelectedIndex = index;
                    break;
                }
                index++;
            }

        }

        private void inp_quantity_TextChanged(object sender, EventArgs e)
        {
            SanPham p = productManage.searchId(this.idProduct);
            float sumMoney = purchaseProduct.sumMoney(p.IdProduct, this.inp_quantity.Text, p.UnitPrice);
            this.inp_total.Text = sumMoney.ToString("0.0");
        }

       
        
        public void resetText()
        {
            id_product.Text = "";
            inp_nameProduct.Text = "";
            inp_quantity.Text = "";
            inp_sales.Text = "";
            inp_search.Text = "";
            inp_total.Text = "";
            inp_unitPrice.Text = "";
            error_sell.Text = "";
            success.Text = "";
        }

        private void tb_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventDropClosed(object sender, EventArgs e)
        {
            
            resetText();
            if (cbb_manufacturer.Text == "Tất cả")
            {
               
                setDataProduct(filterProductOtherZero());
            }
            else
            {
                
                List<SanPham> listp = purchaseProduct.filterInManu(cbb_manufacturer.Text);
                setDataProduct(listp);
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {

            string quantity = this.inp_quantity.Text;
                string result = purchaseProduct.addDetailsProduct
                    (quantity,idProduct);
            eventBtnDetails(result,"add");
        }
        public void clearInfo()
        {
            error_sell.Text = "";
            success.Text = "";
        }
        public void eventBtnDetails(string result, string action)
        {
            clearInfo();
            
            if(result.Contains("error_idNull"))
                error_sell.Text = "Chưa chọn sản phẩm";

            else if (result.Contains("error_quantity"))
                error_sell.Text = "Số lượng không hợp lệ";

            else if(result.Contains("error_duplicate"))
                if (action.Contains("add"))
                    error_sell.Text = "Sản phẩm đã có trong hoá đơn";
                else
                    error_sell.Text = "Sản phẩm chưa có trong hoá đơn";

            else
            {
                if (action.Contains("add"))
                    success.Text = " Thêm chi tiết thành công";
                else if(action.Contains("update"))
                    success.Text = " Sửa chi tiết thành công";
                else
                    success.Text = " Xoá chi tiết thành công";

                setDataDetailsProduct();
            }
            

        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            
            string quantity = this.inp_quantity.Text;
            string result = purchaseProduct.updateDetailsProduct
                (quantity, idProduct);
            
            eventBtnDetails(result,"update");
        }

        private void tb_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetText();
            if (tb_order.RowCount > 1)
                if (tb_order.CurrentRow != null)
            {
                int rowindex = tb_order.CurrentCell.RowIndex;
                    if(tb_order.Rows.Count-2 >= rowindex)
                this.idProduct = tb_order.Rows[rowindex].Cells[0].Value.ToString();
                    string quantity =  tb_order.Rows[rowindex].Cells[3].Value.ToString();
                    SanPham p = productManage.searchId(this.idProduct);
                displayInfoProduct(p,"edit",int.Parse(quantity));
                changeValueCombobox(p.IDManuFacture.ToString());

            }
                
        }

        private void tb_order_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            string result = "";
            if (tb_order.CurrentRow != null)
            {
                
                int rowindex = tb_order.CurrentCell.RowIndex;
                
                string idP = tb_order.Rows[rowindex].Cells[0].Value.ToString();
                Console.WriteLine(idP);
                result = purchaseProduct.deleteDetailsProduct(idP);
                
            }
            else
                result = "error_idNull";
            
            eventBtnDetails(result, "delete");
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            
            if (search != null)
            {
                List<SanPham> listP = purchaseProduct.searchP(search);
                
                setDataProduct(listP);
            }
            else
            {
                setDataProduct(filterProductOtherZero());
            }
        }

        private void cbb_manufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            int idBill = purchaseProduct.idBill;
            if (idBill != -1)
            {
                this.purchaseProduct.saveOrder();
                this.fInfoPayment = new FormInfoPayment(idBill);
                guna2Panel1.Controls.Clear();
                fInfoPayment.TopLevel = false;
                guna2Panel1.Controls.Add(fInfoPayment);
                fInfoPayment.Dock = DockStyle.Fill;
                fInfoPayment.Show();
            }
        }

        private void img_avatarProduct_Click(object sender, EventArgs e)
        {

        }

        private void eventKeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up || e.KeyCode ==  Keys.Down)
            {
                resetText();
                if (tb_product.SelectedCells.Count > 0)
                {
                    int rowindex = tb_product.CurrentCell.RowIndex;
                    if (rowindex <= tb_product.RowCount - 2)
                    {
                        this.idProduct = tb_product.Rows[rowindex].Cells[0].Value.ToString();
                        SanPham p = productManage.searchId(this.idProduct);
                        displayInfoProduct(p, null, 0);
                        changeValueCombobox(p.IDManuFacture.ToString());
                    }

                }
            }
        }
    }
}
