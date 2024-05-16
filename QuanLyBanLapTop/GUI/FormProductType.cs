using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.UtilsGUI;
using static BUS.TypeProductManage;
using static BUS.PurchaseProduct;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormProductType : Form
    {
        private TypeProductManage typeProductManage = new TypeProductManage();
        private ProductBrandManagement productBrandManagement = new ProductBrandManagement();
        public FormProductType()
        {
            InitializeComponent();
            initializationDataTypeProduct();
            initializationDataProduct();
        }
        public void initializationDataTypeProduct()
        {
            tb_typeProduct.ColumnCount = 2;
            tb_typeProduct.Columns[0].Name = "Mã loại";
            tb_typeProduct.Columns[1].Name = "Tên loại";

            autoSizetb(tb_typeProduct);
            setDataTypeProduct(listTypeProduct());

        }
        public void editError()
        {
            
        }
        public void setDataTypeProduct(List<DanhMucLapTopDTO> list)
        {
            tb_typeProduct.Rows.Clear();
            foreach(DanhMucLapTopDTO item in list)
            {
                string[] row = new string[] { item.IdTypeProduct.ToString(), item.NameTypeProduct
                   };
                tb_typeProduct.Rows.Add(row);
            }
        }
        public void setDataProduct(List<SanPham> listp)
        {

            this.tb_product.Rows.Clear();
            foreach (SanPham p in listp)
            {
                string nameManu = productBrandManagement.searchId(p.IDManuFacture.ToString());
                string[] row = new string[] { p.IdProduct, p.NameProduct,
                    p.UnitPrice.ToString("0.0"),p.QuantityProduct.ToString(),nameManu};
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
            tb_product.Columns[4].Name = "Hãng sản phẩm";
            autoSizetb(tb_product);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_titleProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            resetError();
            string result = inp_search.Text;
            List<DanhMucLapTopDTO> list = typeProductManage.searchType(result);
            setDataTypeProduct(list);
        }

        private void eventClickCell(object sender, DataGridViewCellEventArgs e)
        {
            resetText();
            if (tb_typeProduct.Rows.Count > 1)
            {
                int rowindex = tb_typeProduct.CurrentCell.RowIndex;
                if (tb_typeProduct.Rows.Count - 2 >= rowindex)
                {
                    string idType = tb_typeProduct.Rows[rowindex].Cells[0].Value.ToString();
                    string name = tb_typeProduct.Rows[rowindex].Cells[1].Value.ToString();
                    List<SanPham> listP = filterInType(idType);

                    setTextType(idType, name);
                    setDataProduct(listP);
                }
            }
        }
        public void setTextType(string id, string name)
        {
            inp_idType.ReadOnly = true;
            inp_idType.Text = id;
            inp_nameType.Text = name;
        }
        public void resetText()
        {
            
            inp_idType.ReadOnly = false;
            inp_idType.Text = "";
            inp_nameType.Text = "";
            success.Text = "";
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetText();
            resetError();
            tb_product.Rows.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string idType = inp_idType.Text;
            string name = inp_nameType.Text;
           string result = typeProductManage.addTypeProduct(idType, name);
            resultBtn(result, "add");
        }
        public void resultBtn(string result, string word)
        {
            Console.WriteLine(result);
            
            resetError();
            if (result.Contains("error_idNull"))
            {
                error_id.Text = "Mã không được rỗng";
            }
            if(result.Contains("error_idNumber"))
                error_id.Text = "Mã phải là số";
            if(result.Contains("error_duplicateId"))
                if(word == "add")
                    error_id.Text = "Mã trùng lặp";
                else 
                    error_id.Text = "Không tìm thấy loại";
                
            if (result == "success")
            {
                if (word == "add")
                    success.Text = "Đã thêm loại sản phẩm";
                else if(word == "edit")
                    success.Text = "Đã sửa loại sản phẩm";
                else
                    success.Text = "Đã xoá loại sản phẩm";
                setDataTypeProduct(listTypeProduct());
            }
        }
        public void resetError()
        {
            error_id.Text = "";
        }

        private void eventEditBtn(object sender, EventArgs e)
        {
            string idType = inp_idType.Text;
            string name = inp_nameType.Text;
            string result = typeProductManage.updateTypeProduct(idType, name);
            resultBtn(result, "edit");
        }

        private void eventDeleteBtn(object sender, EventArgs e)
        {
            string idType = inp_idType.Text;
            string result = typeProductManage.deleteTypeProduct(idType);
            resultBtn(result, "delete");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
