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

namespace GUI
{
    public partial class FormStatistic : Form
    {
        private ProductStatistics productStatistics = new ProductStatistics();
        private FormRankStatistic formRank;
        public FormStatistic()
        {
            InitializeComponent();
            setDataYear();
            statisticAll(cbb_manu.Text);
            InitializeTbStatistic();
            
        }
        public void statisticAll(string year)
        {
            Dictionary<string, string> statistic = productStatistics.overview(year);
            txt_customer.Text = statistic["customer"]+"";
            txt_employee.Text = statistic["employee"]+"";
            txt_nameProduct.Text = statistic["product"] + "";
            txt_totalMoney.Text = statistic["total"]+"";
        }
        public void InitializeTbStatistic()
        {
            tb_month.ColumnCount = 13;
            tb_month.Columns[0].Name = "*";
            for(int i = 1; i < 5; i++)
            {
                tb_month.Columns[i].Name = "Quý "+(i).ToString();
            }
            autoSizetb(tb_month);

        }
        public void setDataTbStatistic(string year)
        {
            tb_month.Rows.Clear();
            Dictionary<string, string> sumMonth = productStatistics.totalMonth(year);
            string[] a = new string[sumMonth.Count + 1];
            a[0] = "Doanh thu";
            for (int i = 1; i <= 4; i++)
            {
                float sum = 0;
                for (int j = 0; j < 3; j++)
                    sum += float.Parse(sumMonth[(i*3-j).ToString()]);
                a[i] = sum.ToString("0.0");
            }
            if(a.Length >0)
                tb_month.Rows.Add(a);
        }
        public void setDataYear()
        {
            string[] year = { "2020","2021","2022" };
            cbb_manu.DataSource = year;
            cbb_manu.SelectedIndex = 0;
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {

        }

        private void cbb_manu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = cbb_manu.Text;
            statisticAll(year);
            setDataTbStatistic(year);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //formCreateDetailPromotion.ShowDialog();
            //this.Show();
            this.formRank = new FormRankStatistic(this.cbb_manu.Text);
            guna2Panel1.Controls.Clear();
            formRank.TopLevel = false;
            //pnlBody.Controls.Add(guna2Panel2);
            guna2Panel1.Controls.Add(formRank);
            formRank.Dock = DockStyle.Fill;
            formRank.Show();
        }
    }
}
