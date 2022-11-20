
namespace winPointOfSale.StaffForms
{
    partial class CustomerServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerServiceForm));
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.tabCustomerService = new MetroFramework.Controls.MetroTabControl();
            this.tabReturnProduct = new MetroFramework.Controls.MetroTabPage();
            this.btnInvoiceSearch = new MetroFramework.Controls.MetroButton();
            this.btnSaveSales = new MetroFramework.Controls.MetroButton();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroButton();
            this.gvDeleteProduct = new System.Windows.Forms.DataGridView();
            this.SearchInvoice = new MetroFramework.Controls.MetroLabel();
            this.txtSearchInvoice = new MetroFramework.Controls.MetroTextBox();
            this.tabUpdateDetails = new MetroFramework.Controls.MetroTabPage();
            this.UpdateDetailsPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSaveDetails = new MetroFramework.Controls.MetroButton();
            this.btnSearchCustomer = new MetroFramework.Controls.MetroButton();
            this.gvUpdateDetails = new System.Windows.Forms.DataGridView();
            this.SearchCustomer = new MetroFramework.Controls.MetroLabel();
            this.txtSearchCustomer = new MetroFramework.Controls.MetroTextBox();
            this.btnEditNew = new MetroFramework.Controls.MetroButton();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.CustomerName = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.Address = new MetroFramework.Controls.MetroLabel();
            this.tabCustomerService.SuspendLayout();
            this.tabReturnProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteProduct)).BeginInit();
            this.tabUpdateDetails.SuspendLayout();
            this.UpdateDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdateDetails)).BeginInit();
            this.SuspendLayout();
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
            // tabCustomerService
            // 
            this.tabCustomerService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCustomerService.Controls.Add(this.tabReturnProduct);
            this.tabCustomerService.Controls.Add(this.tabUpdateDetails);
            this.tabCustomerService.Location = new System.Drawing.Point(23, 63);
            this.tabCustomerService.Name = "tabCustomerService";
            this.tabCustomerService.SelectedIndex = 1;
            this.tabCustomerService.Size = new System.Drawing.Size(721, 397);
            this.tabCustomerService.TabIndex = 31;
            this.tabCustomerService.UseCustomBackColor = true;
            this.tabCustomerService.UseCustomForeColor = true;
            this.tabCustomerService.UseSelectable = true;
            // 
            // tabReturnProduct
            // 
            this.tabReturnProduct.Controls.Add(this.btnInvoiceSearch);
            this.tabReturnProduct.Controls.Add(this.btnSaveSales);
            this.tabReturnProduct.Controls.Add(this.btnDeleteProduct);
            this.tabReturnProduct.Controls.Add(this.gvDeleteProduct);
            this.tabReturnProduct.Controls.Add(this.SearchInvoice);
            this.tabReturnProduct.Controls.Add(this.txtSearchInvoice);
            this.tabReturnProduct.HorizontalScrollbarBarColor = true;
            this.tabReturnProduct.HorizontalScrollbarHighlightOnWheel = false;
            this.tabReturnProduct.HorizontalScrollbarSize = 10;
            this.tabReturnProduct.Location = new System.Drawing.Point(4, 38);
            this.tabReturnProduct.Name = "tabReturnProduct";
            this.tabReturnProduct.Size = new System.Drawing.Size(713, 355);
            this.tabReturnProduct.TabIndex = 4;
            this.tabReturnProduct.Text = "ReturnProduct";
            this.tabReturnProduct.VerticalScrollbarBarColor = true;
            this.tabReturnProduct.VerticalScrollbarHighlightOnWheel = false;
            this.tabReturnProduct.VerticalScrollbarSize = 10;
            // 
            // btnInvoiceSearch
            // 
            this.btnInvoiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInvoiceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInvoiceSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnInvoiceSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnInvoiceSearch.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceSearch.Location = new System.Drawing.Point(554, 17);
            this.btnInvoiceSearch.Name = "btnInvoiceSearch";
            this.btnInvoiceSearch.Size = new System.Drawing.Size(100, 35);
            this.btnInvoiceSearch.TabIndex = 2;
            this.btnInvoiceSearch.Text = "Search";
            this.btnInvoiceSearch.UseCustomBackColor = true;
            this.btnInvoiceSearch.UseCustomForeColor = true;
            this.btnInvoiceSearch.UseSelectable = true;
            this.btnInvoiceSearch.Click += new System.EventHandler(this.btnInvoiceSearch_Click);
            // 
            // btnSaveSales
            // 
            this.btnSaveSales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveSales.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveSales.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveSales.ForeColor = System.Drawing.Color.White;
            this.btnSaveSales.Location = new System.Drawing.Point(383, 311);
            this.btnSaveSales.Name = "btnSaveSales";
            this.btnSaveSales.Size = new System.Drawing.Size(100, 35);
            this.btnSaveSales.TabIndex = 5;
            this.btnSaveSales.Text = "Save Sales";
            this.btnSaveSales.UseCustomBackColor = true;
            this.btnSaveSales.UseCustomForeColor = true;
            this.btnSaveSales.UseSelectable = true;
            this.btnSaveSales.Click += new System.EventHandler(this.btnSaveSales_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDeleteProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(228, 311);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseCustomBackColor = true;
            this.btnDeleteProduct.UseCustomForeColor = true;
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // gvDeleteProduct
            // 
            this.gvDeleteProduct.AllowUserToAddRows = false;
            this.gvDeleteProduct.AllowUserToDeleteRows = false;
            this.gvDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDeleteProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDeleteProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDeleteProduct.Location = new System.Drawing.Point(3, 66);
            this.gvDeleteProduct.Name = "gvDeleteProduct";
            this.gvDeleteProduct.ReadOnly = true;
            this.gvDeleteProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDeleteProduct.Size = new System.Drawing.Size(707, 237);
            this.gvDeleteProduct.TabIndex = 3;
            this.gvDeleteProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDeleteProduct_CellClick);
            // 
            // SearchInvoice
            // 
            this.SearchInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchInvoice.AutoSize = true;
            this.SearchInvoice.Location = new System.Drawing.Point(61, 26);
            this.SearchInvoice.Name = "SearchInvoice";
            this.SearchInvoice.Size = new System.Drawing.Size(95, 19);
            this.SearchInvoice.TabIndex = 49;
            this.SearchInvoice.Text = "Search Invoive:";
            // 
            // txtSearchInvoice
            // 
            this.txtSearchInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchInvoice.CustomButton.Image = null;
            this.txtSearchInvoice.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtSearchInvoice.CustomButton.Name = "";
            this.txtSearchInvoice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchInvoice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchInvoice.CustomButton.TabIndex = 1;
            this.txtSearchInvoice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchInvoice.CustomButton.UseSelectable = true;
            this.txtSearchInvoice.CustomButton.Visible = false;
            this.txtSearchInvoice.Lines = new string[0];
            this.txtSearchInvoice.Location = new System.Drawing.Point(189, 24);
            this.txtSearchInvoice.MaxLength = 32767;
            this.txtSearchInvoice.Name = "txtSearchInvoice";
            this.txtSearchInvoice.PasswordChar = '\0';
            this.txtSearchInvoice.PromptText = "Search Invoice Number";
            this.txtSearchInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchInvoice.SelectedText = "";
            this.txtSearchInvoice.SelectionLength = 0;
            this.txtSearchInvoice.SelectionStart = 0;
            this.txtSearchInvoice.ShortcutsEnabled = true;
            this.txtSearchInvoice.Size = new System.Drawing.Size(328, 23);
            this.txtSearchInvoice.TabIndex = 1;
            this.txtSearchInvoice.UseSelectable = true;
            this.txtSearchInvoice.WaterMark = "Search Invoice Number";
            this.txtSearchInvoice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchInvoice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabUpdateDetails
            // 
            this.tabUpdateDetails.Controls.Add(this.UpdateDetailsPanel);
            this.tabUpdateDetails.HorizontalScrollbarBarColor = true;
            this.tabUpdateDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.tabUpdateDetails.HorizontalScrollbarSize = 10;
            this.tabUpdateDetails.Location = new System.Drawing.Point(4, 38);
            this.tabUpdateDetails.Name = "tabUpdateDetails";
            this.tabUpdateDetails.Size = new System.Drawing.Size(713, 355);
            this.tabUpdateDetails.TabIndex = 0;
            this.tabUpdateDetails.Text = "Update Details";
            this.tabUpdateDetails.VerticalScrollbarBarColor = true;
            this.tabUpdateDetails.VerticalScrollbarHighlightOnWheel = false;
            this.tabUpdateDetails.VerticalScrollbarSize = 10;
            // 
            // UpdateDetailsPanel
            // 
            this.UpdateDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDetailsPanel.Controls.Add(this.btnSaveDetails);
            this.UpdateDetailsPanel.Controls.Add(this.btnSearchCustomer);
            this.UpdateDetailsPanel.Controls.Add(this.gvUpdateDetails);
            this.UpdateDetailsPanel.Controls.Add(this.SearchCustomer);
            this.UpdateDetailsPanel.Controls.Add(this.txtSearchCustomer);
            this.UpdateDetailsPanel.Controls.Add(this.btnEditNew);
            this.UpdateDetailsPanel.Controls.Add(this.txtPhoneNo);
            this.UpdateDetailsPanel.Controls.Add(this.txtAddress);
            this.UpdateDetailsPanel.Controls.Add(this.CustomerName);
            this.UpdateDetailsPanel.Controls.Add(this.txtCustomerName);
            this.UpdateDetailsPanel.Controls.Add(this.PhoneNo);
            this.UpdateDetailsPanel.Controls.Add(this.Address);
            this.UpdateDetailsPanel.HorizontalScrollbarBarColor = true;
            this.UpdateDetailsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.UpdateDetailsPanel.HorizontalScrollbarSize = 10;
            this.UpdateDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.UpdateDetailsPanel.Name = "UpdateDetailsPanel";
            this.UpdateDetailsPanel.Size = new System.Drawing.Size(713, 355);
            this.UpdateDetailsPanel.TabIndex = 28;
            this.UpdateDetailsPanel.VerticalScrollbarBarColor = true;
            this.UpdateDetailsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.UpdateDetailsPanel.VerticalScrollbarSize = 10;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveDetails.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveDetails.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetails.Location = new System.Drawing.Point(383, 311);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(100, 35);
            this.btnSaveDetails.TabIndex = 8;
            this.btnSaveDetails.Text = "Save Details";
            this.btnSaveDetails.UseCustomBackColor = true;
            this.btnSaveDetails.UseCustomForeColor = true;
            this.btnSaveDetails.UseSelectable = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(554, 17);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(100, 35);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseCustomBackColor = true;
            this.btnSearchCustomer.UseCustomForeColor = true;
            this.btnSearchCustomer.UseSelectable = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // gvUpdateDetails
            // 
            this.gvUpdateDetails.AllowUserToAddRows = false;
            this.gvUpdateDetails.AllowUserToDeleteRows = false;
            this.gvUpdateDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gvUpdateDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUpdateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUpdateDetails.Location = new System.Drawing.Point(3, 67);
            this.gvUpdateDetails.Name = "gvUpdateDetails";
            this.gvUpdateDetails.ReadOnly = true;
            this.gvUpdateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUpdateDetails.Size = new System.Drawing.Size(707, 139);
            this.gvUpdateDetails.TabIndex = 3;
            this.gvUpdateDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUpdateDetails_CellClick);
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchCustomer.AutoSize = true;
            this.SearchCustomer.Location = new System.Drawing.Point(61, 26);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(113, 19);
            this.SearchCustomer.TabIndex = 54;
            this.SearchCustomer.Text = "Search Customer:";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchCustomer.CustomButton.Image = null;
            this.txtSearchCustomer.CustomButton.Location = new System.Drawing.Point(306, 1);
            this.txtSearchCustomer.CustomButton.Name = "";
            this.txtSearchCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCustomer.CustomButton.TabIndex = 1;
            this.txtSearchCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCustomer.CustomButton.UseSelectable = true;
            this.txtSearchCustomer.CustomButton.Visible = false;
            this.txtSearchCustomer.Lines = new string[0];
            this.txtSearchCustomer.Location = new System.Drawing.Point(189, 24);
            this.txtSearchCustomer.MaxLength = 32767;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PromptText = "Search Customer Name";
            this.txtSearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.SelectionLength = 0;
            this.txtSearchCustomer.SelectionStart = 0;
            this.txtSearchCustomer.ShortcutsEnabled = true;
            this.txtSearchCustomer.Size = new System.Drawing.Size(328, 23);
            this.txtSearchCustomer.TabIndex = 1;
            this.txtSearchCustomer.UseSelectable = true;
            this.txtSearchCustomer.WaterMark = "Search Customer Name";
            this.txtSearchCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEditNew
            // 
            this.btnEditNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditNew.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEditNew.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEditNew.ForeColor = System.Drawing.Color.White;
            this.btnEditNew.Location = new System.Drawing.Point(228, 311);
            this.btnEditNew.Name = "btnEditNew";
            this.btnEditNew.Size = new System.Drawing.Size(100, 35);
            this.btnEditNew.TabIndex = 7;
            this.btnEditNew.Text = "Edit New";
            this.btnEditNew.UseCustomBackColor = true;
            this.btnEditNew.UseCustomForeColor = true;
            this.btnEditNew.UseSelectable = true;
            this.btnEditNew.Click += new System.EventHandler(this.btnEditNew_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtPhoneNo.CustomButton.Image = null;
            this.txtPhoneNo.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtPhoneNo.CustomButton.Name = "";
            this.txtPhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNo.CustomButton.TabIndex = 1;
            this.txtPhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNo.CustomButton.UseSelectable = true;
            this.txtPhoneNo.CustomButton.Visible = false;
            this.txtPhoneNo.Lines = new string[0];
            this.txtPhoneNo.Location = new System.Drawing.Point(150, 263);
            this.txtPhoneNo.MaxLength = 32767;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PromptText = "Enter Phone Number";
            this.txtPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.SelectionLength = 0;
            this.txtPhoneNo.SelectionStart = 0;
            this.txtPhoneNo.ShortcutsEnabled = true;
            this.txtPhoneNo.Size = new System.Drawing.Size(189, 23);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.UseSelectable = true;
            this.txtPhoneNo.WaterMark = "Enter Phone Number";
            this.txtPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(488, 222);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Enter Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(189, 64);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Enter Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(36, 226);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(109, 19);
            this.CustomerName.TabIndex = 8;
            this.CustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(150, 222);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Enter Customer Name";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(189, 23);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Enter Customer Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneNo
            // 
            this.PhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Location = new System.Drawing.Point(36, 263);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(74, 19);
            this.PhoneNo.TabIndex = 21;
            this.PhoneNo.Text = "Phone No.:";
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(402, 226);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(59, 19);
            this.Address.TabIndex = 19;
            this.Address.Text = "Address:";
            // 
            // CustomerServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabCustomerService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerServiceForm";
            this.Text = "Customer Service";
            this.Load += new System.EventHandler(this.CustomerServiceForm_Load);
            this.tabCustomerService.ResumeLayout(false);
            this.tabReturnProduct.ResumeLayout(false);
            this.tabReturnProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteProduct)).EndInit();
            this.tabUpdateDetails.ResumeLayout(false);
            this.UpdateDetailsPanel.ResumeLayout(false);
            this.UpdateDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdateDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTabControl tabCustomerService;
        private MetroFramework.Controls.MetroTabPage tabUpdateDetails;
        private MetroFramework.Controls.MetroPanel UpdateDetailsPanel;
        private MetroFramework.Controls.MetroButton btnEditNew;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroLabel CustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroTabPage tabReturnProduct;
        private MetroFramework.Controls.MetroLabel SearchInvoice;
        private MetroFramework.Controls.MetroTextBox txtSearchInvoice;
        private MetroFramework.Controls.MetroButton btnDeleteProduct;
        private System.Windows.Forms.DataGridView gvDeleteProduct;
        private MetroFramework.Controls.MetroButton btnSaveSales;
        private System.Windows.Forms.DataGridView gvUpdateDetails;
        private MetroFramework.Controls.MetroLabel SearchCustomer;
        private MetroFramework.Controls.MetroTextBox txtSearchCustomer;
        private MetroFramework.Controls.MetroButton btnSearchCustomer;
        private MetroFramework.Controls.MetroLabel CustomerID;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel Address;
        private MetroFramework.Controls.MetroButton btnSaveDetails;
        private MetroFramework.Controls.MetroButton btnInvoiceSearch;
    }
}