using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class RegisterForm : Form
    {
        public bool isRegister = false;

        public RegisterForm()
        {
            InitializeComponent();

            List<int> keySizeList = new List<int>();
            for (int i = 1024; i >= 512; i -= 64)
                keySizeList.Add(i);
            this.cbKeySize.DataSource = keySizeList;
            this.dateBirthday.Value = DateTime.Now;
        }

        private bool checkRegister()
        {
            this.lbWarning.Visible = false;
            if (MainForm.dataBase == null)
            {
                this.lbWarning.Text = "Waring: Không có dataBase";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                this.lbWarning.Text = "";
                return false;
            }

            if (checkValidEmail() == false) return false;
            if (checkValidPassword() == false) return false;

            MainForm.dataBase.Add(new Account()
                             .inputInfo(
                                        this.txtEmail.Text,
                                        this.txtFullName.Text,
                                        this.dateBirthday.Value.Date.ToString("dd/MM/yyyy"),
                                        this.txtPhone.Text,
                                        this.txtAddress.Text
                                       )
                            .createPassphraseWithSalt(this.txtPassword.Text)
                            .createKey(this.txtPassword.Text, (int)this.cbKeySize.SelectedItem));

            MainForm.indexAccount = MainForm.dataBase.Count - 1;

            return true;
        }

        private bool checkValidEmail()
        {
            this.lbWarning.Visible = false;

            if (this.txtEmail.Text == "")
            {
                this.lbWarning.Text = "Waring: Không để trống email!";
                this.lbWarning.Visible = true;
                txtEmail.Focus();
                return false;
            }

            //https://avtartime.com/email-validation-using-regular-expression-in-c-sharp/
            if (!Regex.IsMatch(this.txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                this.lbWarning.Text = "Waring: Địa chỉ email không hợp lệ!";
                this.lbWarning.Visible = true;
                txtEmail.Focus();
                return false;
            }

            for (int i = 0; i < MainForm.dataBase.Count; i++)
            {
                if (MainForm.dataBase[i].getEmail() == this.txtEmail.Text)
                {
                    this.lbWarning.Text = "Waring: Email đã được người khác sử dụng!";
                    this.lbWarning.ForeColor = Color.Red;
                    this.lbWarning.Visible = true;
                    return false;
                }
            }

            return true;
        }

        private bool checkValidPassword()
        {
            this.lbWarning.Visible = false;

            if (this.txtPassword.Text == "")
            {
                this.lbWarning.Text = "Waring: Không để trống Password!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }
            if (this.txtPassword.Text != this.txtConfirmPassword.Text)
            {
                this.lbWarning.Text = "Waring: Password không giống ở trên!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }
            return true;
        }

        private void btRegisterNow_Click(object sender, EventArgs e)
        {
            this.isRegister = checkRegister();
            if (this.isRegister == true)
                this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            checkValidEmail();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            checkValidPassword();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
