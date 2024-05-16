using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Login : Form
    {
        private FormMainMenu menu;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

      

        private void login_click(object sender, EventArgs e)
        {
            string text_user = input_user.Text + "",
                    text_pass = input_pass.Text + "";
            BUS.Login us = new BUS.Login();
            string result = us.login(text_user, text_pass);
            login(result);

        }
        public void login(string s)
        {
            resetError();
            switch (s) {
                case "success":
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        menu = new FormMainMenu();
                        menu.ShowDialog();
                        break;
                    }
                case "notFound":
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    }
                case "requeid_user":
                    {
                        error_nullUser.Text = "Tài khoản không được để trống";
                        break;
                    }
                default:{
                        error_nullPass.Text = "Mật khẩu không được để trống";
                        break;
                    }
            }

        }
        public void resetError()
        {
            error_nullPass.Text = "";
            error_nullUser.Text = "";
        }

        private void forgot_click(object sender, EventArgs e)
        {

        }

        private void exitSystem_click(object sender, EventArgs e)
        {

        }

        private void input_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_title_Click(object sender, EventArgs e)
        {

        }

        private void text_user_Click(object sender, EventArgs e)
        {

        }

        private void eventKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text_user = input_user.Text + "",
                     text_pass = input_pass.Text + "";
                BUS.Login us = new BUS.Login();
                string result = us.login(text_user, text_pass);
                login(result);
            }
        }

        private void eventKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text_user = input_user.Text + "",
                     text_pass = input_pass.Text + "";
                BUS.Login us = new BUS.Login();
                string result = us.login(text_user, text_pass);
                login(result);
            }
        }
    }
}
