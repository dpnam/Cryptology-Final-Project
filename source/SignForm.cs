using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class SignForm : Form
    {
        public SignForm()
        {
            InitializeComponent();
            this.lbWarning.Visible = false;
        }

        private void tbPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (this.tbPath.Text == "")
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.tbPath.Text = ofd.FileName;
            }
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (this.tbSave.Text == "")
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.tbSave.Text = fbd.SelectedPath;
            }
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            if (MainForm.dataBase[MainForm.indexAccount].checkPassphrase(tbPassword.Text))
            {
                string nameFileSign = this.tbSave.Text + "\\" + Path.GetFileName(tbPath.Text) + ".sig";

                if (MainForm.dataBase[MainForm.indexAccount].signData(tbPassword.Text, tbPath.Text, nameFileSign))
                    MessageBox.Show("Ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
