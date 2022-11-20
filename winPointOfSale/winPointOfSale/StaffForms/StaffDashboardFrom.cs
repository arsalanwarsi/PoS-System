using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winPointOfSale.AdminForms;

namespace winPointOfSale.StaffForms
{
    public partial class StaffDashboardFrom : MetroFramework.Forms.MetroForm
    {
        public StaffDashboardFrom()
        {
            InitializeComponent();
        }

        #region Events Handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lgf = new LoginForm();
            lgf.Show();
        }
        private void btnStockReport_Click(object sender, EventArgs e)
        {
            StockReportForm srf = new StockReportForm();
            srf.Show();
        }
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm srf = new SalesReportForm();
            srf.Show();
        }
        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            ServiceReportForm srf = new ServiceReportForm();
            srf.Show();
        }
        private void btnNewSales_Click(object sender, EventArgs e)
        {
            NewSalesForm nsf = new NewSalesForm();
            nsf.Show();
        }
        private void btnCustomerService_Click(object sender, EventArgs e)
        {
            CustomerServiceForm csf = new CustomerServiceForm();
            csf.Show();
        }
        #endregion
    }
}
