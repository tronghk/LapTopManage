using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.FormSell;

namespace GUI
{
    public partial class FormMainMenu : Form
    {
        FormPromotion fPromotion = new FormPromotion();
        FormSell fSell = new FormSell();
        FormProduct fProduct = new FormProduct();
        FormCustomer fCustomer = new FormCustomer();
        FormEmployee fEmployee = new FormEmployee();
        public static List<Panel> listPanel = new List<Panel>();
        FormBill fBill = new FormBill();
        FormProductType formProductType = new FormProductType();
        FormProductManufacture fProductManufacture = new FormProductManufacture();
        FormWareHouse fWarehouse = new FormWareHouse();
        FormStatistic formStatistic = new FormStatistic();

        public static string path = "E:\\Workspace\\C#\\myProject\\DoAnC-_QuanLyBanLapTop\\Image\\";

        public FormMainMenu()
        {
            InitializeComponent();
            addListPanel();
            incognitoPanel();
        }
        public void incognitoPanel()
        {
            foreach(Panel value in listPanel)
            {
                value.Visible = false;
            }

        }
        public static void displayPanel(Panel p)
        {
            foreach (Panel value in listPanel)
            {
                value.Visible = false;
            }
            if (p != null)
            {
               
                p.Visible = true;
            }
        }
        public void addListPanel()
        {
            listPanel.Add(this.panel_sell);
            listPanel.Add(this.panel_product);
            listPanel.Add(this.panel_employee);
            

        }


        private void btn_promotion_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fPromotion = new FormPromotion();
                pnlBody.Controls.Clear();
                fPromotion.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fPromotion);
                fPromotion.Dock = DockStyle.Fill;
                fPromotion.Show();
                displayPanel(null);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            fSell = new FormSell();
            displayPanel(this.panel_sell);
            pnlBody.Controls.Clear();
            fSell.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fSell);
            fSell.Dock = DockStyle.Fill;
            fSell.Show();



        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
               
                fProduct = new FormProduct();
                displayPanel(this.panel_product);
                pnlBody.Controls.Clear();
                fProduct.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fProduct);
                fProduct.Dock = DockStyle.Fill;
                fProduct.Show();
            }
            
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fCustomer = new FormCustomer();
                pnlBody.Controls.Clear();
                fCustomer.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fCustomer);
                fCustomer.Dock = DockStyle.Fill;
                fCustomer.Show();
                displayPanel(null);
            }
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fEmployee = new FormEmployee();
                displayPanel(this.panel_employee);
                pnlBody.Controls.Clear();
                fEmployee.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fEmployee);
                fEmployee.Dock = DockStyle.Fill;
                fEmployee.Show();
            }
        }

        private void btn_sellCart_Click(object sender, EventArgs e)
        {

            pnlBody.Controls.Clear();
            fSell = new FormSell();
            fSell.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fSell);
            fSell.Dock = DockStyle.Fill;
            fSell.Show();
            
        }
        public bool saveBill()
        {
            if (fSell.purchaseProduct.listChiTietHoaDonDTO.Count > 0)
            {
                var ev = MessageBox.Show("Hoá đơn chưa được lưu bạn có muốn lưu lại không", "Lưu hoá đơn", MessageBoxButtons.YesNoCancel);
                if (ev == DialogResult.Yes)
                {
                    fSell.purchaseProduct.saveOrder();
                    MessageBox.Show("Hoá đơn đã được lưu, mã hoá đơn: " + fSell.purchaseProduct.idBill, "Thông báo", MessageBoxButtons.OK);
                    fSell = new FormSell();
                    return true;

                }
                else if (ev == DialogResult.No)
                {
                    fSell.purchaseProduct.restartBill();
                    return true;
                }
                else{
                    return false;
                }

            }
            return true;
        }

        private void btn_billCart_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fBill = new FormBill();
                pnlBody.Controls.Clear();
                fBill.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fBill);
                fBill.Dock = DockStyle.Fill;
                fBill.Show();
                displayPanel(panel_sell);
            }

        }

        private void panel_sell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                fWarehouse = new FormWareHouse();
                pnlBody.Controls.Clear();
                fWarehouse.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(fWarehouse);
                fWarehouse.Dock = DockStyle.Fill;
                fWarehouse.Show();
                displayPanel(null);
            }
        }

        private void btn_statistical_Click(object sender, EventArgs e)
        {
            if (saveBill())
            {
                formStatistic = new FormStatistic();
                pnlBody.Controls.Clear();
                formStatistic.TopLevel = false;
                pnlBody.Controls.Add(guna2Panel2);
                pnlBody.Controls.Add(formStatistic);
                formStatistic.Dock = DockStyle.Fill;
                formStatistic.Show();
                displayPanel(null);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fProduct.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fProduct);
            fProduct.Dock = DockStyle.Fill;
            fProduct.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            formProductType = new FormProductType();
            formProductType.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(formProductType);
            formProductType.Dock = DockStyle.Fill;
            formProductType.Show();
            displayPanel(panel_product);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fProductManufacture = new FormProductManufacture();
            fProductManufacture.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fProductManufacture);
            fProductManufacture.Dock = DockStyle.Fill;
            fProductManufacture.Show();
            displayPanel(panel_product);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cartEmployee_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fEmployee.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
            
        }

        private void cart_employee_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fEmployee.TopLevel = false;
            pnlBody.Controls.Add(guna2Panel2);
            pnlBody.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
        }

        private void cart_Quyen_Click(object sender, EventArgs e)
        {

        }
    }
}
