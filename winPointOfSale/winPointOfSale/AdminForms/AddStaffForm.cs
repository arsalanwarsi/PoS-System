using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using winPointOfSale.Services;

namespace winPointOfSale.AdminForms
{
    public partial class AddStaffForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();
        String QRY = string.Empty;

        public AddStaffForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertRecord();
        }
        #endregion

        #region Methods Implementation
        private void insertRecord()
        {
            if (txtUserName.Text == String.Empty || txtPassword.Text == String.Empty || txtConfirmPassword.Text == string.Empty || cbRole.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txtPassword.Text == txtConfirmPassword.Text)
                {
                    QRY = "insert into [dbo].[UsersLogin] (UserName,Password,Role) values ('" + txtUserName.Text.Replace(" ", "") + "','" + txtPassword.Text.Replace(" ", "") + "','" + cbRole.Text + "')";
                    try
                    {
                        obj.DMLOperations(QRY);
                        MessageBox.Show("Data Save Successfully", "User Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Record Did Not Save", "User Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password Not Match", "User Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}