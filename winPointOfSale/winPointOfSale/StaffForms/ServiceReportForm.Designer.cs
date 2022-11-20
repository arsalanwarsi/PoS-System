
namespace winPointOfSale.StaffForms
{
    partial class ServiceReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceReportForm));
            this.ReportFrom = new MetroFramework.Controls.MetroLabel();
            this.dtReportFrom = new MetroFramework.Controls.MetroDateTime();
            this.gvServiceReport = new System.Windows.Forms.DataGridView();
            this.ReportTo = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dtReportTo = new MetroFramework.Controls.MetroDateTime();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.ServiceRepotPanel = new MetroFramework.Controls.MetroPanel();
            this.btnAllServices = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceReport)).BeginInit();
            this.ServiceRepotPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportFrom
            // 
            this.ReportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportFrom.AutoSize = true;
            this.ReportFrom.Location = new System.Drawing.Point(31, 21);
            this.ReportFrom.Name = "ReportFrom";
            this.ReportFrom.Size = new System.Drawing.Size(89, 19);
            this.ReportFrom.TabIndex = 49;
            this.ReportFrom.Text = "Report From:";
            // 
            // dtReportFrom
            // 
            this.dtReportFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportFrom.Location = new System.Drawing.Point(126, 16);
            this.dtReportFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReportFrom.Name = "dtReportFrom";
            this.dtReportFrom.Size = new System.Drawing.Size(152, 29);
            this.dtReportFrom.TabIndex = 1;
            // 
            // gvServiceReport
            // 
            this.gvServiceReport.AllowUserToAddRows = false;
            this.gvServiceReport.AllowUserToDeleteRows = false;
            this.gvServiceReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvServiceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvServiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvServiceReport.Location = new System.Drawing.Point(3, 66);
            this.gvServiceReport.Name = "gvServiceReport";
            this.gvServiceReport.ReadOnly = true;
            this.gvServiceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvServiceReport.Size = new System.Drawing.Size(715, 287);
            this.gvServiceReport.TabIndex = 54;
            // 
            // ReportTo
            // 
            this.ReportTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportTo.AutoSize = true;
            this.ReportTo.Location = new System.Drawing.Point(308, 21);
            this.ReportTo.Name = "ReportTo";
            this.ReportTo.Size = new System.Drawing.Size(70, 19);
            this.ReportTo.TabIndex = 51;
            this.ReportTo.Text = "Report To:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(585, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtReportTo
            // 
            this.dtReportTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReportTo.Location = new System.Drawing.Point(384, 18);
            this.dtReportTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReportTo.Name = "dtReportTo";
            this.dtReportTo.Size = new System.Drawing.Size(152, 29);
            this.dtReportTo.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(412, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ServiceRepotPanel
            // 
            this.ServiceRepotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceRepotPanel.Controls.Add(this.ReportFrom);
            this.ServiceRepotPanel.Controls.Add(this.dtReportFrom);
            this.ServiceRepotPanel.Controls.Add(this.gvServiceReport);
            this.ServiceRepotPanel.Controls.Add(this.ReportTo);
            this.ServiceRepotPanel.Controls.Add(this.btnSearch);
            this.ServiceRepotPanel.Controls.Add(this.dtReportTo);
            this.ServiceRepotPanel.HorizontalScrollbarBarColor = true;
            this.ServiceRepotPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ServiceRepotPanel.HorizontalScrollbarSize = 10;
            this.ServiceRepotPanel.Location = new System.Drawing.Point(23, 63);
            this.ServiceRepotPanel.Name = "ServiceRepotPanel";
            this.ServiceRepotPanel.Size = new System.Drawing.Size(721, 356);
            this.ServiceRepotPanel.TabIndex = 59;
            this.ServiceRepotPanel.VerticalScrollbarBarColor = true;
            this.ServiceRepotPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ServiceRepotPanel.VerticalScrollbarSize = 10;
            // 
            // btnAllServices
            // 
            this.btnAllServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAllServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAllServices.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAllServices.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAllServices.ForeColor = System.Drawing.Color.White;
            this.btnAllServices.Location = new System.Drawing.Point(254, 425);
            this.btnAllServices.Name = "btnAllServices";
            this.btnAllServices.Size = new System.Drawing.Size(100, 35);
            this.btnAllServices.TabIndex = 4;
            this.btnAllServices.Text = "All Services";
            this.btnAllServices.UseCustomBackColor = true;
            this.btnAllServices.UseCustomForeColor = true;
            this.btnAllServices.UseSelectable = true;
            this.btnAllServices.Click += new System.EventHandler(this.btnAllServices_Click);
            // 
            // ServiceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnAllServices);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ServiceRepotPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceReportForm";
            this.Text = "Service Report";
            this.Load += new System.EventHandler(this.ServiceReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceReport)).EndInit();
            this.ServiceRepotPanel.ResumeLayout(false);
            this.ServiceRepotPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ReportFrom;
        private MetroFramework.Controls.MetroDateTime dtReportFrom;
        private System.Windows.Forms.DataGridView gvServiceReport;
        private MetroFramework.Controls.MetroLabel ReportTo;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroDateTime dtReportTo;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroPanel ServiceRepotPanel;
        private MetroFramework.Controls.MetroButton btnAllServices;
    }
}