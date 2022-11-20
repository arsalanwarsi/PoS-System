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
    public partial class CustomerServiceForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String customerID = string.Empty;
        String salesID = string.Empty;
        String invoiceNo = string.Empty;
        String QRY = string.Empty;
        bool flag = false;

        public CustomerServiceForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            closeForm();
        }
        private void CustomerServiceForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }
        private void gvUpdateDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadCustomerData(e);
        }
        private void btnEditNew_Click(object sender, EventArgs e)
        {
            clearControls();
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            searchCustomerRecord();
        }
        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            updateCustomerDetail();
            bindGrid();
        }
        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            saveServiceRecord();
        }
        private void gvDeleteProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDelectProduct(e);
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            deleteSaleProduct();
        }
        
        private void btnInvoiceSearch_Click(object sender, EventArgs e)
        {
            searchInvoiceDetails();
        }
        #endregion

        #region Methods Implementaion
        private void closeForm()
        {
            if (flag == false)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Sales Service First", "Sales Not Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bindGrid()
        {
            QRY = "SELECT * FROM [dbo].[Customers]";
            try
            {
                gvUpdateDetails.DataSource = obj.tableData(QRY);
                gvUpdateDetails.Columns[0].Visible = false;
            }
            catch (Exception) { }
        }
        private void loadCustomerData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerID = gvUpdateDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerName.Text = gvUpdateDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhoneNo.Text = gvUpdateDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = gvUpdateDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void clearControls()
        {
            customerID = string.Empty;
            txtCustomerName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
        }
        private void searchCustomerRecord()
        {
            QRY = "SELECT * FROM [dbo].[Customers] WHERE Name like '%" + txtSearchCustomer.Text +"%'";
            try
            { 
            gvUpdateDetails.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void updateCustomerDetail()
        {
            if (!(customerID == string.Empty))
            {
                QRY = "UPDATE [dbo].[Customers] SET Name = '" + txtCustomerName.Text + "', Phone_No = '" + txtPhoneNo.Text + "', Address = '" + txtAddress.Text + "' WHERE CustomerID = " + customerID;
                try
                {
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Customer Record is Updated","Customer Record",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception) { }
            }
            customerID = string.Empty;
        }
        private void loadSaleDetails()
        {
            QRY = "SELECT s.SalesID,d.CustomerName,s.InvoiceNumber,s.ProductName,s.Quantity,s.SalesPrice,s.TotalPrice FROM [dbo].[SaleDetails] s inner join Sales d ON s.InvoiceNumber = d.InvoiceNumber WHERE s.InvoiceNumber = " + txtSearchInvoice.Text;
            try
            {
                gvDeleteProduct.DataSource = obj.tableData(QRY);
                gvDeleteProduct.Columns[0].Visible = false;
            }
            catch(Exception)
            {
                gvDeleteProduct.DataSource = null;
            }
        }
        private void searchInvoiceDetails()
        {
            if (flag == false)
            {
                loadSaleDetails();
            }
            else
            {
                MessageBox.Show("Save Sales Service First", "Sales Not Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDelectProduct(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                salesID = gvDeleteProduct.Rows[e.RowIndex].Cells["SalesID"].Value.ToString();
                invoiceNo = gvDeleteProduct.Rows[e.RowIndex].Cells["InvoiceNumber"].Value.ToString();
            }
        }
        private void deleteSaleProduct()
        {
            if (!(invoiceNo == string.Empty))
            {
                if (MessageBox.Show("Do You Want To Delete ?", "Delete Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    QRY = "DELETE FROM [dbo].[SaleDetails] WHERE SalesID = '" + salesID + "' AND InvoiceNumber = '" + invoiceNo + "'";
                    try
                    {
                        obj.DMLOperations(QRY);
                        MessageBox.Show("Sale Deleted Successfully", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = true;
                        loadSaleDetails();
                        /*
                        QRY = "SELECT s.SalesID,d.CustomerName,s.InvoiceNumber,s.ProductID,s.ProductName,s.SalesPrice FROM [dbo].[SaleDetails] s inner join [dbo].[Sales] d ON s.InvoiceNumber = d.InvoiceNumber WHERE s.InvoiceNumber = '" + invoiceNo + "'";
                        gvDeleteProduct.DataSource = obj.tableData(QRY);
                        gvDeleteProduct.Columns[0].Visible = false;
                        */
                        invoiceNo = string.Empty;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sale Did Not Delete", "Delete Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void saveServiceRecord()
        {
            if(gvDeleteProduct.RowCount >=0)
            {
                try
                {
                    String customerName = gvDeleteProduct.Rows[0].Cells[1].Value.ToString();
                    String customerInvoice = gvDeleteProduct.Rows[0].Cells[2].Value.ToString();
                    String serviceDate = DateTime.Now.ToString("yyyy/MM/dd");

                    QRY = "INSERT INTO [dbo].[Services] (CustomeName,InvoiceNumber,ServiceDate) VALUES ('"+ customerName +"','"+ customerInvoice +"','"+ serviceDate +"')";
                    obj.DMLOperations(QRY);
                    
                    QRY = "UPDATE [dbo].[Sales] SET TotalProducts = (SELECT count(productID) FROM SaleDetails WHERE InvoiceNumber = '"+ customerInvoice + "'), TotalPrice = (SELECT sum(SalesPrice) FROM SaleDetails WHERE InvoiceNumber = '" + customerInvoice + "') WHERE InvoiceNumber = '" + customerInvoice + "';";
                    obj.DMLOperations(QRY);
                    
                    MessageBox.Show("Sales Recorde Save Successfully","Sale Service",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    flag = false;
                    gvDeleteProduct.DataSource = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("Sales Recorde Did Not Save", "Sale Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtSearchInvoice.Clear();
        }
        #endregion
    }
}
