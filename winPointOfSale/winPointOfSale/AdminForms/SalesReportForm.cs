using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using winPointOfSale.Services;

namespace winPointOfSale.AdminForms
{
    public partial class SalesReportForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();

        public SalesReportForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void gvSalesReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                salesFormLoad(e);
            }
        }
        private void btnSearchSR_Click(object sender, EventArgs e)
        {
            salesRecord();
        }
        #endregion

        #region Methods Implementaion
        public void bindGrid()
        {
            String QRY = "SELECT * FROM Sales";
            try
            {
                gvSalesReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void salesRecord()
        {
            String QRY = "SELECT * FROM Sales WHERE PurchaseDate >= '"+ dtReportFrom.Text +"' AND PurchaseDate <= '"+ dtReportTo.Text +"'";
            try
            {
                gvSalesReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void salesFormLoad(DataGridViewCellEventArgs e)
        {
            SaleDetailsForm sdf = new SaleDetailsForm();
            sdf.invoice = gvSalesReport.Rows[e.RowIndex].Cells[0].Value.ToString();
            sdf.Show();
        }
        #endregion
    }
}
