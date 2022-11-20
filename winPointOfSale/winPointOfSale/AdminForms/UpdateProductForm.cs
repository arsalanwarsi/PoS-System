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
    public partial class UpdateProductForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        public String productID = String.Empty;
        String QRY = string.Empty;

        public UpdateProductForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            cbSizeLoad();
            loadProductData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            updateProduct();
        }
        #endregion

        #region Methods Implementaion
        private void loadProductData()
        {
            QRY = "SELECT * FROM [dbo].[Products] WHERE ProductID = "+ productID;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtProductID.Text = ds.Tables[0].Rows[0][0].ToString().ToLower();
                txtProductName.Text = ds.Tables[0].Rows[0][1].ToString().ToLower();
                cbCategory.Text = ds.Tables[0].Rows[0][2].ToString().ToLower();
                cbSize.Text = ds.Tables[0].Rows[0][3].ToString().ToLower();
                txtPurchasePrice.Text = ds.Tables[0].Rows[0][4].ToString().ToLower();
                txtSalePrice.Text = ds.Tables[0].Rows[0][5].ToString().ToLower();
                dtDateOfEntry.Text = ds.Tables[0].Rows[0][6].ToString().ToLower();
                productID = String.Empty;
            }
            catch (Exception) { }
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
        private void updateProduct()
        {
            if (txtProductName.Text == String.Empty || txtPurchasePrice.Text == String.Empty || txtSalePrice.Text == string.Empty || cbCategory.Text == string.Empty || cbSize.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    QRY = "UPDATE [dbo].[Products] SET name = '" + txtProductName.Text + "', Category = '" + cbCategory.Text + "', Size = '" + cbSize.Text + "', PurchasePrice = " + txtPurchasePrice.Text + ", SalesPrice = " + txtSalePrice.Text + ", DateOfEntry = '" + dtDateOfEntry.Text + "' WHERE ProductID = " + txtProductID.Text;
                    obj.DMLOperations(QRY);
                    MessageBox.Show("Product Record Updated Successfully", "Product Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Product REcord Did Not Update", "Product Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        #endregion
    }
}
