using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winPointOfSale.Services;

namespace winPointOfSale.StaffForms
{
    public partial class StockReportForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;

        public StockReportForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StockReportForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void btnAllStockR_Click(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadStockReport();
        }
        #endregion

        #region Methods Implementaion
        private void loadStockReport()
        {
            QRY = "SELECT * FROM [dbo].[Products] WHERE DateOfEntry >= '"+ dtReportFrom.Text +"' AND DateOfEntry <= '"+ dtReportTo.Text +"'";
            try
            {
                gvStockReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void bindGrid()
        {
            try
            {
                QRY = "SELECT * FROM [dbo].[Products]";
                gvStockReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        #endregion
    }
}
