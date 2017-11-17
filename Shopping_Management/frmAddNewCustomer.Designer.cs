namespace Shopping_Management
{
    partial class frmAddNewCustomer
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
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(40, 116);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(248, 21);
            this.cbSex.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.Location = new System.Drawing.Point(36, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Sex";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpDOB.Location = new System.Drawing.Point(36, 173);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 22);
            this.dtpDOB.TabIndex = 50;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtAddress.Location = new System.Drawing.Point(36, 292);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(252, 26);
            this.txtAddress.TabIndex = 49;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbAddress.Location = new System.Drawing.Point(36, 270);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(58, 19);
            this.lbAddress.TabIndex = 48;
            this.lbAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtPhone.Location = new System.Drawing.Point(36, 225);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(252, 26);
            this.txtPhone.TabIndex = 47;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbPhone.Location = new System.Drawing.Point(36, 203);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(48, 19);
            this.lbPhone.TabIndex = 46;
            this.lbPhone.Text = "Phone";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbDOB.Location = new System.Drawing.Point(36, 152);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(90, 19);
            this.lbDOB.TabIndex = 45;
            this.lbDOB.Text = "Date Of Birth";
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtFullname.Location = new System.Drawing.Point(36, 58);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(252, 26);
            this.txtFullname.TabIndex = 44;
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbFullname.Location = new System.Drawing.Point(36, 36);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(70, 19);
            this.lbFullname.TabIndex = 43;
            this.lbFullname.Text = "Full Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAdd.Location = new System.Drawing.Point(213, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddNewCustomer
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(325, 393);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lbFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddNewCustomer";
            this.Text = "Add New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Button btnAdd;
    }
}
