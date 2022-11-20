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
    public partial class ServiceReportForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;

        public ServiceReportForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ServiceReportForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void btnAllServices_Click(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadServicesReport();
        }
        #endregion

        #region Methods Implementaion
        private void loadServicesReport()
        {
            QRY = "SELECT * FROM [dbo].[Services] WHERE ServiceDate >= '" + dtReportFrom.Text + "' AND ServiceDate <= '" + dtReportTo.Text + "'";
            try
            { 
                gvServiceReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void bindGrid()
        {
            try
            {
                QRY = "SELECT * FROM [dbo].[Services]";
                gvServiceReport.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        #endregion
    }
}
