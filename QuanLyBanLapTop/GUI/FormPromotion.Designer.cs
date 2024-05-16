namespace GUI
{
    partial class FormPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPromotion));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_detailPromotion = new System.Windows.Forms.Label();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_exportPromotion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_addPromotion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Promotion = new System.Windows.Forms.Label();
            this.txt_titlePromotion = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tb_promotion = new System.Windows.Forms.DataGridView();
            this.tb_detailsP = new System.Windows.Forms.DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_promotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsP)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tb_detailsP);
            this.guna2Panel1.Controls.Add(this.tb_promotion);
            this.guna2Panel1.Controls.Add(this.inp_search);
            this.guna2Panel1.Controls.Add(this.txt_detailPromotion);
            this.guna2Panel1.Controls.Add(this.guna2GradientButton3);
            this.guna2Panel1.Controls.Add(this.btn_exportPromotion);
            this.guna2Panel1.Controls.Add(this.btn_addPromotion);
            this.guna2Panel1.Controls.Add(this.txt_Promotion);
            this.guna2Panel1.Controls.Add(this.txt_titlePromotion);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 13);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1156, 833);
            this.guna2Panel1.TabIndex = 0;
            // 
            // inp_search
            // 
            this.inp_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.inp_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_search.ForeColor = System.Drawing.Color.White;
            this.inp_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_search.HoverState.Parent = this.inp_search;
            this.inp_search.Location = new System.Drawing.Point(386, 110);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(296, 39);
            this.inp_search.TabIndex = 25;
            this.inp_search.TextChanged += new System.EventHandler(this.inp_search_TextChanged);
            // 
            // txt_detailPromotion
            // 
            this.txt_detailPromotion.AutoSize = true;
            this.txt_detailPromotion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detailPromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_detailPromotion.Location = new System.Drawing.Point(65, 470);
            this.txt_detailPromotion.Name = "txt_detailPromotion";
            this.txt_detailPromotion.Size = new System.Drawing.Size(167, 23);
            this.txt_detailPromotion.TabIndex = 16;
            this.txt_detailPromotion.Text = "Chi tiết khuyến mãi";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.BorderRadius = 10;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(692, 110);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(163, 39);
            this.guna2GradientButton3.TabIndex = 15;
            this.guna2GradientButton3.Text = "Tìm kiếm";
            // 
            // btn_exportPromotion
            // 
            this.btn_exportPromotion.Animated = true;
            this.btn_exportPromotion.BorderRadius = 10;
            this.btn_exportPromotion.CheckedState.Parent = this.btn_exportPromotion;
            this.btn_exportPromotion.CustomImages.Parent = this.btn_exportPromotion;
            this.btn_exportPromotion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exportPromotion.ForeColor = System.Drawing.Color.White;
            this.btn_exportPromotion.HoverState.Parent = this.btn_exportPromotion;
            this.btn_exportPromotion.Location = new System.Drawing.Point(908, 234);
            this.btn_exportPromotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exportPromotion.Name = "btn_exportPromotion";
            this.btn_exportPromotion.ShadowDecoration.Parent = this.btn_exportPromotion;
            this.btn_exportPromotion.Size = new System.Drawing.Size(200, 60);
            this.btn_exportPromotion.TabIndex = 13;
            this.btn_exportPromotion.Text = "Xuất CTKM";
            this.btn_exportPromotion.Click += new System.EventHandler(this.btn_exportPromotion_Click);
            // 
            // btn_addPromotion
            // 
            this.btn_addPromotion.Animated = true;
            this.btn_addPromotion.BorderRadius = 10;
            this.btn_addPromotion.CheckedState.Parent = this.btn_addPromotion;
            this.btn_addPromotion.CustomImages.Parent = this.btn_addPromotion;
            this.btn_addPromotion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addPromotion.ForeColor = System.Drawing.Color.White;
            this.btn_addPromotion.HoverState.Parent = this.btn_addPromotion;
            this.btn_addPromotion.Location = new System.Drawing.Point(908, 155);
            this.btn_addPromotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addPromotion.Name = "btn_addPromotion";
            this.btn_addPromotion.ShadowDecoration.Parent = this.btn_addPromotion;
            this.btn_addPromotion.Size = new System.Drawing.Size(200, 60);
            this.btn_addPromotion.TabIndex = 12;
            this.btn_addPromotion.Text = "Tạo CTKM";
            this.btn_addPromotion.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txt_Promotion
            // 
            this.txt_Promotion.AutoSize = true;
            this.txt_Promotion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Promotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Promotion.Location = new System.Drawing.Point(65, 133);
            this.txt_Promotion.Name = "txt_Promotion";
            this.txt_Promotion.Size = new System.Drawing.Size(189, 23);
            this.txt_Promotion.TabIndex = 10;
            this.txt_Promotion.Text = "Danh sách khuyến mãi";
            // 
            // txt_titlePromotion
            // 
            this.txt_titlePromotion.AutoSize = true;
            this.txt_titlePromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titlePromotion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_titlePromotion.Location = new System.Drawing.Point(460, 62);
            this.txt_titlePromotion.Name = "txt_titlePromotion";
            this.txt_titlePromotion.Size = new System.Drawing.Size(299, 29);
            this.txt_titlePromotion.TabIndex = 9;
            this.txt_titlePromotion.Text = "Chương trình khuyến mãi";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tb_promotion
            // 
            this.tb_promotion.AllowUserToResizeColumns = false;
            this.tb_promotion.AllowUserToResizeRows = false;
            this.tb_promotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_promotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_promotion.Location = new System.Drawing.Point(46, 159);
            this.tb_promotion.Name = "tb_promotion";
            this.tb_promotion.ReadOnly = true;
            this.tb_promotion.RowHeadersVisible = false;
            this.tb_promotion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_promotion.RowTemplate.Height = 24;
            this.tb_promotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_promotion.Size = new System.Drawing.Size(809, 308);
            this.tb_promotion.TabIndex = 116;
            this.tb_promotion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventClickPromotion);
            // 
            // tb_detailsP
            // 
            this.tb_detailsP.AllowUserToResizeColumns = false;
            this.tb_detailsP.AllowUserToResizeRows = false;
            this.tb_detailsP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_detailsP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_detailsP.Location = new System.Drawing.Point(46, 496);
            this.tb_detailsP.Name = "tb_detailsP";
            this.tb_detailsP.ReadOnly = true;
            this.tb_detailsP.RowHeadersVisible = false;
            this.tb_detailsP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_detailsP.RowTemplate.Height = 24;
            this.tb_detailsP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_detailsP.Size = new System.Drawing.Size(1062, 274);
            this.tb_detailsP.TabIndex = 117;
            // 
            // FormPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1156, 846);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPromotion";
            this.Text = "Quản lý bán Laptop";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_promotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_detailsP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label txt_detailPromotion;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_exportPromotion;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addPromotion;
        private System.Windows.Forms.Label txt_Promotion;
        private System.Windows.Forms.Label txt_titlePromotion;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.DataGridView tb_detailsP;
        private System.Windows.Forms.DataGridView tb_promotion;
    }
}