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
    public partial class SaleDetailsForm : MetroFramework.Forms.MetroForm
    {
        #region Definitaion Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        public string invoice = string.Empty;

        public SaleDetailsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaleDetailsForm_Load(object sender, EventArgs e)
        {
            bindGrid();
        }
        #endregion

        #region Methods Implementation
        private void bindGrid()
        {
            string QRY = " SELECT s.InvoiceNumber,s.PurchaseDate,d.ProductName,d.Quantity,d.SalesPrice,d.TotalPrice FROM Sales s inner join SaleDetails d ON s.InvoiceNumber = d.InvoiceNumber WHERE s.InvoiceNumber = "+invoice;
            try
            {
                gvSaleDetails.DataSource = obj.tableData(QRY);
            }
            catch (Exception) { }
        }
        #endregion
    }
}
