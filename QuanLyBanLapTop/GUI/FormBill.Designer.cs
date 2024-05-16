namespace GUI
{
    partial class FormBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_detailsBill = new System.Windows.Forms.DataGridView();
            this.tb_bill = new System.Windows.Forms.DataGridView();
            this.txt_detailsBill = new System.Windows.Forms.Label();
            this.btn_export = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_pay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.icon_search = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_listBill = new System.Windows.Forms.Label();
            this.txt_titleProduct = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_search)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tb_detailsBill);
            this.guna2Panel1.Controls.Add(this.tb_bill);
            this.guna2Panel1.Controls.Add(this.txt_detailsBill);
            this.guna2Panel1.Controls.Add(this.btn_export);
            this.guna2Panel1.Controls.Add(this.btn_pay);
            this.guna2Panel1.Controls.Add(this.inp_search);
            this.guna2Panel1.Controls.Add(this.icon_search);
            this.guna2Panel1.Controls.Add(this.txt_listBill);
            this.guna2Panel1.Controls.Add(this.txt_titleProduct);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1157, 790);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tb_detailsBill
            // 
            this.tb_detailsBill.AllowUserToResizeColumns = false;
            this.tb_detailsBill.AllowUserToResizeRows = false;
            this.tb_detailsBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_detailsBill.Location = new System.Drawing.Point(15, 560);
            this.tb_detailsBill.Name = "tb_detailsBill";
            this.tb_detailsBill.ReadOnly = true;
            this.tb_detailsBill.RowHeadersVisible = false;
            this.tb_detailsBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_detailsBill.RowTemplate.Height = 24;
            this.tb_detailsBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_detailsBill.Size = new System.Drawing.Size(904, 243);
            this.tb_detailsBill.TabIndex = 69;
            this.tb_detailsBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_detailsBill_CellContentClick_1);
            // 
            // tb_bill
            // 
            this.tb_bill.AllowUserToResizeColumns = false;
            this.tb_bill.AllowUserToResizeRows = false;
            this.tb_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_bill.Location = new System.Drawing.Point(15, 234);
            this.tb_bill.Name = "tb_bill";
            this.tb_bill.ReadOnly = true;
            this.tb_bill.RowHeadersVisible = false;
            this.tb_bill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_bill.RowTemplate.Height = 24;
            this.tb_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_bill.Size = new System.Drawing.Size(904, 289);
            this.tb_bill.TabIndex = 68;
            this.tb_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickCellBill);
            this.tb_bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_bill_CellContentClick);
            // 
            // txt_detailsBill
            // 
            this.txt_detailsBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_detailsBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detailsBill.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_detailsBill.Location = new System.Drawing.Point(16, 517);
            this.txt_detailsBill.Name = "txt_detailsBill";
            this.txt_detailsBill.Size = new System.Drawing.Size(174, 31);
            this.txt_detailsBill.TabIndex = 66;
            this.txt_detailsBill.Text = "Chi tiết hoá đơn";
            this.txt_detailsBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_export.Animated = true;
            this.btn_export.BorderRadius = 10;
            this.btn_export.CheckedState.Parent = this.btn_export;
            this.btn_export.CustomImages.Parent = this.btn_export;
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.HoverState.Parent = this.btn_export;
            this.btn_export.Location = new System.Drawing.Point(963, 293);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.ShadowDecoration.Parent = this.btn_export;
            this.btn_export.Size = new System.Drawing.Size(148, 40);
            this.btn_export.TabIndex = 65;
            this.btn_export.Text = "Xuất hoá đơn";
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pay.Animated = true;
            this.btn_pay.BorderRadius = 10;
            this.btn_pay.CheckedState.Parent = this.btn_pay;
            this.btn_pay.CustomImages.Parent = this.btn_pay;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.HoverState.Parent = this.btn_pay;
            this.btn_pay.Location = new System.Drawing.Point(963, 236);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.ShadowDecoration.Parent = this.btn_pay;
            this.btn_pay.Size = new System.Drawing.Size(148, 40);
            this.btn_pay.TabIndex = 64;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // inp_search
            // 
            this.inp_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inp_search.Animated = true;
            this.inp_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_search.BorderRadius = 6;
            this.inp_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_search.DefaultText = "";
            this.inp_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_search.DisabledState.Parent = this.inp_search;
            this.inp_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_search.FocusedState.Parent = this.inp_search;
            this.inp_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inp_search.ForeColor = System.Drawing.Color.White;
            this.inp_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_search.HoverState.Parent = this.inp_search;
            this.inp_search.Location = new System.Drawing.Point(427, 166);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(296, 36);
            this.inp_search.TabIndex = 62;
            this.inp_search.TextChanged += new System.EventHandler(this.inpSearch_TextChanged);
            // 
            // icon_search
            // 
            this.icon_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon_search.Image = global::GUI.Properties.Resources.search;
            this.icon_search.Location = new System.Drawing.Point(753, 166);
            this.icon_search.Margin = new System.Windows.Forms.Padding(4);
            this.icon_search.Name = "icon_search";
            this.icon_search.ShadowDecoration.Parent = this.icon_search;
            this.icon_search.Size = new System.Drawing.Size(62, 37);
            this.icon_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_search.TabIndex = 61;
            this.icon_search.TabStop = false;
            // 
            // txt_listBill
            // 
            this.txt_listBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_listBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_listBill.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_listBill.Location = new System.Drawing.Point(16, 195);
            this.txt_listBill.Name = "txt_listBill";
            this.txt_listBill.Size = new System.Drawing.Size(196, 22);
            this.txt_listBill.TabIndex = 60;
            this.txt_listBill.Text = "Danh sách hoá đơn";
            this.txt_listBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_listBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_titleProduct
            // 
            this.txt_titleProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_titleProduct.AutoSize = true;
            this.txt_titleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titleProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_titleProduct.Location = new System.Drawing.Point(463, 101);
            this.txt_titleProduct.Name = "txt_titleProduct";
            this.txt_titleProduct.Size = new System.Drawing.Size(237, 32);
            this.txt_titleProduct.TabIndex = 56;
            this.txt_titleProduct.Text = "Quản lý hoá đơn";
            this.txt_titleProduct.Click += new System.EventHandler(this.txt_titleProduct_Click);
            // 
            // FormBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1157, 790);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý bán Laptop";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label txt_titleProduct;
        private System.Windows.Forms.Label txt_listBill;
        private Guna.UI2.WinForms.Guna2PictureBox icon_search;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label txt_detailsBill;
        private Guna.UI2.WinForms.Guna2GradientButton btn_export;
        private Guna.UI2.WinForms.Guna2GradientButton btn_pay;
        private System.Windows.Forms.DataGridView tb_bill;
        private System.Windows.Forms.DataGridView tb_detailsBill;
    }
}