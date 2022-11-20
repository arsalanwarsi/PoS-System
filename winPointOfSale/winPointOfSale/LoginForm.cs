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
using winPointOfSale.StaffForms;
using System.Data.SqlClient;
using System.Configuration;

namespace winPointOfSale
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        String QRY = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginVerification();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Method Implementation
        private void loginVerification()
        {
            QRY = "SELECT * FROM UsersLogin WHERE UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(QRY, con);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    string role = ds.Tables[0].Rows[0]["Role"].ToString().ToLower();
                    if (role == "admin")
                    {
                        this.Close();
                        AdminDashboardForm adf = new AdminDashboardForm();
                        adf.Show();
                    }
                    else// if (role == "staff")
                    {
                        this.Close();
                        StaffDashboardFrom sdf = new StaffDashboardFrom();
                        sdf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception) { }
        }
        #endregion
    }
}
