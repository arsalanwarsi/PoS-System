
namespace winPointOfSale.StaffForms
{
    partial class CustomerSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSalesForm));
            this.TotalProducts = new MetroFramework.Controls.MetroLabel();
            this.txtTotalProducts = new MetroFramework.Controls.MetroTextBox();
            this.AddProductPanel = new MetroFramework.Controls.MetroPanel();
            this.txtSeachCustomer = new MetroFramework.Controls.MetroTextBox();
            this.SearchCustomer = new MetroFramework.Controls.MetroLabel();
            this.gvShowCustomer = new System.Windows.Forms.DataGridView();
            this.btnSelectCustomer = new MetroFramework.Controls.MetroButton();
            this.txtTotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.TotalPrice = new MetroFramework.Controls.MetroLabel();
            this.PurchaseDate = new MetroFramework.Controls.MetroLabel();
            this.dtPurchaseDate = new MetroFramework.Controls.MetroDateTime();
            this.btnSaveSales = new MetroFramework.Controls.MetroButton();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.CustomerName = new MetroFramework.Controls.MetroLabel();
            this.txtInvoiceNumber = new MetroFramework.Controls.MetroTextBox();
            this.InvoiceNumber = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.AddProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCustomer)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalProducts
            // 
            this.TotalProducts.AutoSize = true;
            this.TotalProducts.Location = new System.Drawing.Point(2, 123);
            this.TotalProducts.Name = "TotalProducts";
            this.TotalProducts.Size = new System.Drawing.Size(94, 19);
            this.TotalProducts.TabIndex = 0;
            this.TotalProducts.Text = "Total Products:";
            // 
            // txtTotalProducts
            // 
            // 
            // 
            // 
            this.txtTotalProducts.CustomButton.Image = null;
            this.txtTotalProducts.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtTotalProducts.CustomButton.Name = "";
            this.txtTotalProducts.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalProducts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalProducts.CustomButton.TabIndex = 1;
            this.txtTotalProducts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalProducts.CustomButton.UseSelectable = true;
            this.txtTotalProducts.CustomButton.Visible = false;
            this.txtTotalProducts.Lines = new string[0];
            this.txtTotalProducts.Location = new System.Drawing.Point(115, 121);
            this.txtTotalProducts.MaxLength = 32767;
            this.txtTotalProducts.Name = "txtTotalProducts";
            this.txtTotalProducts.PasswordChar = '\0';
            this.txtTotalProducts.PromptText = "Total Products";
            this.txtTotalProducts.ReadOnly = true;
            this.txtTotalProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalProducts.SelectedText = "";
            this.txtTotalProducts.SelectionLength = 0;
            this.txtTotalProducts.SelectionStart = 0;
            this.txtTotalProducts.ShortcutsEnabled = true;
            this.txtTotalProducts.Size = new System.Drawing.Size(177, 23);
            this.txtTotalProducts.TabIndex = 1;
            this.txtTotalProducts.UseSelectable = true;
            this.txtTotalProducts.WaterMark = "Total Products";
            this.txtTotalProducts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalProducts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddProductPanel.Controls.Add(this.txtSeachCustomer);
            this.AddProductPanel.Controls.Add(this.SearchCustomer);
            this.AddProductPanel.Controls.Add(this.gvShowCustomer);
            this.AddProductPanel.HorizontalScrollbarBarColor = true;
            this.AddProductPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.HorizontalScrollbarSize = 10;
            this.AddProductPanel.Location = new System.Drawing.Point(23, 63);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(249, 273);
            this.AddProductPanel.TabIndex = 67;
            this.AddProductPanel.VerticalScrollbarBarColor = true;
            this.AddProductPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.VerticalScrollbarSize = 10;
            // 
            // txtSeachCustomer
            // 
            this.txtSeachCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSeachCustomer.CustomButton.Image = null;
            this.txtSeachCustomer.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtSeachCustomer.CustomButton.Name = "";
            this.txtSeachCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeachCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeachCustomer.CustomButton.TabIndex = 1;
            this.txtSeachCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeachCustomer.CustomButton.UseSelectable = true;
            this.txtSeachCustomer.CustomButton.Visible = false;
            this.txtSeachCustomer.Lines = new string[0];
            this.txtSeachCustomer.Location = new System.Drawing.Point(18, 30);
            this.txtSeachCustomer.MaxLength = 32767;
            this.txtSeachCustomer.Name = "txtSeachCustomer";
            this.txtSeachCustomer.PasswordChar = '\0';
            this.txtSeachCustomer.PromptText = "Enter Customer Name";
            this.txtSeachCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeachCustomer.SelectedText = "";
            this.txtSeachCustomer.SelectionLength = 0;
            this.txtSeachCustomer.SelectionStart = 0;
            this.txtSeachCustomer.ShortcutsEnabled = true;
            this.txtSeachCustomer.Size = new System.Drawing.Size(214, 23);
            this.txtSeachCustomer.TabIndex = 1;
            this.txtSeachCustomer.UseSelectable = true;
            this.txtSeachCustomer.WaterMark = "Enter Customer Name";
            this.txtSeachCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeachCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSeachCustomer.TextChanged += new System.EventHandler(this.txtSeachCustomer_TextChanged);
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchCustomer.AutoSize = true;
            this.SearchCustomer.Location = new System.Drawing.Point(69, 4);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(113, 19);
            this.SearchCustomer.TabIndex = 10;
            this.SearchCustomer.Text = "Search Customer:";
            // 
            // gvShowCustomer
            // 
            this.gvShowCustomer.AllowUserToAddRows = false;
            this.gvShowCustomer.AllowUserToDeleteRows = false;
            this.gvShowCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvShowCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShowCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShowCustomer.Location = new System.Drawing.Point(4, 59);
            this.gvShowCustomer.Name = "gvShowCustomer";
            this.gvShowCustomer.ReadOnly = true;
            this.gvShowCustomer.RowHeadersVisible = false;
            this.gvShowCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShowCustomer.Size = new System.Drawing.Size(242, 211);
            this.gvShowCustomer.TabIndex = 14;
            this.gvShowCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvShowCustomer_CellContentClick);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSelectCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSelectCustomer.Location = new System.Drawing.Point(74, 5);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(103, 35);
            this.btnSelectCustomer.TabIndex = 2;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseCustomBackColor = true;
            this.btnSelectCustomer.UseCustomForeColor = true;
            this.btnSelectCustomer.UseSelectable = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // txtTotalPrice
            // 
            // 
            // 
            // 
            this.txtTotalPrice.CustomButton.Image = null;
            this.txtTotalPrice.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtTotalPrice.CustomButton.Name = "";
            this.txtTotalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPrice.CustomButton.TabIndex = 1;
            this.txtTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPrice.CustomButton.UseSelectable = true;
            this.txtTotalPrice.CustomButton.Visible = false;
            this.txtTotalPrice.Lines = new string[0];
            this.txtTotalPrice.Location = new System.Drawing.Point(115, 154);
            this.txtTotalPrice.MaxLength = 32767;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PromptText = "Total Price";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.SelectionLength = 0;
            this.txtTotalPrice.SelectionStart = 0;
            this.txtTotalPrice.ShortcutsEnabled = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(177, 23);
            this.txtTotalPrice.TabIndex = 69;
            this.txtTotalPrice.UseSelectable = true;
            this.txtTotalPrice.WaterMark = "Total Price";
            this.txtTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(2, 156);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(72, 19);
            this.TotalPrice.TabIndex = 68;
            this.TotalPrice.Text = "Total Price:";
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AutoSize = true;
            this.PurchaseDate.Location = new System.Drawing.Point(2, 189);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(95, 19);
            this.PurchaseDate.TabIndex = 70;
            this.PurchaseDate.Text = "Purchase Date:";
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPurchaseDate.Location = new System.Drawing.Point(115, 185);
            this.dtPurchaseDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(177, 25);
            this.dtPurchaseDate.TabIndex = 71;
            // 
            // btnSaveSales
            // 
            this.btnSaveSales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveSales.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveSales.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveSales.ForeColor = System.Drawing.Color.White;
            this.btnSaveSales.Location = new System.Drawing.Point(383, 5);
            this.btnSaveSales.Name = "btnSaveSales";
            this.btnSaveSales.Size = new System.Drawing.Size(100, 35);
            this.btnSaveSales.TabIndex = 3;
            this.btnSaveSales.Text = "Save Sales";
            this.btnSaveSales.UseCustomBackColor = true;
            this.btnSaveSales.UseCustomForeColor = true;
            this.btnSaveSales.UseSelectable = true;
            this.btnSaveSales.Click += new System.EventHandler(this.btnSaveSales_Click);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(115, 87);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Customer Name";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(177, 23);
            this.txtCustomerName.TabIndex = 74;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Customer Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(2, 89);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(109, 19);
            this.CustomerName.TabIndex = 73;
            this.CustomerName.Text = "Customer Name:";
            // 
            // txtInvoiceNumber
            // 
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = null;
            this.txtInvoiceNumber.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = 1;
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            this.txtInvoiceNumber.CustomButton.Visible = false;
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.Location = new System.Drawing.Point(115, 53);
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.PromptText = "Invoice Number";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(177, 23);
            this.txtInvoiceNumber.TabIndex = 4;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMark = "Invoice Number";
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.AutoSize = true;
            this.InvoiceNumber.Location = new System.Drawing.Point(2, 55);
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.Size = new System.Drawing.Size(106, 19);
            this.InvoiceNumber.TabIndex = 75;
            this.InvoiceNumber.Text = "Invoice Number:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtInvoiceNumber);
            this.metroPanel1.Controls.Add(this.InvoiceNumber);
            this.metroPanel1.Controls.Add(this.txtCustomerName);
            this.metroPanel1.Controls.Add(this.TotalProducts);
            this.metroPanel1.Controls.Add(this.CustomerName);
            this.metroPanel1.Controls.Add(this.txtTotalProducts);
            this.metroPanel1.Controls.Add(this.TotalPrice);
            this.metroPanel1.Controls.Add(this.dtPurchaseDate);
            this.metroPanel1.Controls.Add(this.txtTotalPrice);
            this.metroPanel1.Controls.Add(this.PurchaseDate);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(278, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(295, 273);
            this.metroPanel1.TabIndex = 77;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.btnSaveSales);
            this.metroPanel2.Controls.Add(this.btnSelectCustomer);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 342);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(550, 43);
            this.metroPanel2.TabIndex = 78;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // CustomerSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 408);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.AddProductPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerSalesForm";
            this.Resizable = false;
            this.Text = "Customer Sales";
            this.Load += new System.EventHandler(this.CustomerSalesForm_Load);
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShowCustomer)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel TotalProducts;
        private MetroFramework.Controls.MetroTextBox txtTotalProducts;
        private MetroFramework.Controls.MetroPanel AddProductPanel;
        private MetroFramework.Controls.MetroLabel SearchCustomer;
        private System.Windows.Forms.DataGridView gvShowCustomer;
        private MetroFramework.Controls.MetroButton btnSelectCustomer;
        private MetroFramework.Controls.MetroTextBox txtTotalPrice;
        private MetroFramework.Controls.MetroLabel TotalPrice;
        private MetroFramework.Controls.MetroLabel PurchaseDate;
        private MetroFramework.Controls.MetroDateTime dtPurchaseDate;
        private MetroFramework.Controls.MetroButton btnSaveSales;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel CustomerName;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private MetroFramework.Controls.MetroLabel InvoiceNumber;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtSeachCustomer;
    }
}