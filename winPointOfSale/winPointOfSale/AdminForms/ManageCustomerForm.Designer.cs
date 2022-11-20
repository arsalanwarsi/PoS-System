
namespace winPointOfSale.AdminForms
{
    partial class ManageCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomerForm));
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.tabCustomerList = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSeachCustomer = new MetroFramework.Controls.MetroButton();
            this.CustomerSearch = new MetroFramework.Controls.MetroLabel();
            this.txtSearchCustomer = new MetroFramework.Controls.MetroTextBox();
            this.gvCustomerList = new System.Windows.Forms.DataGridView();
            this.tabAddCustomer = new MetroFramework.Controls.MetroTabPage();
            this.AddCustomertPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSaveCustomer = new MetroFramework.Controls.MetroButton();
            this.btnNewCustomer = new MetroFramework.Controls.MetroButton();
            this.txtPhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.CustomerName = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroLabel();
            this.Address = new MetroFramework.Controls.MetroLabel();
            this.tabManageStock = new MetroFramework.Controls.MetroTabControl();
            this.tabCustomerList.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).BeginInit();
            this.tabAddCustomer.SuspendLayout();
            this.AddCustomertPanel.SuspendLayout();
            this.tabManageStock.SuspendLayout();
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
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabCustomerList
            // 
            this.tabCustomerList.Controls.Add(this.metroPanel1);
            this.tabCustomerList.Location = new System.Drawing.Point(4, 38);
            this.tabCustomerList.Name = "tabCustomerList";
            this.tabCustomerList.Size = new System.Drawing.Size(713, 355);
            this.tabCustomerList.TabIndex = 0;
            this.tabCustomerList.Text = "Customer List";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btnSeachCustomer);
            this.metroPanel1.Controls.Add(this.CustomerSearch);
            this.metroPanel1.Controls.Add(this.txtSearchCustomer);
            this.metroPanel1.Controls.Add(this.gvCustomerList);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(713, 355);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSeachCustomer
            // 
            this.btnSeachCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeachCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeachCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSeachCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSeachCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSeachCustomer.Location = new System.Drawing.Point(559, 18);
            this.btnSeachCustomer.Name = "btnSeachCustomer";
            this.btnSeachCustomer.Size = new System.Drawing.Size(100, 35);
            this.btnSeachCustomer.TabIndex = 53;
            this.btnSeachCustomer.Text = "Seach";
            this.btnSeachCustomer.UseCustomBackColor = true;
            this.btnSeachCustomer.UseCustomForeColor = true;
            this.btnSeachCustomer.UseSelectable = true;
            this.btnSeachCustomer.Click += new System.EventHandler(this.btnSeachCustomer_Click);
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerSearch.AutoSize = true;
            this.CustomerSearch.Location = new System.Drawing.Point(61, 25);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(113, 19);
            this.CustomerSearch.TabIndex = 52;
            this.CustomerSearch.Text = "Search Customer:";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearchCustomer.CustomButton.Image = null;
            this.txtSearchCustomer.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.txtSearchCustomer.CustomButton.Name = "";
            this.txtSearchCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCustomer.CustomButton.TabIndex = 1;
            this.txtSearchCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCustomer.CustomButton.UseSelectable = true;
            this.txtSearchCustomer.CustomButton.Visible = false;
            this.txtSearchCustomer.Lines = new string[0];
            this.txtSearchCustomer.Location = new System.Drawing.Point(197, 24);
            this.txtSearchCustomer.MaxLength = 32767;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PromptText = "Search Customer Name";
            this.txtSearchCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.SelectionLength = 0;
            this.txtSearchCustomer.SelectionStart = 0;
            this.txtSearchCustomer.ShortcutsEnabled = true;
            this.txtSearchCustomer.Size = new System.Drawing.Size(326, 23);
            this.txtSearchCustomer.TabIndex = 1;
            this.txtSearchCustomer.UseSelectable = true;
            this.txtSearchCustomer.WaterMark = "Search Customer Name";
            this.txtSearchCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gvCustomerList
            // 
            this.gvCustomerList.AllowUserToAddRows = false;
            this.gvCustomerList.AllowUserToDeleteRows = false;
            this.gvCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerList.Location = new System.Drawing.Point(3, 70);
            this.gvCustomerList.Name = "gvCustomerList";
            this.gvCustomerList.ReadOnly = true;
            this.gvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomerList.Size = new System.Drawing.Size(707, 282);
            this.gvCustomerList.TabIndex = 2;
            // 
            // tabAddCustomer
            // 
            this.tabAddCustomer.Controls.Add(this.AddCustomertPanel);
            this.tabAddCustomer.HorizontalScrollbarBarColor = true;
            this.tabAddCustomer.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAddCustomer.HorizontalScrollbarSize = 10;
            this.tabAddCustomer.Location = new System.Drawing.Point(4, 38);
            this.tabAddCustomer.Name = "tabAddCustomer";
            this.tabAddCustomer.Size = new System.Drawing.Size(713, 355);
            this.tabAddCustomer.TabIndex = 0;
            this.tabAddCustomer.Text = "Add Customer";
            this.tabAddCustomer.VerticalScrollbarBarColor = true;
            this.tabAddCustomer.VerticalScrollbarHighlightOnWheel = false;
            this.tabAddCustomer.VerticalScrollbarSize = 10;
            // 
            // AddCustomertPanel
            // 
            this.AddCustomertPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCustomertPanel.Controls.Add(this.btnSaveCustomer);
            this.AddCustomertPanel.Controls.Add(this.btnNewCustomer);
            this.AddCustomertPanel.Controls.Add(this.txtPhoneNo);
            this.AddCustomertPanel.Controls.Add(this.txtAddress);
            this.AddCustomertPanel.Controls.Add(this.CustomerName);
            this.AddCustomertPanel.Controls.Add(this.txtCustomerName);
            this.AddCustomertPanel.Controls.Add(this.PhoneNo);
            this.AddCustomertPanel.Controls.Add(this.Address);
            this.AddCustomertPanel.HorizontalScrollbarBarColor = true;
            this.AddCustomertPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddCustomertPanel.HorizontalScrollbarSize = 10;
            this.AddCustomertPanel.Location = new System.Drawing.Point(0, 45);
            this.AddCustomertPanel.Name = "AddCustomertPanel";
            this.AddCustomertPanel.Size = new System.Drawing.Size(713, 271);
            this.AddCustomertPanel.TabIndex = 28;
            this.AddCustomertPanel.VerticalScrollbarBarColor = true;
            this.AddCustomertPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddCustomertPanel.VerticalScrollbarSize = 10;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSaveCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSaveCustomer.Location = new System.Drawing.Point(528, 143);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(100, 35);
            this.btnSaveCustomer.TabIndex = 4;
            this.btnSaveCustomer.Text = "Save Customer";
            this.btnSaveCustomer.UseCustomBackColor = true;
            this.btnSaveCustomer.UseCustomForeColor = true;
            this.btnSaveCustomer.UseSelectable = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNewCustomer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewCustomer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomer.Location = new System.Drawing.Point(528, 71);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(100, 35);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseCustomBackColor = true;
            this.btnNewCustomer.UseCustomForeColor = true;
            this.btnNewCustomer.UseSelectable = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // txtPhoneNo
            // 
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
            this.txtPhoneNo.Location = new System.Drawing.Point(198, 88);
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
            this.txtPhoneNo.TabIndex = 2;
            this.txtPhoneNo.UseSelectable = true;
            this.txtPhoneNo.WaterMark = "Enter Phone Number";
            this.txtPhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(198, 131);
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
            this.txtAddress.Size = new System.Drawing.Size(189, 61);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Enter Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(84, 51);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(109, 19);
            this.CustomerName.TabIndex = 8;
            this.CustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
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
            this.txtCustomerName.Location = new System.Drawing.Point(198, 47);
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
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Enter Customer Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Location = new System.Drawing.Point(84, 88);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(74, 19);
            this.PhoneNo.TabIndex = 21;
            this.PhoneNo.Text = "Phone No.:";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(84, 131);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(59, 19);
            this.Address.TabIndex = 19;
            this.Address.Text = "Address:";
            // 
            // tabManageStock
            // 
            this.tabManageStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabManageStock.Controls.Add(this.tabAddCustomer);
            this.tabManageStock.Controls.Add(this.tabCustomerList);
            this.tabManageStock.Location = new System.Drawing.Point(23, 63);
            this.tabManageStock.Name = "tabManageStock";
            this.tabManageStock.SelectedIndex = 1;
            this.tabManageStock.Size = new System.Drawing.Size(721, 397);
            this.tabManageStock.TabIndex = 1;
            this.tabManageStock.UseCustomBackColor = true;
            this.tabManageStock.UseCustomForeColor = true;
            this.tabManageStock.UseSelectable = true;
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabManageStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomerForm";
            this.Text = "Manage Customer";
            this.Load += new System.EventHandler(this.ManageCustomerForm_Load);
            this.tabCustomerList.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerList)).EndInit();
            this.tabAddCustomer.ResumeLayout(false);
            this.AddCustomertPanel.ResumeLayout(false);
            this.AddCustomertPanel.PerformLayout();
            this.tabManageStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.TabPage tabCustomerList;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel CustomerSearch;
        private MetroFramework.Controls.MetroTextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView gvCustomerList;
        private MetroFramework.Controls.MetroTabPage tabAddCustomer;
        private MetroFramework.Controls.MetroPanel AddCustomertPanel;
        private MetroFramework.Controls.MetroButton btnSaveCustomer;
        private MetroFramework.Controls.MetroButton btnNewCustomer;
        private MetroFramework.Controls.MetroTextBox txtPhoneNo;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel CustomerName;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel PhoneNo;
        private MetroFramework.Controls.MetroLabel Address;
        private MetroFramework.Controls.MetroTabControl tabManageStock;
        private MetroFramework.Controls.MetroButton btnSeachCustomer;
    }
}