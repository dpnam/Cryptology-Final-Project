using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
            this.lbWarning.Visible = false;
        }

        private void tbPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (this.tbPath.Text == "")
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "ENC files (*.enc)|*.enc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.tbPath.Text = ofd.FileName;
            }
        }

        private void tbSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.tbSave.Text = Path.GetFullPath(sfd.FileName);
            }
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            if (MainForm.dataBase[MainForm.indexAccount].checkPassphrase(tbPassword.Text))
            {
                if(MainForm.dataBase[MainForm.indexAccount].decryptFile(tbPassword.Text, tbPath.Text, tbSave.Text))
                    MessageBox.Show("Giải mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Giải mã thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.lbWarning.Text = "Waring: Passsword sai!";
                this.lbWarning.ForeColor = Color.Red;
                this.lbWarning.Visible = true;
                this.tbPassword.Focus();
                this.tbPassword.SelectAll();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
