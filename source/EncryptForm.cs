using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();

            List<string> emailList = new List<string>();
            for (int i = 0; i<MainForm.dataBase.Count; i++)
            {
                if (i != MainForm.indexAccount)
                    emailList.Add(MainForm.dataBase[i].getEmail());
            }
            this.cbReceiver.DataSource = emailList;
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
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Filter = "ENC XML Files (*.enc)|*.enc";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.tbSave.Text = Path.GetFullPath(sfd.FileName);
            }
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            if(tbPath.Text == "" || tbSave.Text == "")
            {
                if (tbPath.Text == "")
                    MessageBox.Show("File Path không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (tbSave.Text == "")
                    MessageBox.Show("Save (nơi lưu tập tin mã hóa) không được trống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string reciverPublicKey = "";
                for (int i = 0; i < MainForm.dataBase.Count; i++)
                {
                    if (MainForm.dataBase[i].getEmail() == this.cbReceiver.Text)
                    {
                        reciverPublicKey = MainForm.dataBase[i].getPublicKey();
                        break;
                    }
                }

                if (MainForm.dataBase[MainForm.indexAccount].encryptFile(tbPath.Text, tbSave.Text, reciverPublicKey))
                    MessageBox.Show("Mã hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Mã hóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
