namespace GUI
{
    partial class FormSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSell));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.success = new System.Windows.Forms.Label();
            this.error_sell = new System.Windows.Forms.Label();
            this.tb_order = new System.Windows.Forms.DataGridView();
            this.tb_product = new System.Windows.Forms.DataGridView();
            this.btn_pay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.icon_search = new Guna.UI2.WinForms.Guna2PictureBox();
            this.img_avatarProduct = new System.Windows.Forms.PictureBox();
            this.btn_deleteProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_editProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_addProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.inp_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_total = new System.Windows.Forms.Label();
            this.inp_sales = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sales = new System.Windows.Forms.Label();
            this.inp_unitPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_unitPrice = new System.Windows.Forms.Label();
            this.inp_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_quantity = new System.Windows.Forms.Label();
            this.inp_nameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nameProduct = new System.Windows.Forms.Label();
            this.id_product = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_manufacturer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_title = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatarProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.success);
            this.guna2Panel1.Controls.Add(this.error_sell);
            this.guna2Panel1.Controls.Add(this.tb_order);
            this.guna2Panel1.Controls.Add(this.tb_product);
            this.guna2Panel1.Controls.Add(this.btn_pay);
            this.guna2Panel1.Controls.Add(this.icon_search);
            this.guna2Panel1.Controls.Add(this.img_avatarProduct);
            this.guna2Panel1.Controls.Add(this.btn_deleteProduct);
            this.guna2Panel1.Controls.Add(this.btn_editProduct);
            this.guna2Panel1.Controls.Add(this.btn_addProduct);
            this.guna2Panel1.Controls.Add(this.inp_total);
            this.guna2Panel1.Controls.Add(this.txt_total);
            this.guna2Panel1.Controls.Add(this.inp_sales);
            this.guna2Panel1.Controls.Add(this.txt_sales);
            this.guna2Panel1.Controls.Add(this.inp_unitPrice);
            this.guna2Panel1.Controls.Add(this.txt_unitPrice);
            this.guna2Panel1.Controls.Add(this.inp_quantity);
            this.guna2Panel1.Controls.Add(this.txt_quantity);
            this.guna2Panel1.Controls.Add(this.inp_nameProduct);
            this.guna2Panel1.Controls.Add(this.txt_nameProduct);
            this.guna2Panel1.Controls.Add(this.id_product);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.cbb_manufacturer);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.inp_search);
            this.guna2Panel1.Controls.Add(this.txt_title);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1156, 846);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "Giỏ hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Danh sách sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.ForeColor = System.Drawing.Color.Lime;
            this.success.Location = new System.Drawing.Point(255, 552);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(0, 25);
            this.success.TabIndex = 61;
            // 
            // error_sell
            // 
            this.error_sell.AutoSize = true;
            this.error_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_sell.ForeColor = System.Drawing.Color.Red;
            this.error_sell.Location = new System.Drawing.Point(275, 552);
            this.error_sell.Name = "error_sell";
            this.error_sell.Size = new System.Drawing.Size(0, 25);
            this.error_sell.TabIndex = 60;
            // 
            // tb_order
            // 
            this.tb_order.AllowUserToResizeColumns = false;
            this.tb_order.AllowUserToResizeRows = false;
            this.tb_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_order.Location = new System.Drawing.Point(18, 592);
            this.tb_order.Name = "tb_order";
            this.tb_order.ReadOnly = true;
            this.tb_order.RowHeadersVisible = false;
            this.tb_order.RowHeadersWidth = 51;
            this.tb_order.RowTemplate.Height = 24;
            this.tb_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_order.Size = new System.Drawing.Size(689, 234);
            this.tb_order.TabIndex = 59;
            this.tb_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_order_CellContentClick);
            this.tb_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_order_CellContentClick_1);
            // 
            // tb_product
            // 
            this.tb_product.AllowUserToResizeColumns = false;
            this.tb_product.AllowUserToResizeRows = false;
            this.tb_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_product.Location = new System.Drawing.Point(18, 205);
            this.tb_product.Name = "tb_product";
            this.tb_product.ReadOnly = true;
            this.tb_product.RowHeadersVisible = false;
            this.tb_product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_product.RowTemplate.Height = 24;
            this.tb_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_product.Size = new System.Drawing.Size(689, 338);
            this.tb_product.TabIndex = 58;
            this.tb_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_product_CellContentClick_1);
            this.tb_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_product_CellContentClick);
            this.tb_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventKeydown);
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
            this.btn_pay.Location = new System.Drawing.Point(926, 787);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.ShadowDecoration.Parent = this.btn_pay;
            this.btn_pay.Size = new System.Drawing.Size(121, 39);
            this.btn_pay.TabIndex = 57;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // icon_search
            // 
            this.icon_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icon_search.Image = global::GUI.Properties.Resources.search;
            this.icon_search.Location = new System.Drawing.Point(644, 138);
            this.icon_search.Margin = new System.Windows.Forms.Padding(4);
            this.icon_search.Name = "icon_search";
            this.icon_search.ShadowDecoration.Parent = this.icon_search;
            this.icon_search.Size = new System.Drawing.Size(62, 41);
            this.icon_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_search.TabIndex = 56;
            this.icon_search.TabStop = false;
            // 
            // img_avatarProduct
            // 
            this.img_avatarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_avatarProduct.BackColor = System.Drawing.SystemColors.Window;
            this.img_avatarProduct.Location = new System.Drawing.Point(900, 607);
            this.img_avatarProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.img_avatarProduct.Name = "img_avatarProduct";
            this.img_avatarProduct.Size = new System.Drawing.Size(172, 172);
            this.img_avatarProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_avatarProduct.TabIndex = 54;
            this.img_avatarProduct.TabStop = false;
            this.img_avatarProduct.Click += new System.EventHandler(this.img_avatarProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteProduct.Animated = true;
            this.btn_deleteProduct.BorderRadius = 10;
            this.btn_deleteProduct.CheckedState.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.CustomImages.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteProduct.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProduct.HoverState.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Location = new System.Drawing.Point(989, 559);
            this.btn_deleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.ShadowDecoration.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Size = new System.Drawing.Size(121, 39);
            this.btn_deleteProduct.TabIndex = 53;
            this.btn_deleteProduct.Text = "Xoá CT";
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editProduct.Animated = true;
            this.btn_editProduct.BorderRadius = 10;
            this.btn_editProduct.CheckedState.Parent = this.btn_editProduct;
            this.btn_editProduct.CustomImages.Parent = this.btn_editProduct;
            this.btn_editProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editProduct.ForeColor = System.Drawing.Color.White;
            this.btn_editProduct.HoverState.Parent = this.btn_editProduct;
            this.btn_editProduct.Location = new System.Drawing.Point(848, 559);
            this.btn_editProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.ShadowDecoration.Parent = this.btn_editProduct;
            this.btn_editProduct.Size = new System.Drawing.Size(121, 39);
            this.btn_editProduct.TabIndex = 52;
            this.btn_editProduct.Text = "Sửa CT";
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addProduct.Animated = true;
            this.btn_addProduct.BorderRadius = 10;
            this.btn_addProduct.CheckedState.Parent = this.btn_addProduct;
            this.btn_addProduct.CustomImages.Parent = this.btn_addProduct;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.HoverState.Parent = this.btn_addProduct;
            this.btn_addProduct.Location = new System.Drawing.Point(918, 504);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.ShadowDecoration.Parent = this.btn_addProduct;
            this.btn_addProduct.Size = new System.Drawing.Size(143, 39);
            this.btn_addProduct.TabIndex = 51;
            this.btn_addProduct.Text = "Thêm vào giỏ hàng";
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // inp_total
            // 
            this.inp_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_total.Animated = true;
            this.inp_total.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_total.BorderRadius = 6;
            this.inp_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_total.DefaultText = "";
            this.inp_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_total.DisabledState.Parent = this.inp_total;
            this.inp_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_total.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_total.FocusedState.Parent = this.inp_total;
            this.inp_total.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_total.ForeColor = System.Drawing.Color.White;
            this.inp_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_total.HoverState.Parent = this.inp_total;
            this.inp_total.Location = new System.Drawing.Point(848, 454);
            this.inp_total.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_total.Name = "inp_total";
            this.inp_total.PasswordChar = '\0';
            this.inp_total.PlaceholderText = "";
            this.inp_total.ReadOnly = true;
            this.inp_total.SelectedText = "";
            this.inp_total.ShadowDecoration.Parent = this.inp_total;
            this.inp_total.Size = new System.Drawing.Size(262, 36);
            this.inp_total.TabIndex = 48;
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_total.Location = new System.Drawing.Point(712, 454);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(125, 37);
            this.txt_total.TabIndex = 47;
            this.txt_total.Text = "Thành tiền";
            this.txt_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_sales
            // 
            this.inp_sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_sales.Animated = true;
            this.inp_sales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_sales.BorderRadius = 6;
            this.inp_sales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_sales.DefaultText = "";
            this.inp_sales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_sales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_sales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_sales.DisabledState.Parent = this.inp_sales;
            this.inp_sales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_sales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_sales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_sales.FocusedState.Parent = this.inp_sales;
            this.inp_sales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_sales.ForeColor = System.Drawing.Color.White;
            this.inp_sales.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_sales.HoverState.Parent = this.inp_sales;
            this.inp_sales.Location = new System.Drawing.Point(848, 406);
            this.inp_sales.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_sales.Name = "inp_sales";
            this.inp_sales.PasswordChar = '\0';
            this.inp_sales.PlaceholderText = "";
            this.inp_sales.ReadOnly = true;
            this.inp_sales.SelectedText = "";
            this.inp_sales.ShadowDecoration.Parent = this.inp_sales;
            this.inp_sales.Size = new System.Drawing.Size(262, 36);
            this.inp_sales.TabIndex = 46;
            // 
            // txt_sales
            // 
            this.txt_sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sales.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_sales.Location = new System.Drawing.Point(713, 406);
            this.txt_sales.Name = "txt_sales";
            this.txt_sales.Size = new System.Drawing.Size(124, 37);
            this.txt_sales.TabIndex = 45;
            this.txt_sales.Text = "% Giảm";
            this.txt_sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_unitPrice
            // 
            this.inp_unitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_unitPrice.Animated = true;
            this.inp_unitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_unitPrice.BorderRadius = 6;
            this.inp_unitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_unitPrice.DefaultText = "";
            this.inp_unitPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_unitPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_unitPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_unitPrice.DisabledState.Parent = this.inp_unitPrice;
            this.inp_unitPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_unitPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_unitPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_unitPrice.FocusedState.Parent = this.inp_unitPrice;
            this.inp_unitPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_unitPrice.ForeColor = System.Drawing.Color.White;
            this.inp_unitPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_unitPrice.HoverState.Parent = this.inp_unitPrice;
            this.inp_unitPrice.Location = new System.Drawing.Point(848, 356);
            this.inp_unitPrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_unitPrice.Name = "inp_unitPrice";
            this.inp_unitPrice.PasswordChar = '\0';
            this.inp_unitPrice.PlaceholderText = "";
            this.inp_unitPrice.ReadOnly = true;
            this.inp_unitPrice.SelectedText = "";
            this.inp_unitPrice.ShadowDecoration.Parent = this.inp_unitPrice;
            this.inp_unitPrice.Size = new System.Drawing.Size(262, 36);
            this.inp_unitPrice.TabIndex = 44;
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_unitPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_unitPrice.Location = new System.Drawing.Point(712, 356);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(125, 37);
            this.txt_unitPrice.TabIndex = 43;
            this.txt_unitPrice.Text = "Giá bán";
            this.txt_unitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_quantity
            // 
            this.inp_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_quantity.Animated = true;
            this.inp_quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_quantity.BorderRadius = 6;
            this.inp_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_quantity.DefaultText = "";
            this.inp_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_quantity.DisabledState.Parent = this.inp_quantity;
            this.inp_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_quantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_quantity.FocusedState.Parent = this.inp_quantity;
            this.inp_quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_quantity.ForeColor = System.Drawing.Color.White;
            this.inp_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_quantity.HoverState.Parent = this.inp_quantity;
            this.inp_quantity.Location = new System.Drawing.Point(848, 306);
            this.inp_quantity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_quantity.Name = "inp_quantity";
            this.inp_quantity.PasswordChar = '\0';
            this.inp_quantity.PlaceholderText = "";
            this.inp_quantity.SelectedText = "";
            this.inp_quantity.ShadowDecoration.Parent = this.inp_quantity;
            this.inp_quantity.Size = new System.Drawing.Size(262, 36);
            this.inp_quantity.TabIndex = 42;
            this.inp_quantity.TextChanged += new System.EventHandler(this.inp_quantity_TextChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_quantity.Location = new System.Drawing.Point(713, 306);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(124, 37);
            this.txt_quantity.TabIndex = 41;
            this.txt_quantity.Text = "SL Mua";
            this.txt_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_nameProduct
            // 
            this.inp_nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_nameProduct.Animated = true;
            this.inp_nameProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_nameProduct.BorderRadius = 6;
            this.inp_nameProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_nameProduct.DefaultText = "";
            this.inp_nameProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_nameProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_nameProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_nameProduct.DisabledState.Parent = this.inp_nameProduct;
            this.inp_nameProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_nameProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_nameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_nameProduct.FocusedState.Parent = this.inp_nameProduct;
            this.inp_nameProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_nameProduct.ForeColor = System.Drawing.Color.White;
            this.inp_nameProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_nameProduct.HoverState.Parent = this.inp_nameProduct;
            this.inp_nameProduct.Location = new System.Drawing.Point(848, 256);
            this.inp_nameProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_nameProduct.Name = "inp_nameProduct";
            this.inp_nameProduct.PasswordChar = '\0';
            this.inp_nameProduct.PlaceholderText = "";
            this.inp_nameProduct.ReadOnly = true;
            this.inp_nameProduct.SelectedText = "";
            this.inp_nameProduct.ShadowDecoration.Parent = this.inp_nameProduct;
            this.inp_nameProduct.Size = new System.Drawing.Size(262, 36);
            this.inp_nameProduct.TabIndex = 40;
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_nameProduct.Location = new System.Drawing.Point(712, 255);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(125, 37);
            this.txt_nameProduct.TabIndex = 39;
            this.txt_nameProduct.Text = "Tên sản phẩm";
            this.txt_nameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_product
            // 
            this.id_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id_product.Animated = true;
            this.id_product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.id_product.BorderRadius = 6;
            this.id_product.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_product.DefaultText = "";
            this.id_product.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_product.DisabledState.Parent = this.id_product;
            this.id_product.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_product.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.id_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_product.FocusedState.Parent = this.id_product;
            this.id_product.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.id_product.ForeColor = System.Drawing.Color.White;
            this.id_product.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_product.HoverState.Parent = this.id_product;
            this.id_product.Location = new System.Drawing.Point(848, 206);
            this.id_product.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.id_product.Name = "id_product";
            this.id_product.PasswordChar = '\0';
            this.id_product.PlaceholderText = "";
            this.id_product.ReadOnly = true;
            this.id_product.SelectedText = "";
            this.id_product.ShadowDecoration.Parent = this.id_product;
            this.id_product.Size = new System.Drawing.Size(262, 36);
            this.id_product.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(713, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_manufacturer
            // 
            this.cbb_manufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_manufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_manufacturer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.cbb_manufacturer.BorderRadius = 6;
            this.cbb_manufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_manufacturer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_manufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_manufacturer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_manufacturer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_manufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_manufacturer.FocusedState.Parent = this.cbb_manufacturer;
            this.cbb_manufacturer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_manufacturer.ForeColor = System.Drawing.Color.White;
            this.cbb_manufacturer.HoverState.Parent = this.cbb_manufacturer;
            this.cbb_manufacturer.ItemHeight = 30;
            this.cbb_manufacturer.ItemsAppearance.Parent = this.cbb_manufacturer;
            this.cbb_manufacturer.Location = new System.Drawing.Point(848, 157);
            this.cbb_manufacturer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbb_manufacturer.Name = "cbb_manufacturer";
            this.cbb_manufacturer.ShadowDecoration.Parent = this.cbb_manufacturer;
            this.cbb_manufacturer.Size = new System.Drawing.Size(262, 36);
            this.cbb_manufacturer.TabIndex = 36;
            this.cbb_manufacturer.SelectedIndexChanged += new System.EventHandler(this.cbb_manufacturer_SelectedIndexChanged);
            this.cbb_manufacturer.DropDownClosed += new System.EventHandler(this.eventDropClosed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(722, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hãng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_search
            // 
            this.inp_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.inp_search.Location = new System.Drawing.Point(336, 138);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(296, 36);
            this.inp_search.TabIndex = 24;
            this.inp_search.TextChanged += new System.EventHandler(this.inp_search_TextChanged);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_title.Location = new System.Drawing.Point(458, 67);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(148, 32);
            this.txt_title.TabIndex = 18;
            this.txt_title.Text = "Mua hàng";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1156, 846);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSell";
            this.Text = "Quản lý bán Laptop";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_avatarProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label txt_title;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_manufacturer;
        private Guna.UI2.WinForms.Guna2TextBox inp_total;
        private System.Windows.Forms.Label txt_total;
        private Guna.UI2.WinForms.Guna2TextBox inp_sales;
        private System.Windows.Forms.Label txt_sales;
        private Guna.UI2.WinForms.Guna2TextBox inp_unitPrice;
        private System.Windows.Forms.Label txt_unitPrice;
        private Guna.UI2.WinForms.Guna2TextBox inp_quantity;
        private System.Windows.Forms.Label txt_quantity;
        private Guna.UI2.WinForms.Guna2TextBox inp_nameProduct;
        private System.Windows.Forms.Label txt_nameProduct;
        private Guna.UI2.WinForms.Guna2TextBox id_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img_avatarProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_deleteProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_editProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addProduct;
        private Guna.UI2.WinForms.Guna2PictureBox icon_search;
        private Guna.UI2.WinForms.Guna2GradientButton btn_pay;
        private System.Windows.Forms.DataGridView tb_product;
        private System.Windows.Forms.Label error_sell;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.DataGridView tb_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}