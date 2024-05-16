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
using static BUS.ProductManage;

namespace GUI
{
    public partial class FormCreateDetailPromotion : Form
    {
        private FormPromotion fPromotion;
        private PromotionManage promotionManage = new PromotionManage();
        private ProductManage productManage = new ProductManage();
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        private TypeProductManage typeProductManage = new TypeProductManage();
        
        public FormCreateDetailPromotion()
        {
            InitializeComponent();
            promotionManage.addPromotion();
            initializationDataProduct();
            initializationDataDetailsPromotion();
            
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
        public void initializationDataDetailsPromotion()
        {
            tb_detailsPromotion.ColumnCount = 3;
            tb_detailsPromotion.Columns[0].Name = "Mã sản phẩm";
            tb_detailsPromotion.Columns[1].Name = "Tên sản phẩm";
            tb_detailsPromotion.Columns[2].Name = "%Giảm";

            autoSizetb(tb_detailsPromotion);
        }
        public void setDataDetailsPromotion()
        {

            this.tb_detailsPromotion.Rows.Clear();
            List<ChiTietKhuyenMaiDTO> list = promotionManage.listDt;
            foreach (ChiTietKhuyenMaiDTO item in list)
            {
                SanPham product = productManage.searchId(item.IdProduct);
                string[] row = new string[] {product.IdProduct,product.NameProduct,item.Discount.ToString("0.0")};
                tb_detailsPromotion.Rows.Add(row);
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


        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {       
            fPromotion = new FormPromotion();
            guna2Panel1.Controls.Clear();
            fPromotion.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(fPromotion);
            fPromotion.Dock = DockStyle.Fill;
            fPromotion.Show();
        }

        private void inp_searchProduct_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_searchProduct.Text;
            List<SanPham> listP = searchProduct(search,listProduct());
            setDataProduct(listP);
        }

        private void inp_namePromotion_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventClickCellProduct(object sender, DataGridViewCellEventArgs e)
        {
            
            resetError();
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
            inp_sales.Text = "";
        }
        public void resetError()
        {
            text_error.Text = "";
            txt_success.Text = "";
            error_name.Text = "";
        }
        public void displayInfoProduct(SanPham p)
        {
            inp_idProduct.Text = p.IdProduct;
            inp_nameProduct.Text = p.NameProduct;
            

        }

        private void btn_addDetailsPromotion_Click(object sender, EventArgs e)
        {
            resetError();
            string idProduct = inp_idProduct.Text;
            string discount = inp_sales.Text;
            string result = promotionManage.addDetailsPromotion(idProduct, discount);
            eventResultBtn(result, "add");
        }
        public void eventResultBtn(string result, string word)
        {
            if (result.Contains("error_idNull"))
            {
                text_error.Text = "!Mã rỗng";
            }
            if (result.Contains("error_discountNull"))
            {
                text_error.Text = "Chưa đặt giảm giá";
            }
            if (result.Contains("error_discount"))
            {
                text_error.Text = "Giảm giá phải là số";
            }
            if (result.Contains("error_duplicate"))
            {
                if(word == "add")
                    text_error.Text = "Chi tiết đã có trong danh sách";
                else
                    text_error.Text = "Chi tiết chưa có trong danh sách";

            }
           
            if (result == "success")
            {
                if(word == "add")
                    txt_success.Text = "Đã thêm chi tiết";
                else if(word == "edit")
                    txt_success.Text = "Đã sửa chi tiết";
                else
                    txt_success.Text = "Đã xoá chi tiết";
                setDataDetailsPromotion();
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            resetError();
            resetText();
            inp_searchProduct.Text = "";
        }

        private void btn_editDetailsPromotion_Click(object sender, EventArgs e)
        {
            resetError();
            string idProduct = inp_idProduct.Text;
            string discount = inp_sales.Text;
            
            string result = promotionManage.updateDetailsPromotion(idProduct, discount);
            eventResultBtn(result, "edit");
        }

        private void btn_deleteDetailsPromotion_Click(object sender, EventArgs e)
        {
            resetError();
            string idProduct = inp_idProduct.Text;
            string discount = inp_sales.Text;
            string result = promotionManage.deleteDetailsPromotion(idProduct);
            eventResultBtn(result, "delete");
        }

        private void eventClickCellDetails(object sender, DataGridViewCellEventArgs e)
        {
            
            resetError();
            resetText();
            if (tb_detailsPromotion.Rows.Count >1)
            {
                int rowindex = tb_detailsPromotion.CurrentCell.RowIndex;
                if (rowindex <= tb_detailsPromotion.Rows.Count - 2)
                {
                    string idProduct = tb_detailsPromotion.Rows[rowindex].Cells[0].Value.ToString();
                    string discout = tb_detailsPromotion.Rows[rowindex].Cells[2].Value.ToString();
                    SanPham p = productManage.searchId(idProduct);
                    displayInfoProduct(p);
                    inp_sales.Text = discout;
                }
            }
        }

        private void btn_savePromotion_Click(object sender, EventArgs e)
        {
            string namePromotion = inp_namePromotion.Text;
            DateTime dateStart = date_dateStart.Value;
            DateTime dateEnd = date_dateEnd.Value;
            string result = promotionManage.savePromotion(namePromotion, "", dateStart, dateEnd);
            resultSavePromotion(result, this.promotionManage.idPromotion);
        }
        public void resultSavePromotion(string result, int idPromotion)
        {
            resetError();
            if (result.Contains("error_name"))
                error_name.Text = "Tên chương trình không được rỗng";
            else
            {
                MessageBox.Show("Đã lưu khuyến mãi, mã khuyến mãi là: " + idPromotion, "Thông báo", MessageBoxButtons.OK);
                fPromotion = new FormPromotion();
                guna2Panel1.Controls.Clear();
                fPromotion.TopLevel = false;
                //pnlBody.Controls.Add(guna2Panel2);
                guna2Panel1.Controls.Add(fPromotion);
                fPromotion.Dock = DockStyle.Fill;
                fPromotion.Show();
            }

        }
    }
}
