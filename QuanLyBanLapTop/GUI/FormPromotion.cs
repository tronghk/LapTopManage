using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.UtilsGUI;
using static BUS.PromotionManage;
using BUS;

namespace GUI
{
    public partial class FormPromotion : Form
    {
        private ProductManage productManage = new ProductManage();
        private PromotionManage promotionManage = new PromotionManage();
        FormCreateDetailPromotion fCreateDetailPromotion;
        public FormPromotion()
        {
            InitializeComponent();
            initializationDataPromotion();
            initializationDataDetailsPromotion();
        }
        public void initializationDataPromotion()
        {
            tb_promotion.ColumnCount = 2;
            tb_promotion.Columns[0].Name = "Mã khuyến mãi";
            tb_promotion.Columns[1].Name = "Tên khuyến mãi";

            autoSizetb(tb_promotion);
            setDataPromotion(listPromotion());

        }
        public void initializationDataDetailsPromotion()
        {
            tb_detailsP.ColumnCount = 3;
            tb_detailsP.Columns[0].Name = "Tên sản phẩm";
            tb_detailsP.Columns[1].Name = "%Giảm giá";
            tb_detailsP.Columns[2].Name = "Trạng thái";
            autoSizetb(tb_detailsP);
        }
        public void setDataPromotion(List<KhuyenMaiDTO> list)
        {
            tb_promotion.Rows.Clear();
            foreach (KhuyenMaiDTO item in list)
            {
                string[] row = new string[] { item.IdPromotion.ToString(), item.NamePromotion
                   };
                tb_promotion.Rows.Add(row);
            }
        }
        public void setDataDetailsPromotion(int idPromotion)
        {
            this.tb_detailsP.Rows.Clear();
            List<ChiTietKhuyenMaiDTO> list = listDetailsPromotion(idPromotion);
            foreach (ChiTietKhuyenMaiDTO item in list)
            {
                SanPham p = productManage.searchId(item.IdProduct);
                string[] row = new string[] {p.NameProduct, item.Discount.ToString(),item.Status };
                tb_detailsP.Rows.Add(row);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsertPicture_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //formCreateDetailPromotion.ShowDialog();
            //this.Show();
            this.fCreateDetailPromotion = new FormCreateDetailPromotion();
            guna2Panel1.Controls.Clear();
            fCreateDetailPromotion.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(fCreateDetailPromotion);
            fCreateDetailPromotion.Dock = DockStyle.Fill;
            fCreateDetailPromotion.Show();
        }

        private void eventClickPromotion(object sender, DataGridViewCellEventArgs e)
        {


            if (tb_promotion.RowCount > 1)
                if (tb_promotion.CurrentRow != null)
                {
                    int rowindex = tb_promotion.CurrentCell.RowIndex;
                    if (tb_promotion.Rows.Count -2 >= rowindex)
                    {
                        int idPromotion = int.Parse(tb_promotion.Rows[rowindex].Cells[0].Value.ToString());

                        setDataDetailsPromotion(idPromotion);
                    }

                }
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            string text = this.inp_search.Text;
            List<KhuyenMaiDTO> list = promotionManage.searchPromotion(text);
            setDataPromotion(list);
        }

        private void btn_exportPromotion_Click(object sender, EventArgs e)
        {
            if (tb_promotion.RowCount > 1)
                if (tb_promotion.CurrentRow != null)
                {
                    int rowindex = tb_promotion.CurrentCell.RowIndex;
                    int idPromotion = int.Parse(tb_promotion.Rows[rowindex].Cells[0].Value.ToString());

                   string result =  promotionManage.exportPromotionExcel(idPromotion.ToString());
                    export(result, idPromotion.ToString());
                }
        }
        public void export(string result, string idPromotion)
        {
            if (result == "success")
                MessageBox.Show("Đã in thành công, mã khuyến mãi" + idPromotion, "Export", MessageBoxButtons.OK);
            else
                MessageBox.Show("Không thể in khuyến mãi mã lỗi "+"-1", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
