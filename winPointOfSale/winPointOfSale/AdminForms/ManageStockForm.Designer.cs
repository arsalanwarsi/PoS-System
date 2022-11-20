
namespace winPointOfSale.AdminForms
{
    partial class ManageStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStockForm));
            this.tabManageProduct = new MetroFramework.Controls.MetroTabPage();
            this.btnSearchProduct = new MetroFramework.Controls.MetroButton();
            this.btnUpdateProduct = new MetroFramework.Controls.MetroButton();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroButton();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.SearchProduct = new MetroFramework.Controls.MetroLabel();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.tabAddProduct = new MetroFramework.Controls.MetroTabPage();
            this.addNewProductPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSaveProduct = new MetroFramework.Controls.MetroButton();
            this.ProductName = new MetroFramework.Controls.MetroLabel();
            this.btnNewProduct = new MetroFramework.Controls.MetroButton();
            this.DateOfEntry = new MetroFramework.Controls.MetroLabel();
            this.txtSalePrice = new MetroFramework.Controls.MetroTextBox();
            this.Size = new MetroFramework.Controls.MetroLabel();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.cbSize = new MetroFramework.Controls.MetroComboBox();
            this.txtPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.PurchasePrice = new MetroFramework.Controls.MetroLabel();
            this.Category = new MetroFramework.Controls.MetroLabel();
            this.dtDateOfEntry = new MetroFramework.Controls.MetroDateTime();
            this.SalePrice = new MetroFramework.Controls.MetroLabel();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.tabManageStock = new MetroFramework.Controls.MetroTabControl();
            this.tabProductList = new MetroFramework.Controls.MetroTabPage();
            this.gvProductList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dtpListTo = new MetroFramework.Controls.MetroDateTime();
            this.ListTo = new MetroFramework.Controls.MetroLabel();
            this.dtpListFrom = new MetroFramework.Controls.MetroDateTime();
            this.ListFrom = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.tabManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.tabAddProduct.SuspendLayout();
            this.addNewProductPanel.SuspendLayout();
            this.tabManageStock.SuspendLayout();
            this.tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageProduct
            // 
            this.tabManageProduct.Controls.Add(this.btnSearchProduct);
            this.tabManageProduct.Controls.Add(this.btnUpdateProduct);
            this.tabManageProduct.Controls.Add(this.btnDeleteProduct);
            this.tabManageProduct.Controls.Add(this.gvProducts);
            this.tabManageProduct.Controls.Add(this.SearchProduct);
            this.tabManageProduct.Controls.Add(this.txtSearchProduct);
            this.tabManageProduct.HorizontalScrollbarBarColor = true;
            this.tabManageProduct.HorizontalScrollbarHighlightOnWheel = false;
            this.tabManageProduct.HorizontalScrollbarSize = 10;
            this.tabManageProduct.Location = new System.Drawing.Point(4, 38);
            this.tabManageProduct.Name = "tabManageProduct";
            this.tabManageProduct.Size = new System.Drawing.Size(713, 355);
            this.tabManageProduct.TabIndex = 3;
            this.tabManageProduct.Text = "Manage Product";
            this.tabManageProduct.VerticalScrollbarBarColor = true;
            this.tabManageProduct.VerticalScrollbarHighlightOnWheel = false;
            this.tabManageProduct.VerticalScrollbarSize = 10;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(561, 18);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(100, 35);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseCustomBackColor = true;
            this.btnSearchProduct.UseCustomForeColor = true;
            this.btnSearchProduct.UseSelectable = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(380, 308);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateProduct.TabIndex = 5;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseCustomBackColor = true;
            this.btnUpdateProduct.UseCustomForeColor = true;
            this.btnUpdateProduct.UseSelectable = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(233, 308);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseCustomBackColor = true;
            this.btnDeleteProduct.UseCustomForeColor = true;
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // gvProducts
            // 
            this.gvProducts.AllowUserToAddRows = false;
            this.gvProducts.AllowUserToDeleteRows = false;
            this.gvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(3, 70);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.ReadOnly = true;
            this.gvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts.Size = new System.Drawing.Size(707, 230);
            this.gvProducts.TabIndex = 3;
            this.gvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellClick);
            // 
            // SearchProduct
            // 
            this.SearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchProduct.AutoSize = true;
            this.SearchProduct.Location = new System.Drawing.Point(66, 26);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(101, 19);
            this.SearchProduct.TabIndex = 44;
            this.SearchProduct.Text = "Search Product:";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(193, 24);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Enter Name";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(328, 23);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Enter Name";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.Controls.Add(this.addNewProductPanel);
            this.tabAddProduct.HorizontalScrollbarBarColor = true;
            this.tabAddProduct.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddProduct.HorizontalScrollbarSize = 10;
            this.tabAddProduct.Location = new System.Drawing.Point(4, 38);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.Size = new System.Drawing.Size(713, 355);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "Add Product";
            this.tabAddProduct.VerticalScrollbarBarColor = true;
            this.tabAddProduct.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddProduct.VerticalScrollbarSize = 10;
            // 
            // addNewProductPanel
            // 
            this.addNewProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewProductPanel.Controls.Add(this.btnSaveProduct);
            this.addNewProductPanel.Controls.Add(this.ProductName);
            this.addNewProductPanel.Controls.Add(this.btnNewProduct);
            this.addNewProductPanel.Controls.Add(this.DateOfEntry);
            this.addNewProductPanel.Controls.Add(this.txtSalePrice);
            this.addNewProductPanel.Controls.Add(this.Size);
            this.addNewProductPanel.Controls.Add(this.cbCategory);
            this.addNewProductPanel.Controls.Add(this.cbSize);
            this.addNewProductPanel.Controls.Add(this.txtPurchasePrice);
            this.addNewProductPanel.Controls.Add(this.PurchasePrice);
            this.addNewProductPanel.Controls.Add(this.Category);
            this.addNewProductPanel.Controls.Add(this.dtDateOfEntry);
            this.addNewProductPanel.Controls.Add(this.SalePrice);
            this.addNewProductPanel.Controls.Add(this.txtProductName);
            this.addNewProductPanel.HorizontalScrollbarBarColor = true;
            this.addNewProductPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.addNewProductPanel.HorizontalScrollbarSize = 10;
            this.addNewProductPanel.Location = new System.Drawing.Point(3, 3);
            this.addNewProductPanel.Name = "addNewProductPanel";
            this.addNewProductPanel.Size = new System.Drawing.Size(707, 349);
            this.addNewProductPanel.TabIndex = 29;
            this.addNewProductPanel.VerticalScrollbarBarColor = true;
            this.addNewProductPanel.VerticalScrollbarHighlightOnWheel = false;
            this.addNewProductPanel.VerticalScrollbarSize = 10;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(416, 250);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(100, 35);
            this.btnSaveProduct.TabIndex = 7;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseCustomBackColor = true;
            this.btnSaveProduct.UseCustomForeColor = true;
            this.btnSaveProduct.UseSelectable = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // ProductName
            // 
            this.ProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(32, 91);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(98, 19);
            this.ProductName.TabIndex = 8;
            this.ProductName.Text = "Product Name:";
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(235, 250);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(100, 35);
            this.btnNewProduct.TabIndex = 8;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseCustomBackColor = true;
            this.btnNewProduct.UseCustomForeColor = true;
            this.btnNewProduct.UseSelectable = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // DateOfEntry
            // 
            this.DateOfEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateOfEntry.AutoSize = true;
            this.DateOfEntry.Location = new System.Drawing.Point(372, 169);
            this.DateOfEntry.Name = "DateOfEntry";
            this.DateOfEntry.Size = new System.Drawing.Size(92, 19);
            this.DateOfEntry.TabIndex = 15;
            this.DateOfEntry.Text = "Date Of Entry:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtSalePrice.CustomButton.Image = null;
            this.txtSalePrice.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtSalePrice.CustomButton.Name = "";
            this.txtSalePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalePrice.CustomButton.TabIndex = 1;
            this.txtSalePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalePrice.CustomButton.UseSelectable = true;
            this.txtSalePrice.CustomButton.Visible = false;
            this.txtSalePrice.Lines = new string[0];
            this.txtSalePrice.Location = new System.Drawing.Point(486, 126);
            this.txtSalePrice.MaxLength = 32767;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.PromptText = "Enter Sale Price";
            this.txtSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.SelectionLength = 0;
            this.txtSalePrice.SelectionStart = 0;
            this.txtSalePrice.ShortcutsEnabled = true;
            this.txtSalePrice.Size = new System.Drawing.Size(189, 23);
            this.txtSalePrice.TabIndex = 5;
            this.txtSalePrice.UseSelectable = true;
            this.txtSalePrice.WaterMark = "Enter Sale Price";
            this.txtSalePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Size
            // 
            this.Size.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(32, 176);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(35, 19);
            this.Size.TabIndex = 12;
            this.Size.Text = "Size:";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.cbCategory.Location = new System.Drawing.Point(146, 124);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.PromptText = "Select Category";
            this.cbCategory.Size = new System.Drawing.Size(189, 29);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.UseSelectable = true;
            // 
            // cbSize
            // 
            this.cbSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.ItemHeight = 23;
            this.cbSize.Location = new System.Drawing.Point(146, 166);
            this.cbSize.Name = "cbSize";
            this.cbSize.PromptText = "Select Size";
            this.cbSize.Size = new System.Drawing.Size(189, 29);
            this.cbSize.TabIndex = 3;
            this.cbSize.UseSelectable = true;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPurchasePrice.CustomButton.Image = null;
            this.txtPurchasePrice.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtPurchasePrice.CustomButton.Name = "";
            this.txtPurchasePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPurchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPurchasePrice.CustomButton.TabIndex = 1;
            this.txtPurchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPurchasePrice.CustomButton.UseSelectable = true;
            this.txtPurchasePrice.CustomButton.Visible = false;
            this.txtPurchasePrice.Lines = new string[0];
            this.txtPurchasePrice.Location = new System.Drawing.Point(486, 87);
            this.txtPurchasePrice.MaxLength = 32767;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PasswordChar = '\0';
            this.txtPurchasePrice.PromptText = "Enter Purchase Price";
            this.txtPurchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.SelectionLength = 0;
            this.txtPurchasePrice.SelectionStart = 0;
            this.txtPurchasePrice.ShortcutsEnabled = true;
            this.txtPurchasePrice.Size = new System.Drawing.Size(189, 23);
            this.txtPurchasePrice.TabIndex = 4;
            this.txtPurchasePrice.UseSelectable = true;
            this.txtPurchasePrice.WaterMark = "Enter Purchase Price";
            this.txtPurchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchasePrice.AutoSize = true;
            this.PurchasePrice.Location = new System.Drawing.Point(372, 87);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(97, 19);
            this.PurchasePrice.TabIndex = 19;
            this.PurchasePrice.Text = "Purchase Price:";
            // 
            // Category
            // 
            this.Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(32, 134);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(67, 19);
            this.Category.TabIndex = 10;
            this.Category.Text = "Category:";
            // 
            // dtDateOfEntry
            // 
            this.dtDateOfEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfEntry.Location = new System.Drawing.Point(486, 163);
            this.dtDateOfEntry.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtDateOfEntry.Name = "dtDateOfEntry";
            this.dtDateOfEntry.Size = new System.Drawing.Size(189, 29);
            this.dtDateOfEntry.TabIndex = 6;
            // 
            // SalePrice
            // 
            this.SalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalePrice.AutoSize = true;
            this.SalePrice.Location = new System.Drawing.Point(372, 126);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Size = new System.Drawing.Size(69, 19);
            this.SalePrice.TabIndex = 21;
            this.SalePrice.Text = "Sale Price:";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(146, 87);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PromptText = "Enter Product Name";
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(189, 23);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Enter Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabManageStock
            // 
            this.tabManageStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageStock.Controls.Add(this.tabAddProduct);
            this.tabManageStock.Controls.Add(this.tabManageProduct);
            this.tabManageStock.Controls.Add(this.tabProductList);
            this.tabManageStock.Location = new System.Drawing.Point(23, 63);
            this.tabManageStock.Name = "tabManageStock";
            this.tabManageStock.SelectedIndex = 2;
            this.tabManageStock.Size = new System.Drawing.Size(721, 397);
            this.tabManageStock.TabIndex = 0;
            this.tabManageStock.UseCustomBackColor = true;
            this.tabManageStock.UseCustomForeColor = true;
            this.tabManageStock.UseSelectable = true;
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.gvProductList);
            this.tabProductList.Controls.Add(this.btnSearch);
            this.tabProductList.Controls.Add(this.dtpListTo);
            this.tabProductList.Controls.Add(this.ListTo);
            this.tabProductList.Controls.Add(this.dtpListFrom);
            this.tabProductList.Controls.Add(this.ListFrom);
            this.tabProductList.HorizontalScrollbarBarColor = true;
            this.tabProductList.HorizontalScrollbarHighlightOnWheel = false;
            this.tabProductList.HorizontalScrollbarSize = 10;
            this.tabProductList.Location = new System.Drawing.Point(4, 38);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Size = new System.Drawing.Size(713, 355);
            this.tabProductList.TabIndex = 4;
            this.tabProductList.Text = "Product List";
            this.tabProductList.VerticalScrollbarBarColor = true;
            this.tabProductList.VerticalScrollbarHighlightOnWheel = false;
            this.tabProductList.VerticalScrollbarSize = 10;
            // 
            // gvProductList
            // 
            this.gvProductList.AllowUserToAddRows = false;
            this.gvProductList.AllowUserToDeleteRows = false;
            this.gvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductList.Location = new System.Drawing.Point(3, 81);
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.ReadOnly = true;
            this.gvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductList.Size = new System.Drawing.Size(707, 271);
            this.gvProductList.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(583, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpListTo
            // 
            this.dtpListTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpListTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpListTo.Location = new System.Drawing.Point(373, 24);
            this.dtpListTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpListTo.Name = "dtpListTo";
            this.dtpListTo.Size = new System.Drawing.Size(152, 29);
            this.dtpListTo.TabIndex = 2;
            // 
            // ListTo
            // 
            this.ListTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListTo.AutoSize = true;
            this.ListTo.Location = new System.Drawing.Point(305, 29);
            this.ListTo.Name = "ListTo";
            this.ListTo.Size = new System.Drawing.Size(47, 19);
            this.ListTo.TabIndex = 27;
            this.ListTo.Text = "List To:";
            // 
            // dtpListFrom
            // 
            this.dtpListFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpListFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpListFrom.Location = new System.Drawing.Point(110, 24);
            this.dtpListFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpListFrom.Name = "dtpListFrom";
            this.dtpListFrom.Size = new System.Drawing.Size(152, 29);
            this.dtpListFrom.TabIndex = 1;
            // 
            // ListFrom
            // 
            this.ListFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListFrom.AutoSize = true;
            this.ListFrom.Location = new System.Drawing.Point(28, 29);
            this.ListFrom.Name = "ListFrom";
            this.ListFrom.Size = new System.Drawing.Size(66, 19);
            this.ListFrom.TabIndex = 25;
            this.ListFrom.Text = "List From:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(644, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabManageStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageStockForm";
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.ManageStockForm_Load);
            this.tabManageProduct.ResumeLayout(false);
            this.tabManageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.tabAddProduct.ResumeLayout(false);
            this.addNewProductPanel.ResumeLayout(false);
            this.addNewProductPanel.PerformLayout();
            this.tabManageStock.ResumeLayout(false);
            this.tabProductList.ResumeLayout(false);
            this.tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabManageProduct;
        private MetroFramework.Controls.MetroTabPage tabAddProduct;
        private MetroFramework.Controls.MetroTabControl tabManageStock;
        private MetroFramework.Controls.MetroTabPage tabProductList;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel ProductName;
        private MetroFramework.Controls.MetroLabel DateOfEntry;
        private MetroFramework.Controls.MetroLabel Size;
        private MetroFramework.Controls.MetroComboBox cbSize;
        private MetroFramework.Controls.MetroLabel Category;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroLabel SalePrice;
        private MetroFramework.Controls.MetroLabel PurchasePrice;
        private MetroFramework.Controls.MetroTextBox txtSalePrice;
        private MetroFramework.Controls.MetroTextBox txtPurchasePrice;
        private MetroFramework.Controls.MetroDateTime dtDateOfEntry;
        private MetroFramework.Controls.MetroButton btnNewProduct;
        private MetroFramework.Controls.MetroButton btnSaveProduct;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel SearchProduct;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private System.Windows.Forms.DataGridView gvProducts;
        private MetroFramework.Controls.MetroButton btnDeleteProduct;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroDateTime dtpListTo;
        private MetroFramework.Controls.MetroLabel ListTo;
        private MetroFramework.Controls.MetroDateTime dtpListFrom;
        private MetroFramework.Controls.MetroLabel ListFrom;
        private System.Windows.Forms.DataGridView gvProductList;
        private MetroFramework.Controls.MetroPanel addNewProductPanel;
        private MetroFramework.Controls.MetroButton btnUpdateProduct;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
    }
}