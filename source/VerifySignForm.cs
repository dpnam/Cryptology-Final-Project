using System;
using System.Windows.Forms;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class VerifySignForm : Form
    {
        public VerifySignForm()
        {
            InitializeComponent();
        }

        private void tbData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (this.tbData.Text == "")
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.tbData.Text = ofd.FileName;
            }
        }

        private void tbSign_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (this.tbSign.Text == "")
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "SIG files (*.sig)|*.sig";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.tbSign.Text = ofd.FileName;
            }
        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            if(MainForm.dataBase[MainForm.indexAccount].verifySignData(tbData.Text, tbSign.Text) == false)
                MessageBox.Show("Xác nhận chữ ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
