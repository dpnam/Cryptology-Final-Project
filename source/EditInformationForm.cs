using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class EditInformationForm : Form
    {
        private bool changedPassword = false;

        public EditInformationForm()
        {
            InitializeComponent();
            showInfo();
        }

        private bool checkValidPassword()
        {
            this.lbWarning.Visible = false;

            if (this.txtOldPassword.Text == "" || this.txtNewPassword.Text == "")
            {
                this.lbWarning.Text = "Waring: Không để trống Password!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }
            if (this.txtNewPassword.Text != this.txtConfirmPassword.Text)
            {
                this.lbWarning.Text = "Waring: Xác thực Password không giống Password mới!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                return false;
            }
            return true;
        }

        private void showInfo()
        {
            int id = MainForm.indexAccount;
            this.txtFullName.Text = MainForm.dataBase[id].getFullName();
            this.dateBirthday.Value = DateTime.ParseExact(MainForm.dataBase[id].getBirthday(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.txtPhone.Text = MainForm.dataBase[id].getPhone();
            this.txtAddress.Text = MainForm.dataBase[id].getAddress();

            this.txtNewPassword.Enabled = false;
            this.txtConfirmPassword.Enabled = false;
            this.txtOldPassword.Enabled = false;
        }

        private bool checkEditInfor()
        {
            int id = MainForm.indexAccount;
            MainForm.dataBase[id].setFullName(this.txtFullName.Text);
            MainForm.dataBase[id].setBirthday(this.dateBirthday.Value.Date.ToString("dd/MM/yyyy"));
            MainForm.dataBase[id].setPhoneNumber(this.txtPhone.Text);
            MainForm.dataBase[id].setAddress(this.txtAddress.Text);

            if (changedPassword == true)
            {
                if (checkValidPassword() == true)
                {
                    bool successed = MainForm.dataBase[MainForm.indexAccount].setPassphrase(this.txtOldPassword.Text, this.txtNewPassword.Text);
                    if (successed == false)
                    {
                        this.lbWarning.Text = "Waring: Nhập Password cũ không chính xác!";
                        this.lbWarning.ForeColor = Color.Red;
                        this.lbWarning.Visible = true;
                        return false;
                    }
                }
                else return false;

            }
            return true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (checkEditInfor() == true)
            {
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbChangePassword.Checked == true)
            {
                this.txtOldPassword.Enabled = true;
                this.txtNewPassword.Enabled = true;
                this.txtConfirmPassword.Enabled = true;

                this.changedPassword = true;
            }
            else
            {
                this.txtOldPassword.Enabled = false;
                this.txtNewPassword.Enabled = false;
                this.txtConfirmPassword.Enabled = false;

                this.changedPassword = false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
