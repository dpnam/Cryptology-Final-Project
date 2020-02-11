namespace MHTT_UD
{
    partial class EncryptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbReceiver = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.cbReceiver = new System.Windows.Forms.ComboBox();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.lbSave = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEncrypt
            // 
            this.btEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncrypt.Location = new System.Drawing.Point(214, 160);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btEncrypt.TabIndex = 0;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(299, 160);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(11, 50);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(48, 13);
            this.lbPath.TabIndex = 2;
            this.lbPath.Text = "File Path";
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Location = new System.Drawing.Point(11, 85);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(50, 13);
            this.lbReceiver.TabIndex = 3;
            this.lbReceiver.Text = "Receiver";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(67, 47);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(307, 20);
            this.tbPath.TabIndex = 5;
            this.tbPath.Click += new System.EventHandler(this.tbPath_Click);
            // 
            // cbReceiver
            // 
            this.cbReceiver.FormattingEnabled = true;
            this.cbReceiver.Location = new System.Drawing.Point(67, 85);
            this.cbReceiver.Name = "cbReceiver";
            this.cbReceiver.Size = new System.Drawing.Size(307, 21);
            this.cbReceiver.TabIndex = 6;
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(67, 123);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(307, 20);
            this.tbSave.TabIndex = 9;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(11, 126);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(32, 13);
            this.lbSave.TabIndex = 7;
            this.lbSave.Text = "Save";
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(386, 38);
            this.lbLogin.TabIndex = 10;
            this.lbLogin.Text = "Encrypt File Data";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 195);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.cbReceiver);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbReceiver);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEncrypt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptForm";
            this.ShowIcon = false;
            this.Text = "Encrypt File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbReceiver;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.ComboBox cbReceiver;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Label lbLogin;
    }
}