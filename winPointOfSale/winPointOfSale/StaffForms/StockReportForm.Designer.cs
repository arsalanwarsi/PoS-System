
namespace winPointOfSale.StaffForms
{
    partial class StockReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReportForm));
            this.ReportFrom = new MetroFramework.Controls.MetroLabel();
            this.dtReportFrom = new MetroFramework.Controls.MetroDateTime();
            this.gvStockReport = new System.Windows.Forms.DataGridView();
            this.ReportTo = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.dtReportTo = new MetroFramework.Controls.MetroDateTime();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.StockRepotPanel = new MetroFramework.Controls.MetroPanel();
            this.btnAllStockR = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).BeginInit();
            this.StockRepotPanel.SuspendLayout();
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
            // gvStockReport
            // 
            this.gvStockReport.AllowUserToAddRows = false;
            this.gvStockReport.AllowUserToDeleteRows = false;
            this.gvStockReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStockReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockReport.Location = new System.Drawing.Point(3, 66);
            this.gvStockReport.Name = "gvStockReport";
            this.gvStockReport.ReadOnly = true;
            this.gvStockReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStockReport.Size = new System.Drawing.Size(715, 287);
            this.gvStockReport.TabIndex = 54;
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
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            // StockRepotPanel
            // 
            this.StockRepotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockRepotPanel.Controls.Add(this.ReportFrom);
            this.StockRepotPanel.Controls.Add(this.dtReportFrom);
            this.StockRepotPanel.Controls.Add(this.gvStockReport);
            this.StockRepotPanel.Controls.Add(this.ReportTo);
            this.StockRepotPanel.Controls.Add(this.btnSearch);
            this.StockRepotPanel.Controls.Add(this.dtReportTo);
            this.StockRepotPanel.HorizontalScrollbarBarColor = true;
            this.StockRepotPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.StockRepotPanel.HorizontalScrollbarSize = 10;
            this.StockRepotPanel.Location = new System.Drawing.Point(23, 63);
            this.StockRepotPanel.Name = "StockRepotPanel";
            this.StockRepotPanel.Size = new System.Drawing.Size(721, 356);
            this.StockRepotPanel.TabIndex = 57;
            this.StockRepotPanel.VerticalScrollbarBarColor = true;
            this.StockRepotPanel.VerticalScrollbarHighlightOnWheel = false;
            this.StockRepotPanel.VerticalScrollbarSize = 10;
            // 
            // btnAllStockR
            // 
            this.btnAllStockR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAllStockR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAllStockR.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAllStockR.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAllStockR.ForeColor = System.Drawing.Color.White;
            this.btnAllStockR.Location = new System.Drawing.Point(254, 425);
            this.btnAllStockR.Name = "btnAllStockR";
            this.btnAllStockR.Size = new System.Drawing.Size(100, 35);
            this.btnAllStockR.TabIndex = 4;
            this.btnAllStockR.Text = "All Stock";
            this.btnAllStockR.UseCustomBackColor = true;
            this.btnAllStockR.UseCustomForeColor = true;
            this.btnAllStockR.UseSelectable = true;
            this.btnAllStockR.Click += new System.EventHandler(this.btnAllStockR_Click);
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.btnAllStockR);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.StockRepotPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockReportForm";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStockReport)).EndInit();
            this.StockRepotPanel.ResumeLayout(false);
            this.StockRepotPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ReportFrom;
        private MetroFramework.Controls.MetroDateTime dtReportFrom;
        private System.Windows.Forms.DataGridView gvStockReport;
        private MetroFramework.Controls.MetroLabel ReportTo;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroDateTime dtReportTo;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroPanel StockRepotPanel;
        private MetroFramework.Controls.MetroButton btnAllStockR;
    }
}