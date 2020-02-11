namespace MHTT_UD
{
    partial class VerifyPasswwordForm
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
            this.lbPassword = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbOK = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(13, 41);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(121, 93);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(70, 23);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(80, 38);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(13, 69);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(47, 13);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "Warning";
            this.lbWarning.Visible = false;
            // 
            // lbOK
            // 
            this.lbOK.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOK.Location = new System.Drawing.Point(0, 0);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(284, 29);
            this.lbOK.TabIndex = 30;
            this.lbOK.Text = "Verify";
            this.lbOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(197, 93);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // VerifyPasswwordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerifyPasswwordForm";
            this.ShowIcon = false;
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbOK;
        private System.Windows.Forms.Button btCancel;
    }
}