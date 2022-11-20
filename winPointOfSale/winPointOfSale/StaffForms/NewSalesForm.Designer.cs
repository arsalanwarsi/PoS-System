
namespace winPointOfSale.StaffForms
{
    partial class NewSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSalesForm));
            this.gvShowSales = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSaveSales = new MetroFramework.Controls.MetroButton();
            this.btnNewSales = new MetroFramework.Controls.MetroButton();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.SalesList = new MetroFramework.Controls.MetroLabel();
            this.TotalPrice = new MetroFramework.Controls.MetroLabel();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.gvShowProducts = new System.Windows.Forms.DataGridView();
            this.txtSeachProduct = new MetroFramework.Controls.MetroTextBox();
            this.SearchProduct = new MetroFramework.Controls.MetroLabel();
            this.AddProductPanel = new MetroFramework.Controls.MetroPanel();
            this.SalesProductPanel = new MetroFramework.Controls.MetroPanel();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.ButtonPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSearchProduct = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowProducts)).BeginInit();
            this.AddProductPanel.SuspendLayout();
            this.SalesProductPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvShowSales
            // 
            this.gvShowSales.AllowUserToAddRows = false;
            this.gvShowSales.AllowUserToDeleteRows = false;
            this.gvShowSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowSales.Location = new System.Drawing.Point(59, 54);
            this.gvShowSales.Name = "gvShowSales";
            this.gvShowSales.ReadOnly = true;
            this.gvShowSales.RowHeadersVisible = false;
            this.gvShowSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowSales.Size = new System.Drawing.Size(331, 331);
            this.gvShowSales.TabIndex = 55;
            this.gvShowSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowSales_CellClick);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(3, 140);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(50, 35);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseCustomBackColor = true;
            this.btnDeleteProduct.UseCustomForeColor = true;
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(357, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveSales
            // 
            this.btnSaveSales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveSales.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveSales.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveSales.ForeColor = System.Drawing.Color.White;
            this.btnSaveSales.Location = new System.Drawing.Point(657, 3);
            this.btnSaveSales.Name = "btnSaveSales";
            this.btnSaveSales.Size = new System.Drawing.Size(100, 35);
            this.btnSaveSales.TabIndex = 4;
            this.btnSaveSales.Text = "Save Sales";
            this.btnSaveSales.UseCustomBackColor = true;
            this.btnSaveSales.UseCustomForeColor = true;
            this.btnSaveSales.UseSelectable = true;
            this.btnSaveSales.Click += new System.EventHandler(this.btnSaveSales_Click);
            // 
            // btnNewSales
            // 
            this.btnNewSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewSales.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewSales.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewSales.ForeColor = System.Drawing.Color.White;
            this.btnNewSales.Location = new System.Drawing.Point(60, 3);
            this.btnNewSales.Name = "btnNewSales";
            this.btnNewSales.Size = new System.Drawing.Size(100, 35);
            this.btnNewSales.TabIndex = 6;
            this.btnNewSales.Text = "New Sales";
            this.btnNewSales.UseCustomBackColor = true;
            this.btnNewSales.UseCustomForeColor = true;
            this.btnNewSales.UseSelectable = true;
            this.btnNewSales.Click += new System.EventHandler(this.btnNewSales_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[0];
            this.txtTotalPrice.Location = new System.Drawing.Point(195, 391);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(148, 23);
            this.txtTotalPrice.TabIndex = 63;
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalesList
            // 
            this.SalesList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalesList.AutoSize = true;
            this.SalesList.Location = new System.Drawing.Point(199, 2);
            this.SalesList.Name = "SalesList";
            this.SalesList.Size = new System.Drawing.Size(60, 19);
            this.SalesList.TabIndex = 64;
            this.SalesList.Text = "Sales List";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(112, 394);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(72, 19);
            this.TotalPrice.TabIndex = 65;
            this.TotalPrice.Text = "Total Price:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(346, 140);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(50, 35);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseCustomBackColor = true;
            this.btnAddProduct.UseCustomForeColor = true;
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gvShowProducts
            // 
            this.gvShowProducts.AllowUserToAddRows = false;
            this.gvShowProducts.AllowUserToDeleteRows = false;
            this.gvShowProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowProducts.Location = new System.Drawing.Point(5, 55);
            this.gvShowProducts.Name = "gvShowProducts";
            this.gvShowProducts.ReadOnly = true;
            this.gvShowProducts.RowHeadersVisible = false;
            this.gvShowProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowProducts.Size = new System.Drawing.Size(335, 330);
            this.gvShowProducts.TabIndex = 55;
            this.gvShowProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowProducts_CellClick);
            // 
            // txtSeachProduct
            // 
            this.txtSeachProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSeachProduct.CustomButton.Image = null;
            this.txtSeachProduct.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtSeachProduct.CustomButton.Name = "";
            this.txtSeachProduct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeachProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeachProduct.CustomButton.TabIndex = 1;
            this.txtSeachProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeachProduct.CustomButton.UseSelectable = true;
            this.txtSeachProduct.CustomButton.Visible = false;
            this.txtSeachProduct.Lines = new string[0];
            this.txtSeachProduct.Location = new System.Drawing.Point(57, 24);
            this.txtSeachProduct.MaxLength = 32767;
            this.txtSeachProduct.Name = "txtSeachProduct";
            this.txtSeachProduct.PasswordChar = '\0';
            this.txtSeachProduct.PromptText = "Enter Name";
            this.txtSeachProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeachProduct.SelectedText = "";
            this.txtSeachProduct.SelectionLength = 0;
            this.txtSeachProduct.SelectionStart = 0;
            this.txtSeachProduct.ShortcutsEnabled = true;
            this.txtSeachProduct.Size = new System.Drawing.Size(211, 23);
            this.txtSeachProduct.TabIndex = 1;
            this.txtSeachProduct.UseSelectable = true;
            this.txtSeachProduct.WaterMark = "Enter Name";
            this.txtSeachProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeachProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchProduct
            // 
            this.SearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchProduct.AutoSize = true;
            this.SearchProduct.Location = new System.Drawing.Point(108, -2);
            this.SearchProduct.Name = "SearchProduct";
            this.SearchProduct.Size = new System.Drawing.Size(101, 19);
            this.SearchProduct.TabIndex = 10;
            this.SearchProduct.Text = "Search Product:";
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddProductPanel.Controls.Add(this.btnSearchProduct);
            this.AddProductPanel.Controls.Add(this.SearchProduct);
            this.AddProductPanel.Controls.Add(this.txtSeachProduct);
            this.AddProductPanel.Controls.Add(this.gvShowProducts);
            this.AddProductPanel.Controls.Add(this.btnAddProduct);
            this.AddProductPanel.HorizontalScrollbarBarColor = true;
            this.AddProductPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.HorizontalScrollbarSize = 10;
            this.AddProductPanel.Location = new System.Drawing.Point(23, 63);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(399, 417);
            this.AddProductPanel.TabIndex = 66;
            this.AddProductPanel.VerticalScrollbarBarColor = true;
            this.AddProductPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.VerticalScrollbarSize = 10;
            // 
            // SalesProductPanel
            // 
            this.SalesProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesProductPanel.Controls.Add(this.txtInvoiceNo);
            this.SalesProductPanel.Controls.Add(this.TotalPrice);
            this.SalesProductPanel.Controls.Add(this.gvShowSales);
            this.SalesProductPanel.Controls.Add(this.txtTotalPrice);
            this.SalesProductPanel.Controls.Add(this.btnDeleteProduct);
            this.SalesProductPanel.Controls.Add(this.SalesList);
            this.SalesProductPanel.HorizontalScrollbarBarColor = true;
            this.SalesProductPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SalesProductPanel.HorizontalScrollbarSize = 10;
            this.SalesProductPanel.Location = new System.Drawing.Point(445, 63);
            this.SalesProductPanel.Name = "SalesProductPanel";
            this.SalesProductPanel.Size = new System.Drawing.Size(393, 417);
            this.SalesProductPanel.TabIndex = 67;
            this.SalesProductPanel.VerticalScrollbarBarColor = true;
            this.SalesProductPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SalesProductPanel.VerticalScrollbarSize = 10;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(141, 24);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PromptText = "Invoice Number";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(173, 23);
            this.txtInvoiceNo.TabIndex = 7;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMark = "Invoice Number";
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.Controls.Add(this.btnNewSales);
            this.ButtonPanel.Controls.Add(this.btnClose);
            this.ButtonPanel.Controls.Add(this.btnSaveSales);
            this.ButtonPanel.HorizontalScrollbarBarColor = true;
            this.ButtonPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ButtonPanel.HorizontalScrollbarSize = 10;
            this.ButtonPanel.Location = new System.Drawing.Point(23, 481);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(815, 41);
            this.ButtonPanel.TabIndex = 68;
            this.ButtonPanel.VerticalScrollbarBarColor = true;
            this.ButtonPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ButtonPanel.VerticalScrollbarSize = 10;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(291, 7);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(50, 35);
            this.btnSearchProduct.TabIndex = 56;
            this.btnSearchProduct.Text = "Seach";
            this.btnSearchProduct.UseCustomBackColor = true;
            this.btnSearchProduct.UseCustomForeColor = true;
            this.btnSearchProduct.UseSelectable = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // NewSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 544);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SalesProductPanel);
            this.Controls.Add(this.AddProductPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSalesForm";
            this.Text = "New Sales";
            this.Load += new System.EventHandler(this.NewSalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvShowSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowProducts)).EndInit();
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.SalesProductPanel.ResumeLayout(false);
            this.SalesProductPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvShowSales;
        private MetroFramework.Controls.MetroButton btnDeleteProduct;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSaveSales;
        private MetroFramework.Controls.MetroButton btnNewSales;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private MetroFramework.Controls.MetroLabel SalesList;
        private MetroFramework.Controls.MetroLabel TotalPrice;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private System.Windows.Forms.DataGridView gvShowProducts;
        private MetroFramework.Controls.MetroTextBox txtSeachProduct;
        private MetroFramework.Controls.MetroLabel SearchProduct;
        private MetroFramework.Controls.MetroPanel AddProductPanel;
        private MetroFramework.Controls.MetroPanel SalesProductPanel;
        private MetroFramework.Controls.MetroPanel ButtonPanel;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
    }
}