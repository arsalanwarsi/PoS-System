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
using System.IO;

namespace winPointOfSale.StaffForms
{
    public partial class CustomerSalesForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;
        public String invoiceNo = string.Empty;
        String customerName = string.Empty;

        public CustomerSalesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void CustomerSalesForm_Load(object sender, EventArgs e)
        {
            loadSaleDetails();
            loadCustomerRecord();
        }
        private void gvShowCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                customerName = gvShowCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            btnSelectCustomerDetail();
        }
        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            saveCustomerSales();
        }
        private void txtSeachCustomer_TextChanged(object sender, EventArgs e)
        {
            getCustomerData();
        }
        #endregion

        #region Methods Implementaion
        private void loadSaleDetails()
        {
            QRY = "SELECT COUNT(ProductID),SUM(TotalPrice) FROM SaleDetails WHERE InvoiceNumber = '" + invoiceNo +"'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                txtInvoiceNumber.Text = invoiceNo;
                txtTotalProducts.Text = ds.Tables[0].Rows[0][0].ToString();
                txtTotalPrice.Text = ds.Tables[0].Rows[0][1].ToString();
            }
            catch (Exception) { }
        }
        private void loadCustomerRecord()
        {
            QRY = "SELECT Name,Phone_No,Address FROM [dbo].[Customers]";
            try
            {
                gvShowCustomer.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void btnSelectCustomerDetail()
        {
            txtCustomerName.Text = customerName;
        }
        private void saveCustomerSales()
        {

            if (!(txtCustomerName.Text == string.Empty))
            {
                QRY = "INSERT INTO [dbo].[Sales] (InvoiceNumber,CustomerName,TotalProducts,TotalPrice,PurchaseDate) VALUES (" + txtInvoiceNumber.Text + ",'" + txtCustomerName.Text + "'," + txtTotalProducts.Text + "," + txtTotalPrice.Text + ",'" + dtPurchaseDate.Text + "')";
                try
                {
                    obj.DMLOperations(QRY);
                    generateReceipt();
                    this.Close();
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Please Select the Customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getCustomerData()
        {
            if (txtSeachCustomer.Text == string.Empty)
            {
                loadCustomerRecord();
            }
            else
            {
                QRY = "SELECT Name,Phone_No,Address FROM [dbo].[Customers] WHERE Name like '%" + txtSeachCustomer.Text + "%'";
                try
                {
                    gvShowCustomer.DataSource = obj.tableData(QRY);
                }
                catch (Exception) { }
            }
        }
        private void generateReceipt()
        {
            StreamWriter obj = new StreamWriter(@"C:\Users\M.Siraj.Warsi\Desktop\Warsi\SCD Project\winPointOfSale\Sales Receipt\" + txtInvoiceNumber.Text + ".txt");
            QRY = "SELECT ProductName,Quantity,SalesPrice,TotalPrice FROM SaleDetails WHERE InvoiceNumber = "+txtInvoiceNumber.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);


                obj.WriteLine("\t\t     Point Of Sale\n");
                obj.WriteLine("\t\tInvoice No.:   " + txtInvoiceNumber.Text);
                obj.WriteLine("\t\tCustomer Name: " + txtCustomerName.Text);
                obj.WriteLine("\t\tPurchase Date: " + dtPurchaseDate.Text);
                obj.WriteLine();
                obj.WriteLine(String.Format("{0,-30}  |  {1,-8}  |  {2,-11}  |  {3,-11}", "Product Name","Quantity", "Sales Price", "Total Price"));
                obj.WriteLine();
                for (int i=0; i<(Convert.ToInt32(txtTotalProducts.Text)); i++)
                {
                    obj.WriteLine(String.Format("{0,-30}     {1,8}     {2,11}     {3,11}", ds.Tables[0].Rows[i][0].ToString(),ds.Tables[0].Rows[i][1].ToString(),ds.Tables[0].Rows[i][2].ToString(),ds.Tables[0].Rows[i][3].ToString()));
                }
                obj.WriteLine();
                obj.WriteLine("\t\t  Total Price: "+txtTotalPrice.Text);
                

            }
            catch (Exception) { }
            obj.Close();
        }

        #endregion
    }
}