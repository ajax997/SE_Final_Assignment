namespace Shopping_Management
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.gpAppInfo = new System.Windows.Forms.GroupBox();
            this.lbCredit = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbAdminInfo = new System.Windows.Forms.GroupBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbAdminFullName = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lbAdminRetypePass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lbAdminNewPass = new System.Windows.Forms.Label();
            this.lbAdminUsername = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.gpAppInfo.SuspendLayout();
            this.gbAdminInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAppInfo
            // 
            this.gpAppInfo.Controls.Add(this.lbCredit);
            this.gpAppInfo.Controls.Add(this.lbVersion);
            this.gpAppInfo.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gpAppInfo.Location = new System.Drawing.Point(12, 12);
            this.gpAppInfo.Name = "gpAppInfo";
            this.gpAppInfo.Size = new System.Drawing.Size(376, 109);
            this.gpAppInfo.TabIndex = 0;
            this.gpAppInfo.TabStop = false;
            this.gpAppInfo.Text = "Application Info";
            // 
            // lbCredit
            // 
            this.lbCredit.AutoSize = true;
            this.lbCredit.Location = new System.Drawing.Point(16, 57);
            this.lbCredit.Name = "lbCredit";
            this.lbCredit.Size = new System.Drawing.Size(325, 34);
            this.lbCredit.TabIndex = 7;
            this.lbCredit.Text = "Credit: This Application is a SE\'s Assignment,\r\nProgrammed by Nguyen Phuc Nghi, T" +
    "ruong Tuan Phat";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(16, 35);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(76, 17);
            this.lbVersion.TabIndex = 6;
            this.lbVersion.Text = "Version: 1.0";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnApply.Location = new System.Drawing.Point(293, 363);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 32);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gbAdminInfo
            // 
            this.gbAdminInfo.Controls.Add(this.cbID);
            this.gbAdminInfo.Controls.Add(this.txtFullname);
            this.gbAdminInfo.Controls.Add(this.lbAdminFullName);
            this.gbAdminInfo.Controls.Add(this.txtRetypePass);
            this.gbAdminInfo.Controls.Add(this.lbAdminRetypePass);
            this.gbAdminInfo.Controls.Add(this.txtNewPass);
            this.gbAdminInfo.Controls.Add(this.lbAdminNewPass);
            this.gbAdminInfo.Controls.Add(this.lbAdminUsername);
            this.gbAdminInfo.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gbAdminInfo.Location = new System.Drawing.Point(12, 140);
            this.gbAdminInfo.Name = "gbAdminInfo";
            this.gbAdminInfo.Size = new System.Drawing.Size(376, 199);
            this.gbAdminInfo.TabIndex = 6;
            this.gbAdminInfo.TabStop = false;
            this.gbAdminInfo.Text = "System References";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(156, 77);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(201, 24);
            this.txtFullname.TabIndex = 7;
            // 
            // lbAdminFullName
            // 
            this.lbAdminFullName.AutoSize = true;
            this.lbAdminFullName.Location = new System.Drawing.Point(17, 80);
            this.lbAdminFullName.Name = "lbAdminFullName";
            this.lbAdminFullName.Size = new System.Drawing.Size(66, 17);
            this.lbAdminFullName.TabIndex = 6;
            this.lbAdminFullName.Text = "Full Name";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(155, 156);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(201, 24);
            this.txtRetypePass.TabIndex = 5;
            this.txtRetypePass.UseSystemPasswordChar = true;
            // 
            // lbAdminRetypePass
            // 
            this.lbAdminRetypePass.AutoSize = true;
            this.lbAdminRetypePass.Location = new System.Drawing.Point(16, 156);
            this.lbAdminRetypePass.Name = "lbAdminRetypePass";
            this.lbAdminRetypePass.Size = new System.Drawing.Size(108, 17);
            this.lbAdminRetypePass.TabIndex = 4;
            this.lbAdminRetypePass.Text = "Retype Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(155, 114);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(201, 24);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // lbAdminNewPass
            // 
            this.lbAdminNewPass.AutoSize = true;
            this.lbAdminNewPass.Location = new System.Drawing.Point(16, 117);
            this.lbAdminNewPass.Name = "lbAdminNewPass";
            this.lbAdminNewPass.Size = new System.Drawing.Size(94, 17);
            this.lbAdminNewPass.TabIndex = 2;
            this.lbAdminNewPass.Text = "New Password";
            // 
            // lbAdminUsername
            // 
            this.lbAdminUsername.AutoSize = true;
            this.lbAdminUsername.Location = new System.Drawing.Point(17, 40);
            this.lbAdminUsername.Name = "lbAdminUsername";
            this.lbAdminUsername.Size = new System.Drawing.Size(61, 17);
            this.lbAdminUsername.TabIndex = 0;
            this.lbAdminUsername.Text = "Admin ID";
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(156, 40);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(200, 23);
            this.cbID.TabIndex = 8;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 412);
            this.Controls.Add(this.gbAdminInfo);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gpAppInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gpAppInfo.ResumeLayout(false);
            this.gpAppInfo.PerformLayout();
            this.gbAdminInfo.ResumeLayout(false);
            this.gbAdminInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAppInfo;
        private System.Windows.Forms.Label lbCredit;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbAdminInfo;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbAdminFullName;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lbAdminRetypePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbAdminNewPass;
        private System.Windows.Forms.Label lbAdminUsername;
        private System.Windows.Forms.ComboBox cbID;
    }
}