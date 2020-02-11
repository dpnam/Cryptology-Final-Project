namespace MHTT_UD
{
    partial class SignForm
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
            this.btSign = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbSave = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSign.Location = new System.Drawing.Point(226, 175);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(75, 23);
            this.btSign.TabIndex = 0;
            this.btSign.Text = "Sign";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(322, 175);
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
            this.lbPassword.Location = new System.Drawing.Point(22, 53);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password (*)";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(22, 92);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(48, 13);
            this.lbPath.TabIndex = 3;
            this.lbPath.Text = "File Path";
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(22, 125);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(32, 13);
            this.lbSave.TabIndex = 4;
            this.lbSave.Text = "Save";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 50);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(203, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(98, 89);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(299, 20);
            this.tbPath.TabIndex = 6;
            this.tbPath.Click += new System.EventHandler(this.tbPath_Click);
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(98, 122);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(299, 20);
            this.tbSave.TabIndex = 7;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Location = new System.Drawing.Point(23, 153);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(50, 13);
            this.lbWarning.TabIndex = 8;
            this.lbWarning.Text = "Warrning";
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(409, 38);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "Sign File Data";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 212);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSign);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignForm";
            this.ShowIcon = false;
            this.Text = "Sign Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbSave;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbLogin;
    }
}