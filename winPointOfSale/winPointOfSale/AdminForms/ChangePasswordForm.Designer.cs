
namespace winPointOfSale.AdminForms
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.ChangePasswordPanel = new MetroFramework.Controls.MetroPanel();
            this.UserName = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.NewPassword = new MetroFramework.Controls.MetroLabel();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmPassword = new MetroFramework.Controls.MetroLabel();
            this.ChangePasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePasswordPanel
            // 
            this.ChangePasswordPanel.Controls.Add(this.UserName);
            this.ChangePasswordPanel.Controls.Add(this.btnUpdate);
            this.ChangePasswordPanel.Controls.Add(this.txtUserName);
            this.ChangePasswordPanel.Controls.Add(this.btnBack);
            this.ChangePasswordPanel.Controls.Add(this.txtConfirmPassword);
            this.ChangePasswordPanel.Controls.Add(this.NewPassword);
            this.ChangePasswordPanel.Controls.Add(this.txtNewPassword);
            this.ChangePasswordPanel.Controls.Add(this.ConfirmPassword);
            this.ChangePasswordPanel.HorizontalScrollbarBarColor = true;
            this.ChangePasswordPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ChangePasswordPanel.HorizontalScrollbarSize = 10;
            this.ChangePasswordPanel.Location = new System.Drawing.Point(23, 63);
            this.ChangePasswordPanel.Name = "ChangePasswordPanel";
            this.ChangePasswordPanel.Size = new System.Drawing.Size(319, 189);
            this.ChangePasswordPanel.TabIndex = 30;
            this.ChangePasswordPanel.VerticalScrollbarBarColor = true;
            this.ChangePasswordPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ChangePasswordPanel.VerticalScrollbarSize = 10;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(2, 16);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(78, 19);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "User Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(188, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(126, 12);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter User Name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(189, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter User Name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(31, 143);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseCustomForeColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(127, 90);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PromptText = "Enter Confirm Password";
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(189, 23);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.WaterMark = "Enter Confirm Password";
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(2, 55);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(96, 19);
            this.NewPassword.TabIndex = 8;
            this.NewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(126, 51);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PromptText = "Enter New Password";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(189, 23);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.WaterMark = "Enter New Password";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(3, 90);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(118, 19);
            this.ConfirmPassword.TabIndex = 19;
            this.ConfirmPassword.Text = "Confirm Password:";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 275);
            this.Controls.Add(this.ChangePasswordPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Resizable = false;
            this.Text = "Change Password";
            this.ChangePasswordPanel.ResumeLayout(false);
            this.ChangePasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ChangePasswordPanel;
        private MetroFramework.Controls.MetroLabel UserName;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroLabel NewPassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroLabel ConfirmPassword;
    }
}