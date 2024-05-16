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
using static BUS.ProductBrandManagement;
using static BUS.PurchaseProduct;

namespace GUI
{
    public partial class FormProductManufacture : Form
    {
        private TypeProductManage typeProductManage = new TypeProductManage(); 
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        public FormProductManufacture()
        {
            InitializeComponent();
            initializationDataManuProduct();
            initializationDataProduct();
        }
        public void initializationDataManuProduct()
        {
            tb_manuProduct.ColumnCount = 2;
            tb_manuProduct.Columns[0].Name = "Mã hãng";
            tb_manuProduct.Columns[1].Name = "Tên hãng";

            autoSizetb(tb_manuProduct);
            setDataManuProduct(listBrand());

        }
        public void editError()
        {

        }
        public void setDataManuProduct(List<HangSanPhamDTO> list)
        {
            tb_manuProduct.Rows.Clear();
            foreach (HangSanPhamDTO item in list)
            {
                string[] row = new string[] { item.IdManufactutre.ToString(), item.NameManufacturer
                   };
                tb_manuProduct.Rows.Add(row);
            }
        }
        public void setDataProduct(List<SanPham> listp)
        {

            this.tb_product.Rows.Clear();
            foreach (SanPham p in listp)
            {
                string nameType = typeProductManage.nameType(p.IdTypeProduct);
                string[] row = new string[] { p.IdProduct, p.NameProduct,
                    p.UnitPrice.ToString("0.0"),p.QuantityProduct.ToString(),nameType};
                tb_product.Rows.Add(row);
            }
        }
        public void initializationDataProduct()
        {
            tb_product.ColumnCount = 5;
            tb_product.Columns[0].Name = "ID";
            tb_product.Columns[1].Name = "Tên sản phẩm";
            tb_product.Columns[2].Name = "Đơn giá";
            tb_product.Columns[3].Name = "Số lượng";
            tb_product.Columns[4].Name = "Loại sản phẩm";
            autoSizetb(tb_product);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_titleProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string idType = inp_id.Text;
            string name = inp_name.Text;
            string result = productBrandManagement.updateBrandProduct(idType, name);
            resultBtn(result, "edit");
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            resetError();
            string result = inp_search.Text;
            List<HangSanPhamDTO> list = productBrandManagement.searchBrand(result);
                setDataManuProduct(list);
        }
        public void resetText()
        {
            inp_id.ReadOnly = true;
            inp_id.Text = "";
            inp_name.Text = "";
            
            
        }

        private void eventClickCell(object sender, DataGridViewCellEventArgs e)
        {
            inp_id.ReadOnly = false;
            resetText();
            if (tb_manuProduct.Rows.Count > 1)
            {
                int rowindex = tb_manuProduct.CurrentCell.RowIndex;
                if (tb_manuProduct.Rows.Count - 2 >= rowindex)
                {
                    string idManu = tb_manuProduct.Rows[rowindex].Cells[0].Value.ToString();
                    string name = tb_manuProduct.Rows[rowindex].Cells[1].Value.ToString();
                    List<SanPham> listP = filterInManuToId(idManu);
                    Console.WriteLine(listP.Count);
                    setTextManu(idManu, name);
                    setDataProduct(listP);
                }
            }
        }
        public void setTextManu(string idManu, string name)
        {
            inp_id.Text = idManu;
            inp_name.Text = name;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string idType = inp_id.Text;
            string name = inp_name.Text;
            string result = productBrandManagement.addBrandProduct(idType, name);
            resultBtn(result, "add");
        }
        public void resultBtn(string result, string word)
        {
            

            resetError();
            if (result.Contains("error_idNull"))
            {
                error_id.Text = "Mã không được rỗng";
            }
            if (result.Contains("error_idNumber"))
                error_id.Text = "Mã phải là số";
            if (result.Contains("error_duplicateId"))
                if (word == "add")
                    error_id.Text = "Mã trùng lặp";
                else
                    error_id.Text = "Không tìm thấy hãng";

            if (result == "success")
            {
                if (word == "add")
                    text_success.Text = "Đã thêm hãng sản phẩm";
                else if (word == "edit")
                    text_success.Text = "Đã sửa hãng sản phẩm";
                else
                    text_success.Text = "Đã xoá hãng sản phẩm";
                setDataManuProduct(listBrand());
            }
        }
        public void resetError()
        {
            error_id.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetText();
            resetError();
            tb_product.Rows.Clear();
        }
    }
}
