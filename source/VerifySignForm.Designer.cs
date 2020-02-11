namespace MHTT_UD
{
    partial class VerifySignForm
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
            this.btVerify = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.lbSign = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbSign = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVerify
            // 
            this.btVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerify.Location = new System.Drawing.Point(217, 122);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(75, 23);
            this.btVerify.TabIndex = 0;
            this.btVerify.Text = "Verify";
            this.btVerify.UseVisualStyleBackColor = true;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(307, 122);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(7, 54);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(55, 13);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data Path";
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.Location = new System.Drawing.Point(9, 92);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(53, 13);
            this.lbSign.TabIndex = 3;
            this.lbSign.Text = "Sign Path";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(88, 51);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(294, 20);
            this.tbData.TabIndex = 4;
            this.tbData.Click += new System.EventHandler(this.tbData_Click);
            // 
            // tbSign
            // 
            this.tbSign.Location = new System.Drawing.Point(88, 85);
            this.tbSign.Name = "tbSign";
            this.tbSign.Size = new System.Drawing.Size(294, 20);
            this.tbSign.TabIndex = 5;
            this.tbSign.Click += new System.EventHandler(this.tbSign_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(394, 38);
            this.lbLogin.TabIndex = 10;
            this.lbLogin.Text = "Verify Sign";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerifySignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 156);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbSign);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lbSign);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btVerify);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerifySignForm";
            this.ShowIcon = false;
            this.Text = "Verify Sign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbSign;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbSign;
        private System.Windows.Forms.Label lbLogin;
    }
}