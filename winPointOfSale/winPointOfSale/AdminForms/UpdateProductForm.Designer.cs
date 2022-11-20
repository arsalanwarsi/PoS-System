
namespace winPointOfSale.AdminForms
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            this.AddProductPanel = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.ProductID = new MetroFramework.Controls.MetroLabel();
            this.btnUpdateProduct = new MetroFramework.Controls.MetroButton();
            this.txtProductID = new MetroFramework.Controls.MetroTextBox();
            this.txtSalePrice = new MetroFramework.Controls.MetroTextBox();
            this.cbCategory = new MetroFramework.Controls.MetroComboBox();
            this.ProductName = new MetroFramework.Controls.MetroLabel();
            this.dtDateOfEntry = new MetroFramework.Controls.MetroDateTime();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.SalePrice = new MetroFramework.Controls.MetroLabel();
            this.Category = new MetroFramework.Controls.MetroLabel();
            this.PurchasePrice = new MetroFramework.Controls.MetroLabel();
            this.cbSize = new MetroFramework.Controls.MetroComboBox();
            this.Size = new MetroFramework.Controls.MetroLabel();
            this.DateOfEntry = new MetroFramework.Controls.MetroLabel();
            this.AddProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProductPanel.Controls.Add(this.btnClose);
            this.AddProductPanel.Controls.Add(this.txtPurchasePrice);
            this.AddProductPanel.Controls.Add(this.ProductID);
            this.AddProductPanel.Controls.Add(this.btnUpdateProduct);
            this.AddProductPanel.Controls.Add(this.txtProductID);
            this.AddProductPanel.Controls.Add(this.txtSalePrice);
            this.AddProductPanel.Controls.Add(this.cbCategory);
            this.AddProductPanel.Controls.Add(this.ProductName);
            this.AddProductPanel.Controls.Add(this.dtDateOfEntry);
            this.AddProductPanel.Controls.Add(this.txtProductName);
            this.AddProductPanel.Controls.Add(this.SalePrice);
            this.AddProductPanel.Controls.Add(this.Category);
            this.AddProductPanel.Controls.Add(this.PurchasePrice);
            this.AddProductPanel.Controls.Add(this.cbSize);
            this.AddProductPanel.Controls.Add(this.Size);
            this.AddProductPanel.Controls.Add(this.DateOfEntry);
            this.AddProductPanel.HorizontalScrollbarBarColor = true;
            this.AddProductPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.HorizontalScrollbarSize = 10;
            this.AddProductPanel.Location = new System.Drawing.Point(23, 63);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(650, 208);
            this.AddProductPanel.TabIndex = 29;
            this.AddProductPanel.VerticalScrollbarBarColor = true;
            this.AddProductPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddProductPanel.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(351, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPurchasePrice
            // 
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
            this.txtPurchasePrice.Location = new System.Drawing.Point(457, 5);
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
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.UseSelectable = true;
            this.txtPurchasePrice.WaterMark = "Enter Purchase Price";
            this.txtPurchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(3, 9);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(74, 19);
            this.ProductID.TabIndex = 2;
            this.ProductID.Text = "Product ID:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateProduct.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateProduct.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(199, 168);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseCustomBackColor = true;
            this.btnUpdateProduct.UseCustomForeColor = true;
            this.btnUpdateProduct.UseSelectable = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.CustomButton.Image = null;
            this.txtProductID.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtProductID.CustomButton.Name = "";
            this.txtProductID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductID.CustomButton.TabIndex = 1;
            this.txtProductID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductID.CustomButton.UseSelectable = true;
            this.txtProductID.CustomButton.Visible = false;
            this.txtProductID.Lines = new string[0];
            this.txtProductID.Location = new System.Drawing.Point(117, 5);
            this.txtProductID.MaxLength = 32767;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PromptText = "Enter Product ID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductID.SelectedText = "";
            this.txtProductID.SelectionLength = 0;
            this.txtProductID.SelectionStart = 0;
            this.txtProductID.ShortcutsEnabled = true;
            this.txtProductID.Size = new System.Drawing.Size(189, 23);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.UseSelectable = true;
            this.txtProductID.WaterMark = "Enter Product ID";
            this.txtProductID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSalePrice
            // 
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
            this.txtSalePrice.Location = new System.Drawing.Point(457, 42);
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
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.UseSelectable = true;
            this.txtSalePrice.WaterMark = "Enter Sale Price";
            this.txtSalePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 23;
            this.cbCategory.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.cbCategory.Location = new System.Drawing.Point(117, 79);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.PromptText = "Select Category";
            this.cbCategory.Size = new System.Drawing.Size(189, 29);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.UseSelectable = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(3, 46);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(98, 19);
            this.ProductName.TabIndex = 8;
            this.ProductName.Text = "Product Name:";
            // 
            // dtDateOfEntry
            // 
            this.dtDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfEntry.Location = new System.Drawing.Point(457, 79);
            this.dtDateOfEntry.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateOfEntry.Name = "dtDateOfEntry";
            this.dtDateOfEntry.Size = new System.Drawing.Size(189, 29);
            this.dtDateOfEntry.TabIndex = 7;
            // 
            // txtProductName
            // 
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
            this.txtProductName.Location = new System.Drawing.Point(117, 42);
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
            this.txtProductName.TabIndex = 2;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMark = "Enter Product Name";
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalePrice
            // 
            this.SalePrice.AutoSize = true;
            this.SalePrice.Location = new System.Drawing.Point(343, 42);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Size = new System.Drawing.Size(69, 19);
            this.SalePrice.TabIndex = 21;
            this.SalePrice.Text = "Sale Price:";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(3, 89);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(67, 19);
            this.Category.TabIndex = 10;
            this.Category.Text = "Category:";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSize = true;
            this.PurchasePrice.Location = new System.Drawing.Point(343, 5);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(97, 19);
            this.PurchasePrice.TabIndex = 19;
            this.PurchasePrice.Text = "Purchase Price:";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.ItemHeight = 23;
            this.cbSize.Location = new System.Drawing.Point(117, 121);
            this.cbSize.Name = "cbSize";
            this.cbSize.PromptText = "Select Size";
            this.cbSize.Size = new System.Drawing.Size(189, 29);
            this.cbSize.TabIndex = 4;
            this.cbSize.UseSelectable = true;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(3, 131);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(35, 19);
            this.Size.TabIndex = 12;
            this.Size.Text = "Size:";
            // 
            // DateOfEntry
            // 
            this.DateOfEntry.AutoSize = true;
            this.DateOfEntry.Location = new System.Drawing.Point(343, 85);
            this.DateOfEntry.Name = "DateOfEntry";
            this.DateOfEntry.Size = new System.Drawing.Size(92, 19);
            this.DateOfEntry.TabIndex = 15;
            this.DateOfEntry.Text = "Date Of Entry:";
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 294);
            this.Controls.Add(this.AddProductPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProductForm";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel AddProductPanel;
        private MetroFramework.Controls.MetroLabel ProductID;
        private MetroFramework.Controls.MetroButton btnUpdateProduct;
        private MetroFramework.Controls.MetroTextBox txtProductID;
        private MetroFramework.Controls.MetroTextBox txtSalePrice;
        private MetroFramework.Controls.MetroComboBox cbCategory;
        private MetroFramework.Controls.MetroLabel ProductName;
        private MetroFramework.Controls.MetroDateTime dtDateOfEntry;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel SalePrice;
        private MetroFramework.Controls.MetroLabel Category;
        private MetroFramework.Controls.MetroLabel PurchasePrice;
        private MetroFramework.Controls.MetroComboBox cbSize;
        private MetroFramework.Controls.MetroLabel Size;
        private MetroFramework.Controls.MetroLabel DateOfEntry;
        private MetroFramework.Controls.MetroTextBox txtPurchasePrice;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}