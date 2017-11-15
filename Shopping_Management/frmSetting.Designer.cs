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
            this.gpAppInfo = new System.Windows.Forms.GroupBox();
            this.gpSetting = new System.Windows.Forms.GroupBox();
            this.lbBussinessName = new System.Windows.Forms.Label();
            this.txtBussinessName = new System.Windows.Forms.TextBox();
            this.txtTaxcode = new System.Windows.Forms.TextBox();
            this.lbTaxCode = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbCredit = new System.Windows.Forms.Label();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbAdminInfo = new System.Windows.Forms.GroupBox();
            this.lbAdminRetypePass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lbAdminNewPass = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbAdminUsername = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbAdminFullName = new System.Windows.Forms.Label();
            this.gpAppInfo.SuspendLayout();
            this.gpSetting.SuspendLayout();
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
            // gpSetting
            // 
            this.gpSetting.Controls.Add(this.cbLang);
            this.gpSetting.Controls.Add(this.lbLanguage);
            this.gpSetting.Controls.Add(this.txtTaxcode);
            this.gpSetting.Controls.Add(this.lbTaxCode);
            this.gpSetting.Controls.Add(this.txtBussinessName);
            this.gpSetting.Controls.Add(this.lbBussinessName);
            this.gpSetting.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gpSetting.Location = new System.Drawing.Point(12, 137);
            this.gpSetting.Name = "gpSetting";
            this.gpSetting.Size = new System.Drawing.Size(376, 161);
            this.gpSetting.TabIndex = 1;
            this.gpSetting.TabStop = false;
            this.gpSetting.Text = "System References";
            // 
            // lbBussinessName
            // 
            this.lbBussinessName.AutoSize = true;
            this.lbBussinessName.Location = new System.Drawing.Point(16, 36);
            this.lbBussinessName.Name = "lbBussinessName";
            this.lbBussinessName.Size = new System.Drawing.Size(102, 17);
            this.lbBussinessName.TabIndex = 0;
            this.lbBussinessName.Text = "Bussiness Name";
            // 
            // txtBussinessName
            // 
            this.txtBussinessName.Location = new System.Drawing.Point(155, 33);
            this.txtBussinessName.Name = "txtBussinessName";
            this.txtBussinessName.Size = new System.Drawing.Size(201, 24);
            this.txtBussinessName.TabIndex = 1;
            // 
            // txtTaxcode
            // 
            this.txtTaxcode.Location = new System.Drawing.Point(155, 70);
            this.txtTaxcode.Name = "txtTaxcode";
            this.txtTaxcode.Size = new System.Drawing.Size(201, 24);
            this.txtTaxcode.TabIndex = 3;
            // 
            // lbTaxCode
            // 
            this.lbTaxCode.AutoSize = true;
            this.lbTaxCode.Location = new System.Drawing.Point(16, 73);
            this.lbTaxCode.Name = "lbTaxCode";
            this.lbTaxCode.Size = new System.Drawing.Size(131, 17);
            this.lbTaxCode.TabIndex = 2;
            this.lbTaxCode.Text = "Bussiness\'s Tax Code";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(16, 112);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(65, 17);
            this.lbLanguage.TabIndex = 4;
            this.lbLanguage.Text = "Language";
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
            // cbLang
            // 
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(156, 107);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(200, 23);
            this.cbLang.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnApply.Location = new System.Drawing.Point(293, 518);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 32);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // gbAdminInfo
            // 
            this.gbAdminInfo.Controls.Add(this.txtFullname);
            this.gbAdminInfo.Controls.Add(this.lbAdminFullName);
            this.gbAdminInfo.Controls.Add(this.txtRetypePass);
            this.gbAdminInfo.Controls.Add(this.lbAdminRetypePass);
            this.gbAdminInfo.Controls.Add(this.txtNewPass);
            this.gbAdminInfo.Controls.Add(this.lbAdminNewPass);
            this.gbAdminInfo.Controls.Add(this.txtusername);
            this.gbAdminInfo.Controls.Add(this.lbAdminUsername);
            this.gbAdminInfo.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gbAdminInfo.Location = new System.Drawing.Point(12, 313);
            this.gbAdminInfo.Name = "gbAdminInfo";
            this.gbAdminInfo.Size = new System.Drawing.Size(376, 199);
            this.gbAdminInfo.TabIndex = 6;
            this.gbAdminInfo.TabStop = false;
            this.gbAdminInfo.Text = "System References";
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
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(156, 37);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(201, 24);
            this.txtusername.TabIndex = 1;
            // 
            // lbAdminUsername
            // 
            this.lbAdminUsername.AutoSize = true;
            this.lbAdminUsername.Location = new System.Drawing.Point(17, 40);
            this.lbAdminUsername.Name = "lbAdminUsername";
            this.lbAdminUsername.Size = new System.Drawing.Size(108, 17);
            this.lbAdminUsername.TabIndex = 0;
            this.lbAdminUsername.Text = "Admin Username";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(155, 156);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(201, 24);
            this.txtRetypePass.TabIndex = 5;
            this.txtRetypePass.UseSystemPasswordChar = true;
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
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 562);
            this.Controls.Add(this.gbAdminInfo);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gpSetting);
            this.Controls.Add(this.gpAppInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gpAppInfo.ResumeLayout(false);
            this.gpAppInfo.PerformLayout();
            this.gpSetting.ResumeLayout(false);
            this.gpSetting.PerformLayout();
            this.gbAdminInfo.ResumeLayout(false);
            this.gbAdminInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAppInfo;
        private System.Windows.Forms.GroupBox gpSetting;
        private System.Windows.Forms.Label lbCredit;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.TextBox txtTaxcode;
        private System.Windows.Forms.Label lbTaxCode;
        private System.Windows.Forms.TextBox txtBussinessName;
        private System.Windows.Forms.Label lbBussinessName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbAdminInfo;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbAdminFullName;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lbAdminRetypePass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbAdminNewPass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbAdminUsername;
    }
}