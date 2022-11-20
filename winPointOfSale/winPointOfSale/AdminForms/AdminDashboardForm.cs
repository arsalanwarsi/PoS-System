using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winPointOfSale.AdminForms
{
    public partial class AdminDashboardForm : MetroFramework.Forms.MetroForm
    {
        public AdminDashboardForm()
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
        private void btnManageStock_Click(object sender, EventArgs e)
        {
            ManageStockForm msf = new ManageStockForm();
            msf.Show();
        }
        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomerForm mcf = new ManageCustomerForm();
            mcf.Show();
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm asf = new AddStaffForm();
            asf.Show();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.Show();
        }
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm srf = new SalesReportForm();
            srf.Show();
        }
        #endregion
    }
}
