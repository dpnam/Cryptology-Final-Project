namespace MHTT_UD
{
    partial class DecryptForm
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
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDecrypt
            // 
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrypt.Location = new System.Drawing.Point(224, 170);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btDecrypt.TabIndex = 0;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(318, 170);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 47);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password (*)";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(90, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(195, 20);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(90, 82);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(303, 20);
            this.tbPath.TabIndex = 4;
            this.tbPath.Click += new System.EventHandler(this.tbPath_Click);
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(90, 116);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(303, 20);
            this.tbSave.TabIndex = 5;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(12, 85);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(48, 13);
            this.lbPath.TabIndex = 6;
            this.lbPath.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Save";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(12, 150);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(47, 13);
            this.lbWarning.TabIndex = 8;
            this.lbWarning.Text = "Warning";
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(405, 38);
            this.lbLogin.TabIndex = 10;
            this.lbLogin.Text = "Decrypt File";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 206);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDecrypt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DecryptForm";
            this.ShowIcon = false;
            this.Text = "Decrypt File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbLogin;
    }
}