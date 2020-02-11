using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Xml;
//1612406 - Đặng Phương Nam

namespace MHTT_UD
{
    public class Account
    {
        private string email;
        private string fullName;
        private string birthday;
        private string phone;
        private string address;
        private string passphraseWithSalt;
        private string salt;
        private string encryptedPrivateKey;
        private string publicKey;

        //Constructor
        public Account()
        {
            this.email = null;
            this.fullName = "";
            this.birthday = "";
            this.phone = "";
            this.address = "";
            this.passphraseWithSalt = "";
            this.salt = "";
            this.publicKey = "";
            this.encryptedPrivateKey = "";
        }
        public Account(string _email, string _fullName, string _birthday, string _phone, string _address, string _passphraseWithSalt, string _salt, string _encryptedPrivateKey, string _publicKey)
        {
            this.email = _email;
            this.fullName = _fullName;
            this.birthday = _birthday;
            this.phone = _phone;
            this.address = _address;
            this.passphraseWithSalt = _passphraseWithSalt;
            this.salt = _salt;
            this.encryptedPrivateKey = _encryptedPrivateKey;
            this.publicKey = _publicKey;
        }
        public Account(Account _account)
        {
            this.email = _account.email;
            this.fullName = _account.fullName;
            this.birthday = _account.birthday;
            this.phone = _account.phone;
            this.address = _account.address;
            this.passphraseWithSalt = _account.passphraseWithSalt;
            this.salt = _account.salt;
            this.encryptedPrivateKey = _account.encryptedPrivateKey;
            this.publicKey = _account.publicKey;
        }

        //Gán information cho account
        public Account inputInfo(string _email, string _fullName, string _birthday, string _phone, string _address)
        {
            this.email = _email;
            this.fullName = _fullName;
            this.birthday = _birthday;
            this.phone = _phone;
            this.address = _address;
            return this;
        }

        //Setter
        public void setFullName(string _fullName)
        {
            this.fullName = _fullName;
        }
        public void setBirthday(string _birthday)
        {
            this.birthday = _birthday;
        }
        public void setPhoneNumber(string _phone)
        {
            this.phone = _phone;
        }
        public void setAddress(string _address)
        {
            this.address = _address;
        }
        public bool setPassphrase(string _oldPassphrase, string _newPassphrase)
        {
            if (this.checkPassphrase(_oldPassphrase))
            {
                //Hash mật khẩu mới với salt
                createPassphraseWithSalt(_newPassphrase);

                //Lấy ra private key
                string private_key = decryptSymmetric(_oldPassphrase, Convert.FromBase64String(encryptedPrivateKey));

                //Mã hóa private key lại với password mới
                this.encryptedPrivateKey = Convert.ToBase64String(encryptSymmetric(_newPassphrase, private_key));

                return true;
            }
            return false;
        }

        //Getter
        public string getEmail()
        {
            return this.email;
        }
        public string getFullName()
        {
            return this.fullName;
        }
        public string getBirthday()
        {
            return this.birthday;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getPassphraseWithSalt()
        {
            return this.passphraseWithSalt;
        }
        public string getSalt()
        {
            return this.salt;
        }
        public string getEncryptedPrivateKey()
        {
            return this.encryptedPrivateKey;
        }
        public string getPublicKey()
        {
            return this.publicKey;
        }

        //Hàm mã hóa đối xứng AES
        private static byte[] encryptSymmetric(string _key, string _plaintext)
        {
            //Hash key
            SHA256 sha256 = SHA256.Create();
            byte[] hashKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(_key));

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.Key = hashKey;
            aes.GenerateIV();

            ICryptoTransform encryptor = aes.CreateEncryptor();

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(_plaintext);
                    }

                    byte[] encryptedText = msEncrypt.ToArray();
                    byte[] res = new byte[aes.IV.Length + encryptedText.Length];
                    Buffer.BlockCopy(aes.IV, 0, res, 0, aes.IV.Length);
                    Buffer.BlockCopy(encryptedText, 0, res, aes.IV.Length, encryptedText.Length);
                    return res;
                }
            }
        }

        //Hàm giải mã đối xứng AES
        private static string decryptSymmetric(string _key, byte[] _ciphertext)
        {
            //Hash key
            SHA256 sha256 = SHA256.Create();
            byte[] hashKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(_key));

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC;
            aes.Key = hashKey;
            aes.GenerateIV();
            aes.IV = _ciphertext.Take(aes.IV.Length).ToArray();

            ICryptoTransform decryptor = aes.CreateDecryptor();
            try
            {
                using (MemoryStream msDecrypt = new MemoryStream(_ciphertext.Skip(aes.IV.Length).ToArray()))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        //Hàm hash passphrase + salt: sử dụng SHA256
        public Account createPassphraseWithSalt(string _passphrase)
        {

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] _salt = new byte[256 / 8];
            rng.GetBytes(_salt);
            this.salt = Convert.ToBase64String(_salt);

            byte[] passphareWithSalt = new byte[_passphrase.Length + 256 / 8];
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(_passphrase), 0, passphareWithSalt, 0, _passphrase.Length);
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(this.salt), 0, passphareWithSalt, _passphrase.Length, 256 / 8);

            SHA256 sha256 = SHA256.Create();
            byte[] hashPassphraseWithSalt = sha256.ComputeHash(passphareWithSalt);

            this.passphraseWithSalt = Convert.ToBase64String(hashPassphraseWithSalt);

            return this;
        }

        //Hàm kiểm tra Passphrase
        public bool checkPassphrase(string _passphrase)
        {
            byte[] passphareWithSalt = new byte[_passphrase.Length + 256 / 8];
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(_passphrase), 0, passphareWithSalt, 0, _passphrase.Length);
            Buffer.BlockCopy(Encoding.UTF8.GetBytes(this.salt), 0, passphareWithSalt, _passphrase.Length, 256 / 8);

            SHA256 sha256 = SHA256.Create();
            byte[] hashPassphraseWithSalt = sha256.ComputeHash(passphareWithSalt);

            if (this.passphraseWithSalt == Convert.ToBase64String(hashPassphraseWithSalt)) return true;
            else return false;
        }

        //Hàm tạo private key(mã hóa đối xứng bởi passphrase) và public key
        public Account createKey(string _passphrase, int nbits)
        {
            //Kiểm tra nbits mà user chọn
            if (nbits < 512) nbits = 512;
            else if (nbits > 1024) nbits = 1024;
            else nbits = (nbits / 64) * 64;

            //Sử dụng thuật toán mã hóa RSA
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(nbits);

            //Mã hóa private key(dùng mã hóa bất đối xứng với key là passpharse)
            this.encryptedPrivateKey = Convert.ToBase64String(encryptSymmetric(_passphrase, rsa.ToXmlString(true)));

            //Lấy public key
            this.publicKey = rsa.ToXmlString(false);

            return this;
        }

        //Hàm export thông tin account
        public string export()
        {
            //https://forums.asp.net/t/1407620.aspx?Good+Example+of+how+to+create+a+Xml+Document+Programmatically+

            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode accountNode = doc.CreateElement("account");
            doc.AppendChild(accountNode);

            XmlNode emailNode = doc.CreateElement("email");
            emailNode.AppendChild(doc.CreateTextNode(this.email));
            accountNode.AppendChild(emailNode);

            XmlNode fullNameNode = doc.CreateElement("full_name");
            fullNameNode.AppendChild(doc.CreateTextNode(this.fullName));
            accountNode.AppendChild(fullNameNode);

            XmlNode birthdayNode = doc.CreateElement("birthday");
            birthdayNode.AppendChild(doc.CreateTextNode(this.birthday));
            accountNode.AppendChild(birthdayNode);

            XmlNode phoneNumberNode = doc.CreateElement("phone");
            phoneNumberNode.AppendChild(doc.CreateTextNode(this.phone));
            accountNode.AppendChild(phoneNumberNode);

            XmlNode addressNode = doc.CreateElement("address");
            addressNode.AppendChild(doc.CreateTextNode(this.address));
            accountNode.AppendChild(addressNode);

            XmlNode passphraseNode = doc.CreateElement("passphrase_with_salt");
            passphraseNode.AppendChild(doc.CreateTextNode(this.passphraseWithSalt));
            accountNode.AppendChild(passphraseNode);

            XmlNode saltNode = doc.CreateElement("salt");
            saltNode.AppendChild(doc.CreateTextNode(this.salt));
            accountNode.AppendChild(saltNode);

            XmlNode privateKeyNode = doc.CreateElement("encrypted_private_key");
            privateKeyNode.AppendChild(doc.CreateTextNode(this.encryptedPrivateKey));
            accountNode.AppendChild(privateKeyNode);

            XmlNode publicKeyNode = doc.CreateElement("public_key");
            publicKeyNode.AppendChild(doc.CreateTextNode(this.publicKey));
            accountNode.AppendChild(publicKeyNode);

            return doc.OuterXml;
        }

        //Hàm import thông tin account
        public bool import(string xml)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmlelement.getelementsbytagname?view=netframework-4.8

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            XmlNodeList accountNodeList = doc.GetElementsByTagName("account");
            if (accountNodeList.Count != 1) return false;
            XmlNode accountNode = accountNodeList[0];

            try
            {
                this.email = accountNode.SelectSingleNode("email").InnerText;
                this.fullName = accountNode.SelectSingleNode("full_name").InnerText;
                this.birthday = accountNode.SelectSingleNode("birthday").InnerText;
                this.phone = accountNode.SelectSingleNode("phone").InnerText;
                this.address = accountNode.SelectSingleNode("address").InnerText;
                this.passphraseWithSalt = accountNode.SelectSingleNode("passphrase_with_salt").InnerText;
                this.salt = accountNode.SelectSingleNode("salt").InnerText;
                this.encryptedPrivateKey = accountNode.SelectSingleNode("encrypted_private_key").InnerText;
                this.publicKey = accountNode.SelectSingleNode("public_key").InnerText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //Hàm mã hóa bất đối xứng: mã hóa bất đối xứng RSA với public key
        public byte[] encryptAsymmetric(string _publicKey, byte[] _plaintext)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(_publicKey);
                return rsa.Encrypt(_plaintext, false);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Hàm giải mã bất đối xứng: mã hóa bất đối xứng RSA với private key
        public byte[] decryptAsymmetric(string _passphrase, byte[] _ciphertext)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(decryptSymmetric(_passphrase, Convert.FromBase64String(this.encryptedPrivateKey)));

                return rsa.Decrypt(_ciphertext, false);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Hàm mã hóa data: theo yêu cầu đề bài
        public bool encryptFile(string _linkFilePlainText, string _linkSaveFileEncrypt, string _receiverPublicKey)
        {
            try
            {
                byte[] dataPlainText = File.ReadAllBytes(_linkFilePlainText);
                byte[] encryptedText;

                //Lấy phần mở rộng của tập tin plaintex
                string extensionFileName = Path.GetExtension(_linkFilePlainText);

                //Phần mã hóa đối xứng AES cho plaintext với K_c hệ thống tự phát sinh
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;
                aes.GenerateKey();
                aes.GenerateIV();

                ICryptoTransform encryptor = aes.CreateEncryptor();
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(dataPlainText, 0, dataPlainText.Length);
                        csEncrypt.FlushFinalBlock();
                        encryptedText = msEncrypt.ToArray();
                    }
                }

                //Mã hóa K_c bằng public key người nhận
                byte[] encryptedKey = encryptAsymmetric(_receiverPublicKey, aes.Key);

                //ciphertext bao gồm:
                // + 1 byte đầu tiên: kích thước tên file gốc
                // + Tên file gốc
                // + 1 byte tiếp theo: kích thước khóa K_c
                // + Khóa K_c
                // + Kích thước IV (Initialization vector)
                // + Nội dung file đã mã hóa với K_c

                byte[] ciphertext = new byte[1 + extensionFileName.Length + 1 + encryptedKey.Length + aes.IV.Length + encryptedText.Length];
                ciphertext[0] = (byte)extensionFileName.Length;
                Buffer.BlockCopy(Encoding.UTF8.GetBytes(extensionFileName), 0, ciphertext, 1, extensionFileName.Length);
                ciphertext[1 + extensionFileName.Length] = (byte)encryptedKey.Length;
                Buffer.BlockCopy(encryptedKey, 0, ciphertext, 1 + extensionFileName.Length + 1, encryptedKey.Length);
                Buffer.BlockCopy(aes.IV, 0, ciphertext, 1 + extensionFileName.Length + 1 + encryptedKey.Length, aes.IV.Length);
                Buffer.BlockCopy(encryptedText, 0, ciphertext, 1 + extensionFileName.Length + 1 + encryptedKey.Length + aes.IV.Length, encryptedText.Length);

                File.WriteAllBytes(_linkSaveFileEncrypt, ciphertext);

                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Hàm giải mã data: theo yêu cầu đề bài
        public bool decryptFile(string _passphrase, string _linkFileEncrypt, string _linkSaveFileDecrypt)
        {
            try
            {
                byte[] dataCipherText = File.ReadAllBytes(_linkFileEncrypt);

                //Lấy phần mở rộng
                byte[] ext = dataCipherText.Skip(1).Take(dataCipherText[0]).ToArray();
                string extension = Encoding.UTF8.GetString(ext, 0, ext.Length);

                //Lấy K_c
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.KeySize = 256;
                aes.Mode = CipherMode.CBC;

                byte[] key= this.decryptAsymmetric(_passphrase, dataCipherText.Skip(1 + ext.Length + 1).Take(dataCipherText[1 + ext.Length]).ToArray());
                if (key == null) return false;
                aes.Key = key;

                aes.GenerateIV();
                aes.IV = dataCipherText.Skip(1 + ext.Length + 1 + dataCipherText[1 + ext.Length]).Take(aes.IV.Length).ToArray();


                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(dataCipherText, 1 + ext.Length + 1 + dataCipherText[1 + ext.Length] + aes.IV.Length, dataCipherText.Length - (1 + ext.Length + 1 + dataCipherText[1 + ext.Length] + aes.IV.Length));
                        csDecrypt.FlushFinalBlock();

                        File.WriteAllBytes(_linkSaveFileDecrypt + extension, msDecrypt.ToArray());
                    }
                }
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        //Hàm ký vào data
        public bool signData(string _passphrase, string _linkFileData, string _linkSign)
        {
            try
            {
                byte[] data = File.ReadAllBytes(_linkFileData);
                byte[] sign;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                string privateKey = decryptSymmetric(_passphrase, Convert.FromBase64String(encryptedPrivateKey));
                rsa.FromXmlString(privateKey);
                sign =  rsa.SignData(data, new SHA256CryptoServiceProvider());

                File.WriteAllBytes(_linkSign, sign);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Hàm xác nhận chữ ký
        public bool verifySignData(string _linkFileData, string _linkFileSign)
        {
            byte[] data = File.ReadAllBytes(_linkFileData);
            byte[] sign = File.ReadAllBytes(_linkFileSign);

            if (data == null || sign == null) return false;

            for (int i = 0; i < MainForm.dataBase.Count; i++)
            {
                string publicKey = MainForm.dataBase[i].getPublicKey();

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(publicKey);
                if (rsa.VerifyData(data, new SHA256CryptoServiceProvider(), sign))
                {
                    MessageBox.Show("Chủ nhân file: " + MainForm.dataBase[i].getEmail(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
    }

}
