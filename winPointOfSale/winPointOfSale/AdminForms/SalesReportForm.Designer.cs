
namespace winPointOfSale.AdminForms
{
    partial class SalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.gvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnSearchSR = new MetroFramework.Controls.MetroButton();
            this.dtReportTo = new MetroFramework.Controls.MetroDateTime();
            this.ReportTo = new MetroFramework.Controls.MetroLabel();
            this.dtReportFrom = new MetroFramework.Controls.MetroDateTime();
            this.ReportFrom = new MetroFramework.Controls.MetroLabel();
            this.SalesRepotPanel = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnShowAllSR = new MetroFramework.Controls.MetroButton();
            this.UserGuide = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesReport)).BeginInit();
            this.SalesRepotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvSalesReport
            // 
            this.gvSalesReport.AllowUserToAddRows = false;
            this.gvSalesReport.AllowUserToDeleteRows = false;
            this.gvSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSalesReport.Location = new System.Drawing.Point(3, 76);
            this.gvSalesReport.Name = "gvSalesReport";
            this.gvSalesReport.ReadOnly = true;
            this.gvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSalesReport.Size = new System.Drawing.Size(715, 277);
            this.gvSalesReport.TabIndex = 4;
            this.gvSalesReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSalesReport_CellDoubleClick);
            // 
            // btnSearchSR
            // 
            this.btnSearchSR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchSR.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchSR.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearchSR.ForeColor = System.Drawing.Color.White;
            this.btnSearchSR.Location = new System.Drawing.Point(586, 9);
            this.btnSearchSR.Name = "btnSearchSR";
            this.btnSearchSR.Size = new System.Drawing.Size(100, 35);
            this.btnSearchSR.TabIndex = 3;
            this.btnSearchSR.Text = "Search";
            this.btnSearchSR.UseCustomBackColor = true;
            this.btnSearchSR.UseCustomForeColor = true;
            this.btnSearchSR.UseSelectable = true;
            this.btnSearchSR.Click += new System.EventHandler(this.btnSearchSR_Click);
            // 
            // dtReportTo
            // 
            this.dtReportTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportTo.Location = new System.Drawing.Point(384, 15);
            this.dtReportTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReportTo.Name = "dtReportTo";
            this.dtReportTo.Size = new System.Drawing.Size(152, 29);
            this.dtReportTo.TabIndex = 2;
            // 
            // ReportTo
            // 
            this.ReportTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportTo.AutoSize = true;
            this.ReportTo.Location = new System.Drawing.Point(308, 18);
            this.ReportTo.Name = "ReportTo";
            this.ReportTo.Size = new System.Drawing.Size(70, 19);
            this.ReportTo.TabIndex = 51;
            this.ReportTo.Text = "Report To:";
            // 
            // dtReportFrom
            // 
            this.dtReportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportFrom.Location = new System.Drawing.Point(126, 13);
            this.dtReportFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReportFrom.Name = "dtReportFrom";
            this.dtReportFrom.Size = new System.Drawing.Size(152, 29);
            this.dtReportFrom.TabIndex = 1;
            // 
            // ReportFrom
            // 
            this.ReportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportFrom.AutoSize = true;
            this.ReportFrom.Location = new System.Drawing.Point(31, 18);
            this.ReportFrom.Name = "ReportFrom";
            this.ReportFrom.Size = new System.Drawing.Size(89, 19);
            this.ReportFrom.TabIndex = 49;
            this.ReportFrom.Text = "Report From:";
            // 
            // SalesRepotPanel
            // 
            this.SalesRepotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesRepotPanel.Controls.Add(this.UserGuide);
            this.SalesRepotPanel.Controls.Add(this.ReportFrom);
            this.SalesRepotPanel.Controls.Add(this.dtReportFrom);
            this.SalesRepotPanel.Controls.Add(this.gvSalesReport);
            this.SalesRepotPanel.Controls.Add(this.ReportTo);
            this.SalesRepotPanel.Controls.Add(this.btnSearchSR);
            this.SalesRepotPanel.Controls.Add(this.dtReportTo);
            this.SalesRepotPanel.HorizontalScrollbarBarColor = true;
            this.SalesRepotPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.SalesRepotPanel.HorizontalScrollbarSize = 10;
            this.SalesRepotPanel.Location = new System.Drawing.Point(23, 63);
            this.SalesRepotPanel.Name = "SalesRepotPanel";
            this.SalesRepotPanel.Size = new System.Drawing.Size(721, 356);
            this.SalesRepotPanel.TabIndex = 55;
            this.SalesRepotPanel.VerticalScrollbarBarColor = true;
            this.SalesRepotPanel.VerticalScrollbarHighlightOnWheel = false;
            this.SalesRepotPanel.VerticalScrollbarSize = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(412, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowAllSR
            // 
            this.btnShowAllSR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowAllSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAllSR.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowAllSR.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnShowAllSR.ForeColor = System.Drawing.Color.White;
            this.btnShowAllSR.Location = new System.Drawing.Point(255, 425);
            this.btnShowAllSR.Name = "btnShowAllSR";
            this.btnShowAllSR.Size = new System.Drawing.Size(100, 35);
            this.btnShowAllSR.TabIndex = 5;
            this.btnShowAllSR.Text = "Show All";
            this.btnShowAllSR.UseCustomBackColor = true;
            this.btnShowAllSR.UseCustomForeColor = true;
            this.btnShowAllSR.UseSelectable = true;
            this.btnShowAllSR.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // UserGuide
            // 
            this.UserGuide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserGuide.AutoSize = true;
            this.UserGuide.Location = new System.Drawing.Point(189, 51);
            this.UserGuide.Name = "UserGuide";
            this.UserGuide.Size = new System.Drawing.Size(343, 19);
            this.UserGuide.TabIndex = 56;
            this.UserGuide.Text = "Double Click On The Invoice Number To See Sales Details";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnShowAllSR);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SalesRepotPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSalesReport)).EndInit();
            this.SalesRepotPanel.ResumeLayout(false);
            this.SalesRepotPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSalesReport;
        private MetroFramework.Controls.MetroButton btnSearchSR;
        private MetroFramework.Controls.MetroDateTime dtReportTo;
        private MetroFramework.Controls.MetroLabel ReportTo;
        private MetroFramework.Controls.MetroDateTime dtReportFrom;
        private MetroFramework.Controls.MetroLabel ReportFrom;
        private MetroFramework.Controls.MetroPanel SalesRepotPanel;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnShowAllSR;
        private MetroFramework.Controls.MetroLabel UserGuide;
    }
}