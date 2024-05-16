namespace GUI
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idProduct = new System.Windows.Forms.Label();
            this.inp_idProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nameProduct = new System.Windows.Forms.Label();
            this.inp_nameProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_quantityProduct = new System.Windows.Forms.Label();
            this.inp_quantityProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_priceProduct = new System.Windows.Forms.Label();
            this.inp_priceProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_manu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_addProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_editProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_deleteProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_restartProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.img_product = new System.Windows.Forms.PictureBox();
            this.btn_chooseImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_search = new System.Windows.Forms.Label();
            this.inp_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.error_unitPrice = new System.Windows.Forms.Label();
            this.error_quantity = new System.Windows.Forms.Label();
            this.error_name = new System.Windows.Forms.Label();
            this.error_id = new System.Windows.Forms.Label();
            this.tb_product = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_product)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_title
            // 
            this.txt_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_title.Location = new System.Drawing.Point(458, 73);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(259, 32);
            this.txt_title.TabIndex = 56;
            this.txt_title.Text = "Quản lý sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Thông tin sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_idProduct
            // 
            this.txt_idProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_idProduct.Location = new System.Drawing.Point(22, 151);
            this.txt_idProduct.Name = "txt_idProduct";
            this.txt_idProduct.Size = new System.Drawing.Size(137, 37);
            this.txt_idProduct.TabIndex = 62;
            this.txt_idProduct.Text = "Mã sản phẩm";
            // 
            // inp_idProduct
            // 
            this.inp_idProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_idProduct.Animated = true;
            this.inp_idProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_idProduct.BorderRadius = 6;
            this.inp_idProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_idProduct.DefaultText = "";
            this.inp_idProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_idProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_idProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_idProduct.DisabledState.Parent = this.inp_idProduct;
            this.inp_idProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_idProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_idProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_idProduct.FocusedState.Parent = this.inp_idProduct;
            this.inp_idProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_idProduct.ForeColor = System.Drawing.Color.White;
            this.inp_idProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_idProduct.HoverState.Parent = this.inp_idProduct;
            this.inp_idProduct.Location = new System.Drawing.Point(155, 145);
            this.inp_idProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_idProduct.Name = "inp_idProduct";
            this.inp_idProduct.PasswordChar = '\0';
            this.inp_idProduct.PlaceholderText = "";
            this.inp_idProduct.SelectedText = "";
            this.inp_idProduct.ShadowDecoration.Parent = this.inp_idProduct;
            this.inp_idProduct.Size = new System.Drawing.Size(262, 36);
            this.inp_idProduct.TabIndex = 63;
            this.inp_idProduct.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txt_nameProduct
            // 
            this.txt_nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_nameProduct.Location = new System.Drawing.Point(19, 204);
            this.txt_nameProduct.Name = "txt_nameProduct";
            this.txt_nameProduct.Size = new System.Drawing.Size(137, 37);
            this.txt_nameProduct.TabIndex = 64;
            this.txt_nameProduct.Text = "Tên sản phẩm";
            // 
            // inp_nameProduct
            // 
            this.inp_nameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.inp_nameProduct.Location = new System.Drawing.Point(155, 198);
            this.inp_nameProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_nameProduct.Name = "inp_nameProduct";
            this.inp_nameProduct.PasswordChar = '\0';
            this.inp_nameProduct.PlaceholderText = "";
            this.inp_nameProduct.SelectedText = "";
            this.inp_nameProduct.ShadowDecoration.Parent = this.inp_nameProduct;
            this.inp_nameProduct.Size = new System.Drawing.Size(262, 36);
            this.inp_nameProduct.TabIndex = 65;
            // 
            // txt_quantityProduct
            // 
            this.txt_quantityProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantityProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_quantityProduct.Location = new System.Drawing.Point(17, 291);
            this.txt_quantityProduct.Name = "txt_quantityProduct";
            this.txt_quantityProduct.Size = new System.Drawing.Size(137, 37);
            this.txt_quantityProduct.TabIndex = 68;
            this.txt_quantityProduct.Text = "Số lượng";
            // 
            // inp_quantityProduct
            // 
            this.inp_quantityProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_quantityProduct.Animated = true;
            this.inp_quantityProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_quantityProduct.BorderRadius = 6;
            this.inp_quantityProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_quantityProduct.DefaultText = "";
            this.inp_quantityProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_quantityProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_quantityProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_quantityProduct.DisabledState.Parent = this.inp_quantityProduct;
            this.inp_quantityProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_quantityProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_quantityProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_quantityProduct.FocusedState.Parent = this.inp_quantityProduct;
            this.inp_quantityProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_quantityProduct.ForeColor = System.Drawing.Color.White;
            this.inp_quantityProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_quantityProduct.HoverState.Parent = this.inp_quantityProduct;
            this.inp_quantityProduct.Location = new System.Drawing.Point(153, 291);
            this.inp_quantityProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_quantityProduct.Name = "inp_quantityProduct";
            this.inp_quantityProduct.PasswordChar = '\0';
            this.inp_quantityProduct.PlaceholderText = "";
            this.inp_quantityProduct.SelectedText = "";
            this.inp_quantityProduct.ShadowDecoration.Parent = this.inp_quantityProduct;
            this.inp_quantityProduct.Size = new System.Drawing.Size(262, 36);
            this.inp_quantityProduct.TabIndex = 69;
            // 
            // txt_priceProduct
            // 
            this.txt_priceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_priceProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_priceProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_priceProduct.Location = new System.Drawing.Point(17, 339);
            this.txt_priceProduct.Name = "txt_priceProduct";
            this.txt_priceProduct.Size = new System.Drawing.Size(137, 37);
            this.txt_priceProduct.TabIndex = 70;
            this.txt_priceProduct.Text = "Giá bán";
            // 
            // inp_priceProduct
            // 
            this.inp_priceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inp_priceProduct.Animated = true;
            this.inp_priceProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.inp_priceProduct.BorderRadius = 6;
            this.inp_priceProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inp_priceProduct.DefaultText = "";
            this.inp_priceProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inp_priceProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inp_priceProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_priceProduct.DisabledState.Parent = this.inp_priceProduct;
            this.inp_priceProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inp_priceProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.inp_priceProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_priceProduct.FocusedState.Parent = this.inp_priceProduct;
            this.inp_priceProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inp_priceProduct.ForeColor = System.Drawing.Color.White;
            this.inp_priceProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inp_priceProduct.HoverState.Parent = this.inp_priceProduct;
            this.inp_priceProduct.Location = new System.Drawing.Point(153, 335);
            this.inp_priceProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_priceProduct.Name = "inp_priceProduct";
            this.inp_priceProduct.PasswordChar = '\0';
            this.inp_priceProduct.PlaceholderText = "";
            this.inp_priceProduct.SelectedText = "";
            this.inp_priceProduct.ShadowDecoration.Parent = this.inp_priceProduct;
            this.inp_priceProduct.Size = new System.Drawing.Size(262, 36);
            this.inp_priceProduct.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 37);
            this.label4.TabIndex = 72;
            this.label4.Text = "Hãng";
            // 
            // cbb_manu
            // 
            this.cbb_manu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_manu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_manu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.cbb_manu.BorderRadius = 6;
            this.cbb_manu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_manu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_manu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_manu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_manu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_manu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_manu.FocusedState.Parent = this.cbb_manu;
            this.cbb_manu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_manu.ForeColor = System.Drawing.Color.White;
            this.cbb_manu.HoverState.Parent = this.cbb_manu;
            this.cbb_manu.ItemHeight = 30;
            this.cbb_manu.ItemsAppearance.Parent = this.cbb_manu;
            this.cbb_manu.Location = new System.Drawing.Point(153, 382);
            this.cbb_manu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbb_manu.Name = "cbb_manu";
            this.cbb_manu.ShadowDecoration.Parent = this.cbb_manu;
            this.cbb_manu.Size = new System.Drawing.Size(262, 36);
            this.cbb_manu.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 37);
            this.label7.TabIndex = 74;
            this.label7.Text = "Loại";
            // 
            // cbb_type
            // 
            this.cbb_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.cbb_type.BorderRadius = 6;
            this.cbb_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_type.FocusedState.Parent = this.cbb_type;
            this.cbb_type.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbb_type.ForeColor = System.Drawing.Color.White;
            this.cbb_type.HoverState.Parent = this.cbb_type;
            this.cbb_type.ItemHeight = 30;
            this.cbb_type.ItemsAppearance.Parent = this.cbb_type;
            this.cbb_type.Location = new System.Drawing.Point(154, 247);
            this.cbb_type.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.ShadowDecoration.Parent = this.cbb_type;
            this.cbb_type.Size = new System.Drawing.Size(262, 36);
            this.cbb_type.TabIndex = 75;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addProduct.Animated = true;
            this.btn_addProduct.BorderRadius = 10;
            this.btn_addProduct.CheckedState.Parent = this.btn_addProduct;
            this.btn_addProduct.CustomImages.Parent = this.btn_addProduct;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.HoverState.Parent = this.btn_addProduct;
            this.btn_addProduct.Location = new System.Drawing.Point(58, 436);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.ShadowDecoration.Parent = this.btn_addProduct;
            this.btn_addProduct.Size = new System.Drawing.Size(96, 39);
            this.btn_addProduct.TabIndex = 76;
            this.btn_addProduct.Text = "Thêm";
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editProduct.Animated = true;
            this.btn_editProduct.BorderRadius = 10;
            this.btn_editProduct.CheckedState.Parent = this.btn_editProduct;
            this.btn_editProduct.CustomImages.Parent = this.btn_editProduct;
            this.btn_editProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_editProduct.ForeColor = System.Drawing.Color.White;
            this.btn_editProduct.HoverState.Parent = this.btn_editProduct;
            this.btn_editProduct.Location = new System.Drawing.Point(158, 436);
            this.btn_editProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.ShadowDecoration.Parent = this.btn_editProduct;
            this.btn_editProduct.Size = new System.Drawing.Size(96, 39);
            this.btn_editProduct.TabIndex = 77;
            this.btn_editProduct.Text = "Sửa";
            this.btn_editProduct.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteProduct.Animated = true;
            this.btn_deleteProduct.BorderRadius = 10;
            this.btn_deleteProduct.CheckedState.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.CustomImages.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteProduct.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProduct.HoverState.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Location = new System.Drawing.Point(260, 436);
            this.btn_deleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.ShadowDecoration.Parent = this.btn_deleteProduct;
            this.btn_deleteProduct.Size = new System.Drawing.Size(96, 39);
            this.btn_deleteProduct.TabIndex = 78;
            this.btn_deleteProduct.Text = "Xoá";
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_restartProduct
            // 
            this.btn_restartProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restartProduct.Animated = true;
            this.btn_restartProduct.BorderRadius = 10;
            this.btn_restartProduct.CheckedState.Parent = this.btn_restartProduct;
            this.btn_restartProduct.CustomImages.Parent = this.btn_restartProduct;
            this.btn_restartProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_restartProduct.ForeColor = System.Drawing.Color.White;
            this.btn_restartProduct.HoverState.Parent = this.btn_restartProduct;
            this.btn_restartProduct.Location = new System.Drawing.Point(362, 436);
            this.btn_restartProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restartProduct.Name = "btn_restartProduct";
            this.btn_restartProduct.ShadowDecoration.Parent = this.btn_restartProduct;
            this.btn_restartProduct.Size = new System.Drawing.Size(96, 39);
            this.btn_restartProduct.TabIndex = 79;
            this.btn_restartProduct.Text = "Làm mới";
            this.btn_restartProduct.Click += new System.EventHandler(this.btn_restartProduct_Click);
            // 
            // img_product
            // 
            this.img_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.img_product.BackColor = System.Drawing.SystemColors.Window;
            this.img_product.Location = new System.Drawing.Point(714, 134);
            this.img_product.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.img_product.Name = "img_product";
            this.img_product.Size = new System.Drawing.Size(253, 219);
            this.img_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_product.TabIndex = 81;
            this.img_product.TabStop = false;
            // 
            // btn_chooseImage
            // 
            this.btn_chooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chooseImage.Animated = true;
            this.btn_chooseImage.BorderRadius = 10;
            this.btn_chooseImage.CheckedState.Parent = this.btn_chooseImage;
            this.btn_chooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chooseImage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_chooseImage.CustomImages.Parent = this.btn_chooseImage;
            this.btn_chooseImage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_chooseImage.ForeColor = System.Drawing.Color.White;
            this.btn_chooseImage.HoverState.Parent = this.btn_chooseImage;
            this.btn_chooseImage.Location = new System.Drawing.Point(777, 371);
            this.btn_chooseImage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chooseImage.Name = "btn_chooseImage";
            this.btn_chooseImage.ShadowDecoration.Parent = this.btn_chooseImage;
            this.btn_chooseImage.Size = new System.Drawing.Size(130, 36);
            this.btn_chooseImage.TabIndex = 82;
            this.btn_chooseImage.Text = "Chọn ảnh";
            this.btn_chooseImage.Click += new System.EventHandler(this.btn_chooseImage_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_search.Location = new System.Drawing.Point(602, 436);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(92, 37);
            this.txt_search.TabIndex = 83;
            this.txt_search.Text = "Từ khoá";
            this.txt_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inp_search
            // 
            this.inp_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.inp_search.Location = new System.Drawing.Point(705, 437);
            this.inp_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inp_search.Name = "inp_search";
            this.inp_search.PasswordChar = '\0';
            this.inp_search.PlaceholderText = "";
            this.inp_search.SelectedText = "";
            this.inp_search.ShadowDecoration.Parent = this.inp_search;
            this.inp_search.Size = new System.Drawing.Size(262, 36);
            this.inp_search.TabIndex = 84;
            this.inp_search.TextChanged += new System.EventHandler(this.inp_search_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(17, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 27);
            this.label9.TabIndex = 85;
            this.label9.Text = "Danh sách sản phẩm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.Controls.Add(this.error_unitPrice);
            this.guna2Panel1.Controls.Add(this.error_quantity);
            this.guna2Panel1.Controls.Add(this.error_name);
            this.guna2Panel1.Controls.Add(this.error_id);
            this.guna2Panel1.Controls.Add(this.tb_product);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.inp_search);
            this.guna2Panel1.Controls.Add(this.txt_search);
            this.guna2Panel1.Controls.Add(this.btn_chooseImage);
            this.guna2Panel1.Controls.Add(this.img_product);
            this.guna2Panel1.Controls.Add(this.btn_restartProduct);
            this.guna2Panel1.Controls.Add(this.btn_deleteProduct);
            this.guna2Panel1.Controls.Add(this.btn_editProduct);
            this.guna2Panel1.Controls.Add(this.btn_addProduct);
            this.guna2Panel1.Controls.Add(this.cbb_type);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.cbb_manu);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.inp_priceProduct);
            this.guna2Panel1.Controls.Add(this.txt_priceProduct);
            this.guna2Panel1.Controls.Add(this.inp_quantityProduct);
            this.guna2Panel1.Controls.Add(this.txt_quantityProduct);
            this.guna2Panel1.Controls.Add(this.inp_nameProduct);
            this.guna2Panel1.Controls.Add(this.txt_nameProduct);
            this.guna2Panel1.Controls.Add(this.inp_idProduct);
            this.guna2Panel1.Controls.Add(this.txt_idProduct);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txt_title);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1136, 802);
            this.guna2Panel1.TabIndex = 1;
            // 
            // error_unitPrice
            // 
            this.error_unitPrice.AutoSize = true;
            this.error_unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_unitPrice.ForeColor = System.Drawing.Color.Red;
            this.error_unitPrice.Location = new System.Drawing.Point(428, 341);
            this.error_unitPrice.Name = "error_unitPrice";
            this.error_unitPrice.Size = new System.Drawing.Size(0, 22);
            this.error_unitPrice.TabIndex = 90;
            // 
            // error_quantity
            // 
            this.error_quantity.AutoSize = true;
            this.error_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_quantity.ForeColor = System.Drawing.Color.Red;
            this.error_quantity.Location = new System.Drawing.Point(428, 297);
            this.error_quantity.Name = "error_quantity";
            this.error_quantity.Size = new System.Drawing.Size(0, 22);
            this.error_quantity.TabIndex = 89;
            // 
            // error_name
            // 
            this.error_name.AutoSize = true;
            this.error_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_name.ForeColor = System.Drawing.Color.Red;
            this.error_name.Location = new System.Drawing.Point(428, 204);
            this.error_name.Name = "error_name";
            this.error_name.Size = new System.Drawing.Size(0, 22);
            this.error_name.TabIndex = 88;
            // 
            // error_id
            // 
            this.error_id.AutoSize = true;
            this.error_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_id.ForeColor = System.Drawing.Color.Red;
            this.error_id.Location = new System.Drawing.Point(428, 151);
            this.error_id.Name = "error_id";
            this.error_id.Size = new System.Drawing.Size(0, 22);
            this.error_id.TabIndex = 87;
            // 
            // tb_product
            // 
            this.tb_product.AllowUserToResizeColumns = false;
            this.tb_product.AllowUserToResizeRows = false;
            this.tb_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_product.Location = new System.Drawing.Point(23, 501);
            this.tb_product.Name = "tb_product";
            this.tb_product.ReadOnly = true;
            this.tb_product.RowHeadersVisible = false;
            this.tb_product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tb_product.RowTemplate.Height = 24;
            this.tb_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tb_product.Size = new System.Drawing.Size(1088, 279);
            this.tb_product.TabIndex = 86;
            this.tb_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventClickCell);
            this.tb_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_product_CellContentClick);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1136, 802);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Quản lý bán Laptop";
            ((System.ComponentModel.ISupportInitialize)(this.img_product)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox inp_search;
        private System.Windows.Forms.Label txt_search;
        private Guna.UI2.WinForms.Guna2GradientButton btn_chooseImage;
        private System.Windows.Forms.PictureBox img_product;
        private Guna.UI2.WinForms.Guna2GradientButton btn_restartProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_deleteProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_editProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btn_addProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_type;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_manu;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox inp_priceProduct;
        private System.Windows.Forms.Label txt_priceProduct;
        private Guna.UI2.WinForms.Guna2TextBox inp_quantityProduct;
        private System.Windows.Forms.Label txt_quantityProduct;
        private Guna.UI2.WinForms.Guna2TextBox inp_nameProduct;
        private System.Windows.Forms.Label txt_nameProduct;
        private Guna.UI2.WinForms.Guna2TextBox inp_idProduct;
        private System.Windows.Forms.Label txt_idProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.DataGridView tb_product;
        private System.Windows.Forms.Label error_unitPrice;
        private System.Windows.Forms.Label error_quantity;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label error_id;
    }
}