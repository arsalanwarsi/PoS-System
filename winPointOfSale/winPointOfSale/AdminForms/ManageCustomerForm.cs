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

namespace winPointOfSale.AdminForms
{
    public partial class ManageCustomerForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;

        public ManageCustomerForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            addCustomer();
            bindGrid();
        }
        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void btnSeachCustomer_Click(object sender, EventArgs e)
        {
            customerSearch();
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            cleanFields();
        }
        #endregion

        #region Methods Implementation
        private void addCustomer()
        {
            if(txtCustomerName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    QRY = "INSERT INTO [dbo].[Customers] (Name,Phone_No,Address) VALUES ('"+ txtCustomerName.Text +"','"+ txtPhoneNo.Text +"','"+ txtAddress.Text +"')";
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Customer Record Save Successfully", "Customer Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Customer Record Did Not Save", "Customer Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        } 
        private void bindGrid()
        {
            QRY = "SELECT Name,Phone_No,Address FROM Customers";
            try
            {
                gvCustomerList.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void customerSearch()
        {
            QRY = "SELECT Name,Phone_No,Address FROM Customers where name like '%" + txtSearchCustomer.Text + "%'";
            try
            {
                gvCustomerList.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
}
        private void cleanFields()
        {
            txtCustomerName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
        }
        #endregion
    }
}
