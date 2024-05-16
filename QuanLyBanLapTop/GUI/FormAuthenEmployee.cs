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

namespace GUI
{
    public partial class FormAuthenEmployee : Form
    {
        public FormAuthenEmployee()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FormEmployee fEmployee = new FormEmployee();
            guna2Panel1.Controls.Clear();
            fEmployee.TopLevel = false;
            guna2Panel1.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            FormEmployee fEmployee = new FormEmployee();
            guna2Panel1.Controls.Clear();
            fEmployee.TopLevel = false;
            guna2Panel1.Controls.Add(fEmployee);
            fEmployee.Dock = DockStyle.Fill;
            fEmployee.Show();
        }
    }
}
