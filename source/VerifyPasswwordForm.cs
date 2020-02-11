using System;
using System.Drawing;
using System.Windows.Forms;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class VerifyPasswwordForm : Form
    {
        public VerifyPasswwordForm()
        {
            InitializeComponent();
        }

        private bool checkValidPassword()
        {

            this.lbWarning.Visible = false;

            if (this.tbPassword.Text == "")
            {
                this.lbWarning.Text = "Waring: Không để trống mật khẩu!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }

            if (MainForm.dataBase[MainForm.indexAccount].checkPassphrase(tbPassword.Text) == false)
            {
                this.lbWarning.Text = "Waring: Sai mật khẩu!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                tbPassword.Focus();
                return false;
            }

            return true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(checkValidPassword() == true)
            {
                MainForm.verified = true;
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
