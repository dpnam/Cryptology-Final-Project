using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public partial class MainForm : Form
    {
        private string linkDataBase = "DataBase.dbxml";
        public static List<Account> dataBase = new List<Account>();
        public static int indexAccount = -1;
        public static bool verified = false;

        private bool readDataBase()
        {
            string xml = File.ReadAllText(this.linkDataBase, Encoding.GetEncoding("UTF-8"));
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList accountNodeList = doc.GetElementsByTagName("account");
            if (accountNodeList.Count < 1) return false;

            for (int i = 0; i < accountNodeList.Count; i++)
            {
                try
                {
                    string _email = accountNodeList[i].SelectSingleNode("email").InnerText;
                    string _fullName = accountNodeList[i].SelectSingleNode("full_name").InnerText;
                    string _birthday = accountNodeList[i].SelectSingleNode("birthday").InnerText;
                    string _phone = accountNodeList[i].SelectSingleNode("phone").InnerText;
                    string _address = accountNodeList[i].SelectSingleNode("address").InnerText;
                    string _passphraseWithSalt = accountNodeList[i].SelectSingleNode("passphrase_with_salt").InnerText;
                    string _salt = accountNodeList[i].SelectSingleNode("salt").InnerText;
                    string _encryptedPrivateKey = accountNodeList[i].SelectSingleNode("encrypted_private_key").InnerText;
                    string _publicKey = accountNodeList[i].SelectSingleNode("public_key").InnerText;
                    Account acc = new Account(_email, _fullName, _birthday, _phone, _address, _passphraseWithSalt, _salt, _encryptedPrivateKey, _publicKey);
                    dataBase.Add(acc);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool writeDataBase()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode accountsNode = doc.CreateElement("accounts");
            doc.AppendChild(accountsNode);

            for (int i = 0; i < MainForm.dataBase.Count; i++)
            {
                XmlNode accountNode = doc.CreateElement("account");
                accountsNode.AppendChild(accountNode);

                XmlNode emailNode = doc.CreateElement("email");
                emailNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getEmail()));
                accountNode.AppendChild(emailNode);

                XmlNode fullNameNode = doc.CreateElement("full_name");
                fullNameNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getFullName()));
                accountNode.AppendChild(fullNameNode);

                XmlNode birthdayNode = doc.CreateElement("birthday");
                birthdayNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getBirthday()));
                accountNode.AppendChild(birthdayNode);

                XmlNode phoneNode = doc.CreateElement("phone");
                phoneNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getPhone()));
                accountNode.AppendChild(phoneNode);

                XmlNode addressNode = doc.CreateElement("address");
                addressNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getAddress()));
                accountNode.AppendChild(addressNode);

                XmlNode passphraseNode = doc.CreateElement("passphrase_with_salt");
                passphraseNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getPassphraseWithSalt()));
                accountNode.AppendChild(passphraseNode);

                XmlNode saltNode = doc.CreateElement("salt");
                saltNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getSalt()));
                accountNode.AppendChild(saltNode);

                XmlNode privateKeyNode = doc.CreateElement("encrypted_private_key");
                privateKeyNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getEncryptedPrivateKey()));
                accountNode.AppendChild(privateKeyNode);

                XmlNode publicKeyNode = doc.CreateElement("public_key");
                publicKeyNode.AppendChild(doc.CreateTextNode(MainForm.dataBase[i].getPublicKey()));
                accountNode.AppendChild(publicKeyNode);
            }

            BinaryWriter writer = new BinaryWriter(new FileStream(this.linkDataBase, FileMode.Truncate));

            byte[] buffer = Encoding.UTF8.GetBytes(doc.OuterXml);
            writer.Write(buffer, 0, buffer.Length);
            writer.Close();

            return true;
        }

        public MainForm()
        {
            InitializeComponent();
            statusNotLogin();

            readDataBase();
        }

        void statusNotLogin()
        {
            this.btEncrypt.Enabled = false;
            this.btDecrypt.Enabled = false;
            this.btSign.Enabled = false;
            this.btVerify.Enabled = false;
            this.exportToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem1.Enabled = false;
            this.logoutToolStripMenuItem.Enabled = false;

            this.importToolStripMenuItem.Enabled = true;
            this.loginToolStripMenuItem.Enabled = true;
            this.resgisterToolStripMenuItem.Enabled = true;

            this.lbUser.Text = "Vui lòng đăng nhập để sử dụng!";
            this.lbUser.ForeColor = Color.Red;
        }

        void statusLogin()
        {
            this.btEncrypt.Enabled = true;
            this.btDecrypt.Enabled = true;
            this.btSign.Enabled = true;
            this.btVerify.Enabled = true;
            this.exportToolStripMenuItem.Enabled = true;
            this.editToolStripMenuItem1.Enabled = true;
            this.logoutToolStripMenuItem.Enabled =true;

            this.importToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Enabled = false;
            this.resgisterToolStripMenuItem.Enabled = false;

            this.lbUser.Text = "User: " + MainForm.dataBase[MainForm.indexAccount].getEmail();
            this.lbUser.ForeColor = Color.Red;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();

            if (MainForm.indexAccount != -1) statusLogin();
        }

        private void resgisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();

            if (MainForm.indexAccount != -1) statusLogin();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerifyPasswwordForm verifyPassword = new VerifyPasswwordForm();
            verifyPassword.ShowDialog();

            if(MainForm.verified == true)
            {
                EditInformationForm editInformation = new EditInformationForm();
                editInformation.ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //in dữ liệu xuống data base

            MainForm.indexAccount = -1;
            statusNotLogin();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ACC XML Files (*.accxlm)|*.accxlm";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(MainForm.dataBase[MainForm.indexAccount].export());
                        stream.Write(buffer, 0, buffer.Length);
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ACC XML Files (*.accxml)|*.accxlm";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string xml = File.ReadAllText(openFileDialog.FileName, Encoding.GetEncoding("UTF-8"));
                    Account acc = new Account();
                    if (acc.import(xml))
                    {
                        for (int i = 0; i < MainForm.dataBase.Count; i++)
                        {
                            if (MainForm.dataBase[i].getEmail() == acc.getEmail())
                            {
                                MessageBox.Show("Account đã tồn tại trong DataBase!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        MainForm.dataBase.Add(acc);
                        MainForm.indexAccount = MainForm.dataBase.Count - 1;

                        this.statusLogin();
                    }
                    else MessageBox.Show("Import thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeDataBase();
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            EncryptForm encrypt = new EncryptForm();
            encrypt.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string info =
                "Đồ án thực hành - Mã hoá thông tin và Ứng dụng\n" +
                "\n" +
                "1612406 - Đặng Phương Nam\n";
            MessageBox.Show(info, "About me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/q_lGSQgvaRA");
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            DecryptForm decrypt = new DecryptForm();
            decrypt.ShowDialog();
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            SignForm sign = new SignForm();
            sign.ShowDialog();

        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            VerifySignForm verifySign = new VerifySignForm();
            verifySign.ShowDialog();
        }
    }
}
