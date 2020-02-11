using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.lbWarning.Visible = false;          
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
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
                this.lbWarning.Text = "Waring: Email không hợp lệ!";
                this.lbWarning.Visible = true;
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private bool checkValidPassword()
        {

            this.lbWarning.Visible = false;

            if (this.txtPassword.Text == "")
            {
                this.lbWarning.Text = "Waring: Không để trống mật khẩu!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }
            return true;
        }

        private bool checkLogin()
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            lbWarning.Visible = false;

            if (checkValidEmail() == false) return false;
            if (checkValidPassword() == false) return false;

            for (int i = 0; i < MainForm.dataBase.Count; i++)
            {
                if ((MainForm.dataBase[i].getEmail() == this.txtEmail.Text) && (MainForm.dataBase[i].checkPassphrase(this.txtPassword.Text)))
                {
                    // MessageBox.Show("Đăng nhập thành công", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm.indexAccount = i;
                    this.Close();
                    return true;
                }
            }

            lbWarning.Text = "Warning: Email hoặc Password sai!";
            lbWarning.Visible = true;
            txtPassword.Focus();
            txtPassword.SelectAll();

            return false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Enter)
            {
                checkLogin();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            checkValidEmail();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            checkValidPassword();
        }
    }
}
