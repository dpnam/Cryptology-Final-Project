namespace MHTT_UD
{
    partial class EditInformationForm
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
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbConfirmPassWord = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbEditInformation = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.cbChangePassword = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(132, 244);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(212, 20);
            this.txtConfirmPassword.TabIndex = 28;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(132, 218);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(212, 20);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(132, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 20);
            this.txtAddress.TabIndex = 26;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 25;
            // 
            // lbConfirmPassWord
            // 
            this.lbConfirmPassWord.AutoSize = true;
            this.lbConfirmPassWord.Location = new System.Drawing.Point(17, 247);
            this.lbConfirmPassWord.Name = "lbConfirmPassWord";
            this.lbConfirmPassWord.Size = new System.Drawing.Size(104, 13);
            this.lbConfirmPassWord.TabIndex = 24;
            this.lbConfirmPassWord.Text = "Confirm Password (*)";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(17, 221);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(91, 13);
            this.lbNewPassword.TabIndex = 23;
            this.lbNewPassword.Text = "New Password (*)";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(17, 139);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Text = "Address";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(17, 110);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 21;
            this.lbPhone.Text = "Phone";
            // 
            // dateBirthday
            // 
            this.dateBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthday.Location = new System.Drawing.Point(132, 80);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(212, 20);
            this.dateBirthday.TabIndex = 20;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(132, 51);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(212, 20);
            this.txtFullName.TabIndex = 19;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(17, 81);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbBirthday.TabIndex = 18;
            this.lbBirthday.Text = "Birthday";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(17, 54);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(54, 13);
            this.lbFullName.TabIndex = 17;
            this.lbFullName.Text = "Full Name";
            // 
            // lbEditInformation
            // 
            this.lbEditInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEditInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditInformation.Location = new System.Drawing.Point(0, 0);
            this.lbEditInformation.Name = "lbEditInformation";
            this.lbEditInformation.Size = new System.Drawing.Size(369, 41);
            this.lbEditInformation.TabIndex = 29;
            this.lbEditInformation.Text = "Edit Information";
            this.lbEditInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(17, 274);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(47, 13);
            this.lbWarning.TabIndex = 31;
            this.lbWarning.Text = "Warning";
            this.lbWarning.Visible = false;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(182, 284);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(80, 30);
            this.btSave.TabIndex = 30;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbChangePassword
            // 
            this.cbChangePassword.AutoSize = true;
            this.cbChangePassword.Location = new System.Drawing.Point(20, 169);
            this.cbChangePassword.Name = "cbChangePassword";
            this.cbChangePassword.Size = new System.Drawing.Size(111, 17);
            this.cbChangePassword.TabIndex = 32;
            this.cbChangePassword.Text = "Change password";
            this.cbChangePassword.UseVisualStyleBackColor = true;
            this.cbChangePassword.CheckedChanged += new System.EventHandler(this.cbChangePassword_CheckedChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(282, 284);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 30);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(132, 192);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(212, 20);
            this.txtOldPassword.TabIndex = 35;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.Location = new System.Drawing.Point(17, 195);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(85, 13);
            this.lbOldPassword.TabIndex = 34;
            this.lbOldPassword.Text = "Old Password (*)";
            // 
            // EditInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 326);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lbOldPassword);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbChangePassword);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbEditInformation);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbConfirmPassWord);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbFullName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInformationForm";
            this.ShowIcon = false;
            this.Text = "Edit Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbConfirmPassWord;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbEditInformation;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.CheckBox cbChangePassword;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lbOldPassword;
    }
}