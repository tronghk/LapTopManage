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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormRankStatistic : Form
    {
        private string year;
        private ProductStatistics productStatistics = new ProductStatistics();
        public FormRankStatistic(string year)
        {
            InitializeComponent();
            this.year = year;
            InitializeTbTopProduct();
            setDataTopProduct(this.year);
            initializeChart(this.year);
        }
        public void InitializeTbTopProduct()
        {
            tb_topProduct.ColumnCount = 4;
            tb_topProduct.Columns[0].Name = "Top";
            tb_topProduct.Columns[1].Name = "Tên sản phẩm";
            tb_topProduct.Columns[2].Name = "Số lượng bán";
            tb_topProduct.Columns[3].Name = "Doanh thu";
        }
        public void initializeChart(string year)
        {
            Dictionary<string, string> data = productStatistics.totalMonth(year);
            
            // Data arrays.
            string[] seriesArray = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                seriesArray[i - 1] ="Tháng "+ i.ToString();
            }
            
            float[] pointsArray = new float[12];
            for (int i = 1; i <= 12; i++)
            {
                pointsArray[i - 1] = float.Parse(float.Parse(data[i.ToString()]).ToString("0.0"));
            }
            Console.WriteLine(pointsArray[11]);


            // Set palette.
            this.chart_statistic.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart_statistic.Titles.Add("Doanh thu");

            // Add series.
            for (int i = 0; i < 12; i++)
            {
                // Add series.
                Series series = this.chart_statistic.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);

            }
        }
        public void setDataTopProduct(string year)
        {
            List<Dictionary<string, string>> list = productStatistics.topProduct(year);
            tb_topProduct.Rows.Clear();
            int index = 1;
            foreach (Dictionary<string, string> item in list)
            {
                string[] row = new string[4];
                row[0] = index.ToString();
                row[1] = item["name"];
                row[3] = float.Parse(item["total"]).ToString("0.0");
                row[2] = item["quantity"];
                index++;
                tb_topProduct.Rows.Add(row);
            }
        }

    }

}
