
namespace winPointOfSale.AdminForms
{
    partial class AddStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.AddStaffPanel = new MetroFramework.Controls.MetroPanel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.cbRole = new MetroFramework.Controls.MetroComboBox();
            this.UserName = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.Role = new MetroFramework.Controls.MetroLabel();
            this.ConfirmPassword = new MetroFramework.Controls.MetroLabel();
            this.AddStaffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStaffPanel
            // 
            this.AddStaffPanel.Controls.Add(this.txtUserName);
            this.AddStaffPanel.Controls.Add(this.cbRole);
            this.AddStaffPanel.Controls.Add(this.UserName);
            this.AddStaffPanel.Controls.Add(this.btnSave);
            this.AddStaffPanel.Controls.Add(this.btnBack);
            this.AddStaffPanel.Controls.Add(this.txtConfirmPassword);
            this.AddStaffPanel.Controls.Add(this.Password);
            this.AddStaffPanel.Controls.Add(this.txtPassword);
            this.AddStaffPanel.Controls.Add(this.Role);
            this.AddStaffPanel.Controls.Add(this.ConfirmPassword);
            this.AddStaffPanel.HorizontalScrollbarBarColor = true;
            this.AddStaffPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddStaffPanel.HorizontalScrollbarSize = 10;
            this.AddStaffPanel.Location = new System.Drawing.Point(23, 63);
            this.AddStaffPanel.Name = "AddStaffPanel";
            this.AddStaffPanel.Size = new System.Drawing.Size(319, 227);
            this.AddStaffPanel.TabIndex = 29;
            this.AddStaffPanel.VerticalScrollbarBarColor = true;
            this.AddStaffPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddStaffPanel.VerticalScrollbarSize = 10;
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
            this.txtUserName.Location = new System.Drawing.Point(127, 12);
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
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 23;
            this.cbRole.Items.AddRange(new object[] {
            "Staff",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(127, 129);
            this.cbRole.Name = "cbRole";
            this.cbRole.PromptText = "Select Role";
            this.cbRole.Size = new System.Drawing.Size(189, 29);
            this.cbRole.TabIndex = 4;
            this.cbRole.UseSelectable = true;
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(188, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(31, 181);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 6;
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
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(2, 55);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 19);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password:";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(127, 51);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PromptText = "Enter Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(189, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(3, 129);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(38, 19);
            this.Role.TabIndex = 21;
            this.Role.Text = "Role:";
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
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 313);
            this.Controls.Add(this.AddStaffPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStaffForm";
            this.Resizable = false;
            this.Text = "Add New Employee";
            this.AddStaffPanel.ResumeLayout(false);
            this.AddStaffPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel AddStaffPanel;
        private MetroFramework.Controls.MetroLabel UserName;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel Role;
        private MetroFramework.Controls.MetroLabel ConfirmPassword;
        private MetroFramework.Controls.MetroComboBox cbRole;
        private MetroFramework.Controls.MetroTextBox txtUserName;
    }
}