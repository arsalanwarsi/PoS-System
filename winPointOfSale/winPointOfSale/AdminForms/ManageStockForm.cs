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
    public partial class ManageStockForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;
        String productID = String.Empty;

        public ManageStockForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            cleanFields();
        }
        private void ManageStockForm_Load(object sender, EventArgs e)
        {
            bindGrid();
            cbSizeLoad();
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            addProduct();
            bindGrid();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            productRecords();
        }
        private void gvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                productID = gvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            searchProdcut();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (!(productID == string.Empty))
            {
                deleteProductRecord();
            }
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (!(productID == string.Empty))
            {
                updateProductRecord();
            }
        }
        #endregion

        #region Methods Implementation
        private void cleanFields()
        {
            txtProductName.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            cbCategory.SelectedIndex = -1;
            cbSize.SelectedIndex = -1;
            dtDateOfEntry.Value = DateTime.Now;
        }
        private void cbSizeLoad()
        {
            QRY = "SELECT Size FROM Sizes";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
                {
                    cbSize.Items.Add(ds.Tables[0].Rows[i]["Size"].ToString());
                }
            }
            catch (Exception) { }
        }
        private void bindGrid()
        {
            QRY = "SELECT * FROM [dbo].[Products]";
            try
            {
                gvProductList.DataSource = obj.tableData(QRY);
                gvProducts.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void addProduct()
        {
            if (txtProductName.Text == String.Empty || txtPurchasePrice.Text == String.Empty || txtSalePrice.Text == string.Empty || cbCategory.Text == string.Empty || cbSize.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRY = "INSERT INTO [dbo].[Products] (Name,Category,Size,PurchasePrice,SalesPrice,DateOfEntry) VALUES ('" + txtProductName.Text + "','" + cbCategory.Text + "','" + cbSize.Text + "'," + txtPurchasePrice.Text + "," + txtSalePrice.Text + ",'" + dtDateOfEntry.Text + "')";
                try
                {
                    DatabaseService dd = new DatabaseService();
                    dd.DMLOperations(QRY);
                    MessageBox.Show("Product Save Successfully", "Product Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Product Did Not Save", "Product Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void productRecords()
        {
            QRY = "SELECT * FROM [dbo].[Products] WHERE DateOfEntry >= '" + dtpListFrom.Text +"' and DateOfEntry <= '"+ dtpListTo.Text +"'; ";
            try
            {
                gvProductList.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void deleteProductRecord()
        {
            if (MessageBox.Show("Do You Want to Delete Product Record", "Producct Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                QRY = "DELETE FROM [dbo].[Products] Where ProductID = " + productID;
                try
                {
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Product Record Deleted", "Product Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Product Record Did Not Delete", "Product Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            productID = string.Empty;
        }
        private void searchProdcut()
        {
            QRY = "SELECT * FROM Products WHERE Name like '%" + txtSearchProduct.Text + "%'";
            try
            {
                gvProducts.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        private void updateProductRecord()
        {
            UpdateProductForm upf = new UpdateProductForm();
            upf.productID = productID;
            upf.ShowDialog();
            bindGrid();
            productID = string.Empty;
        }
        #endregion
    }
}
