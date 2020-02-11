namespace MHTT_UD
{
    partial class RegisterForm
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbConfirmPassWord = new System.Windows.Forms.Label();
            this.lbKeySize = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbKeySize = new System.Windows.Forms.ComboBox();
            this.btRegisterNow = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(25, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email (*)";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(25, 71);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(54, 13);
            this.lbFullName.TabIndex = 3;
            this.lbFullName.Text = "Full Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(25, 103);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(45, 13);
            this.lbBirthday.TabIndex = 5;
            this.lbBirthday.Text = "Birthday";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(140, 68);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(212, 20);
            this.txtFullName.TabIndex = 6;
            // 
            // dateBirthday
            // 
            this.dateBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBirthday.Location = new System.Drawing.Point(140, 97);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(212, 20);
            this.dateBirthday.TabIndex = 7;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(25, 127);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "Phone";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(25, 156);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(25, 182);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password (*)";
            // 
            // lbConfirmPassWord
            // 
            this.lbConfirmPassWord.AutoSize = true;
            this.lbConfirmPassWord.Location = new System.Drawing.Point(25, 208);
            this.lbConfirmPassWord.Name = "lbConfirmPassWord";
            this.lbConfirmPassWord.Size = new System.Drawing.Size(104, 13);
            this.lbConfirmPassWord.TabIndex = 11;
            this.lbConfirmPassWord.Text = "Confirm Password (*)";
            // 
            // lbKeySize
            // 
            this.lbKeySize.AutoSize = true;
            this.lbKeySize.Location = new System.Drawing.Point(25, 235);
            this.lbKeySize.Name = "lbKeySize";
            this.lbKeySize.Size = new System.Drawing.Size(61, 13);
            this.lbKeySize.TabIndex = 12;
            this.lbKeySize.Text = "Key Size (*)";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(140, 124);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 20);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(140, 205);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(212, 20);
            this.txtConfirmPassword.TabIndex = 16;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // cbKeySize
            // 
            this.cbKeySize.FormattingEnabled = true;
            this.cbKeySize.Location = new System.Drawing.Point(140, 232);
            this.cbKeySize.Name = "cbKeySize";
            this.cbKeySize.Size = new System.Drawing.Size(212, 21);
            this.cbKeySize.TabIndex = 17;
            // 
            // btRegisterNow
            // 
            this.btRegisterNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterNow.Location = new System.Drawing.Point(165, 288);
            this.btRegisterNow.Name = "btRegisterNow";
            this.btRegisterNow.Size = new System.Drawing.Size(94, 30);
            this.btRegisterNow.TabIndex = 18;
            this.btRegisterNow.Text = "Register Now";
            this.btRegisterNow.UseVisualStyleBackColor = true;
            this.btRegisterNow.Click += new System.EventHandler(this.btRegisterNow_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(0, 0);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(380, 29);
            this.lbRegister.TabIndex = 19;
            this.lbRegister.Text = "Register";
            this.lbRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(25, 265);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(47, 13);
            this.lbWarning.TabIndex = 21;
            this.lbWarning.Text = "Warning";
            this.lbWarning.Visible = false;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(280, 288);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 30);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.btRegisterNow);
            this.Controls.Add(this.cbKeySize);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbKeySize);
            this.Controls.Add(this.lbConfirmPassWord);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.dateBirthday);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbConfirmPassWord;
        private System.Windows.Forms.Label lbKeySize;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cbKeySize;
        private System.Windows.Forms.Button btRegisterNow;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Button btCancel;
    }
}