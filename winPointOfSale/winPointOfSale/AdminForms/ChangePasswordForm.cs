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
    public partial class ChangePasswordForm : MetroFramework.Forms.MetroForm
    {
        #region Definition Block
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        DatabaseService obj = new DatabaseService();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events Handler
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePassword();
        }
        #endregion

        #region Methods Implementation
        private void updatePassword()
        {
            if (txtUserName.Text == String.Empty || txtNewPassword.Text == String.Empty || txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter All Details", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    String QRY = "update [dbo].[UsersLogin] set Password = '" + txtNewPassword.Text.Replace(" ", "") + "' where UserName = '" + txtUserName.Text.Replace(" ", "") + "'";
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
