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
using static BUS.ProductManage;
using static BUS.ProductBrandManagement;
using static BUS.TypeProductManage;
using System.IO;
using static GUI.FormMainMenu;

namespace GUI
{
    public partial class FormProduct : Form
    {
        private ProductManage productManage = new ProductManage();
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        public PurchaseProduct purchaseProduct = new PurchaseProduct();
        private TypeProductManage typeProductManage = new TypeProductManage();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        
        public FormProduct()
        {
            InitializeComponent();
            initializationDataProduct();
            setDataFacturer();
            setDataTypeProduct();
        }
        public void initializationDataProduct()
        {
            tb_product.ColumnCount = 6;
            tb_product.Columns[0].Name = "ID";
            tb_product.Columns[1].Name = "Tên sản phẩm";
            tb_product.Columns[2].Name = "Đơn giá";
            tb_product.Columns[3].Name = "Số lượng";
            tb_product.Columns[4].Name = "Loại sản phẩm";
            tb_product.Columns[5].Name = "Hãng sản phẩm";

            autoSizetb(tb_product);
            setDataProduct(listProduct());
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
        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            resetError();
            string idProduct = inp_idProduct.Text;
            string nameProduct = inp_nameProduct.Text;
            string type = cbb_type.SelectedIndex + "";
            string manu = cbb_manu.SelectedIndex + "";
            string unitPrice = inp_priceProduct.Text;
            string quantity = inp_quantityProduct.Text;
            string image = openFileDialog.FileName.ToString();
            image = Path.GetFileName(image);
            string result = productManage.updateProduct(idProduct, nameProduct
                , unitPrice, quantity, "", type, manu, image);
            addProduct(result,"edit");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void resetText()
        {
            inp_idProduct.Text = "";
            inp_nameProduct.Text = "";
            inp_priceProduct.Text = "";
            inp_quantityProduct.Text = "";
            cbb_type.SelectedIndex = 0;
            cbb_manu.SelectedIndex = 0;
            img_product.Image = null;
            openFileDialog.FileName = "";
            
        }

        private void eventClickCell(object sender, DataGridViewCellEventArgs e)
        {
            inp_idProduct.ReadOnly = true;
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
                    changeValueComboboxManu(p.IDManuFacture.ToString());
                    changeValueCbbType(p.IdTypeProduct);
                }

            }
        }
        public void displayInfoProduct(SanPham p)
        {
           
            this.inp_idProduct.Text = p.IdProduct;
            this.inp_nameProduct.Text = p.NameProduct;
            this.inp_priceProduct.Text = p.UnitPrice.ToString("0.0");
            this.inp_quantityProduct.Text = p.QuantityProduct.ToString();
            if (p.Image != "")
            {
                img_product.Load(path+p.Image);
            }
            else
            {
                img_product.Image = null;
            }


        }
        public void changeValueComboboxManu(string idFacturer)
        {
            List<HangSanPhamDTO> list = listBrand();
            int index = 0;
            string name = productBrandManagement.searchId(idFacturer);
            foreach (HangSanPhamDTO item in list)
            {
                if (item.NameManufacturer == name)
                {
                    this.cbb_manu.SelectedIndex = index;
                    break;
                }
                index++;
            }
            

        }
        public void changeValueCbbType(int idType)
        {
            List<DanhMucLapTopDTO> list = listTypeProduct();
            int index = 0;
            string name = typeProductManage.nameType(idType);
            foreach (DanhMucLapTopDTO item in list)
            {
                if (item.NameTypeProduct == name)
                {
                    this.cbb_type.SelectedIndex = index;
                    break;
                }
                index++;
            }
           
        }
        public void setDataFacturer()
        {
            List<HangSanPhamDTO> list = listBrand();

            int index = 0;

            foreach (HangSanPhamDTO p in list)
            {
                this.cbb_manu.Items.Insert(index++, p.NameManufacturer);
            }
            if (list.Count > 0)
                cbb_manu.SelectedIndex = 0;
        }
        public void setDataTypeProduct()
        {
            List<DanhMucLapTopDTO> list = listTypeProduct();
            int index = 0;
            foreach(DanhMucLapTopDTO item in list)
            {
                this.cbb_type.Items.Insert(index++, item.NameTypeProduct);
            }
            if (list.Count > 0)
                cbb_type.SelectedIndex = 0;

        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            string search = this.inp_search.Text;
            List<SanPham> listP = purchaseProduct.searchP(search);
            setDataProduct(listP);
        }

        private void btn_restartProduct_Click(object sender, EventArgs e)
        {
            resetError();
            resetText();
            inp_idProduct.ReadOnly = false;
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            resetError();
            string idProduct = inp_idProduct.Text;
            string nameProduct = inp_nameProduct.Text;
            string type = cbb_type.SelectedIndex+"";
            string manu = cbb_manu.SelectedIndex+"";
            string unitPrice = inp_priceProduct.Text;
            string quantity = inp_quantityProduct.Text;
            string image = openFileDialog.FileName.ToString();
            image = Path.GetFileName(image);
            string result = productManage.addProduct(idProduct, nameProduct
                , unitPrice, quantity, "", type, manu,image);
            addProduct(result,"add");
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                this.img_product.Load(filePath);
                
            }
        }
        public void addProduct(string result, string word)
        {
            
            if(result.Contains("error_idNull"))
            {
                error_id.Text = "!Mã rỗng";
            }
            if(result.Contains("error_nameNull"))
            {
                error_name.Text = "!Tên rỗng";
            }
            if (result.Contains("error_duplicateId"))
            {
                if(word == "add")
                error_id.Text = "!Mã trùng lặp";
                else
                    error_id.Text = "Không tìm thấy sản phẩm";
            }
            if(result.Contains("error_quantity"))
            {
                error_quantity.Text = "Số lượng sai";
            }
            if(result.Contains("error_unitPrice"))
            {
                error_unitPrice.Text = "Đơn giá không hợp lệ";
            }
            if (result == "success")
            {
                string text = "";
                PictureBox pictureBox = new PictureBox();
                if(openFileDialog.FileName.ToString() != "")
                {
                    
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    saveFileDialog.FileName = path +
                        Path.GetFileName(openFileDialog.FileName);
                    
                    pictureBox.Image.Save(saveFileDialog.FileName);
                   
                    if (word == "add")
                        text = "Đã thêm sản phẩm";
                    else
                        text = "Đã sửa sản phẩm";
                   
                }
                 MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setDataProduct(listProduct());
            }

        }
        public void resetError()
        {
            error_id.Text = "";
            error_name.Text = "";
            error_quantity.Text = "";
            error_unitPrice.Text = "";
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            
            string idProduct = inp_idProduct.Text;
           string result = productManage.deleteProduct(idProduct);
            resultEventDelete(result);
            
        }
        public void resultEventDelete(string result)
        {
            resetError();
            if (result.Contains("error_idNull"))
                error_id.Text = "!Mã rỗng";
            if (result.Contains("error_notFoundID"))
                error_id.Text = "Không tìm thấy sản phẩm";
            if (result == "success")
            {
                MessageBox.Show("Đã xoá sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                setDataProduct(listProduct());
            }
        }

        private void tb_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
