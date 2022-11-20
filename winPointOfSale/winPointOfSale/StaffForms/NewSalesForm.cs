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
    public partial class NewSalesForm : MetroFramework.Forms.MetroForm
    {
        #region Defination Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();

        String invoiceNo = string.Empty;
        String productID = string.Empty;
        String productName = string.Empty;
        String productPrice = string.Empty;
        String salesID = string.Empty;
        String QRY = string.Empty;
        bool flag = false;
        bool saveSales = false;

        public NewSalesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            saveCustomerSales();
        }
        private void NewSalesForm_Load(object sender, EventArgs e)
        {
            loadAllProducts();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            closeForm();
        }
        private void gvShowProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadProductDetails(e);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!(productID == string.Empty))
            {
                addProductToSales();
                calculatePrice();
            }
        }
        private void btnNewSales_Click(object sender, EventArgs e)
        {
            clearAllSales();
            saveSales = false;
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            delectProductSales();
            calculatePrice();
        }
        private void gvShowSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteProductDetails(e);
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            searchProductDetail();
        }
        #endregion

        #region Methods Implementaion
        private void loadAllProducts()
        {
            QRY = "SELECT ProductID as 'ID',Name,Size,SalesPrice as 'Price' FROM [dbo].[Products]";
            try
            {
                gvShowProducts.DataSource = obj.tableData(QRY);
                gvShowProducts.Columns["ID"].Width = 25;
                gvShowProducts.Columns["Size"].Width = 45;
                gvShowProducts.Columns["Price"].Width = 57;
            }
            catch (Exception) { }
        }
        private void closeForm()
        {
            if (saveSales == false)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Sale Details First", "Sales Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveCustomerSales()
        {
            if (!(txtInvoiceNo.Text == string.Empty))
            {
                CustomerSalesForm csf = new CustomerSalesForm();
                csf.invoiceNo = txtInvoiceNo.Text;
                csf.ShowDialog();
                saveSales = false;
                gvShowSales.DataSource = null;
                txtInvoiceNo.Clear();
                txtTotalPrice.Clear();
                flag = false;
                loadAllProducts();
            }
            else
            {
                MessageBox.Show("No Product is Sale.","Sales",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void loadProductDetails(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productID = gvShowProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                productName = gvShowProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                productPrice = gvShowProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void addProductToSales()
        {
            if (flag == false)
            {
                txtInvoiceNo.Text = DateTime.Now.ToString("ddHHmmssff");
                //txtInvoiceNo.Text = DateTime.Now.ToString("yyyyMMddHHmmssff");
                //txtInvoiceNo.Text = DateTime.Now.Ticks.ToString();
                flag = true;
            }
            QRY = "INSERT INTO [dbo].[SaleDetails] (InvoiceNumber,ProductID,ProductName,SalesPrice) VALUES (" + txtInvoiceNo.Text + "," + productID + ",'" + productName + "'," + productPrice + ")";
            try
            {
                obj.DMLOperations(QRY);
                loadSaleDetails();
                saveSales = true;
            }
            catch(Exception){ }
            productID = string.Empty;
        }

        private void loadSaleDetails()
        {
            QRY = " SELECT SalesID,ProductID,ProductName,Quantity,SalesPrice,TotalPrice FROM [dbo].[SaleDetails] WHERE InvoiceNumber = '" + txtInvoiceNo.Text +"'";
            try
            { 
                gvShowSales.DataSource = obj.tableData(QRY);
                gvShowSales.Columns[0].Visible = false;
                gvShowSales.Columns[1].Visible = false;
            }
            catch (Exception) { }
        }
        private void clearAllSales()
        {
            
            QRY = "DELETE FROM [dbo].[SaleDetails] WHERE InvoiceNumber = '"+ txtInvoiceNo.Text +"'";
            try
            {
                obj.DMLOperations(QRY);
                txtInvoiceNo.Clear();
                txtTotalPrice.Clear();
                txtSeachProduct.Clear();
                gvShowSales.DataSource = null;
                flag = false;
            }
            catch (Exception) { }
            loadAllProducts();
        }
        private void calculatePrice()
        {
            QRY = "SELECT SUM(TotalPrice) FROM SaleDetails WHERE InvoiceNumber = '" + txtInvoiceNo.Text +"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtTotalPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception) { }
        }
        private void delectProductSales()
        {
            if (!(salesID == string.Empty))
            {
                QRY = "DELETE FROM [dbo].[SaleDetails] WHERE SalesID = '" + salesID + "'";
                try
                {
                    obj.DMLOperations(QRY);
                    loadSaleDetails();
                    salesID = "0";
                }
                catch (Exception) { }
            }
            salesID = string.Empty;
        }
        private void deleteProductDetails(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                salesID = gvShowSales.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void searchProductDetail()
        {
            QRY = "SELECT ProductID as 'ID',Name,Size,SalesPrice as 'Price' FROM [dbo].[Products] WHERE Name like '%" + txtSeachProduct.Text +"%'";
            try
            {
                gvShowProducts.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        #endregion
    }
}
