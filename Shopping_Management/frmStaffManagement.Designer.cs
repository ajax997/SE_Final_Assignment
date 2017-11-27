namespace Shopping_Management
{
    partial class frmStaffManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddNewStaff = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.btnAddNewStaff = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbFullname = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lbRetype = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.gbAddNewStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Location = new System.Drawing.Point(331, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 634);
            this.panel1.TabIndex = 0;
            // 
            // dgvDetail
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.sex,
            this.Column3,
            this.Column4,
            this.address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDetail.Location = new System.Drawing.Point(14, 3);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowTemplate.Height = 35;
            this.dgvDetail.RowTemplate.ReadOnly = true;
            this.dgvDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(695, 601);
            this.dgvDetail.TabIndex = 3;
            this.dgvDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetail_RowsAdded);
            this.dgvDetail.SelectionChanged += new System.EventHandler(this.dgvDetail_SelectionChanged);
            this.dgvDetail.SizeChanged += new System.EventHandler(this.dgvDetail_SizeChanged);
            this.dgvDetail.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dgvDetail_PreviewKeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Sex";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BOB";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // gbAddNewStaff
            // 
            this.gbAddNewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAddNewStaff.Controls.Add(this.cbSex);
            this.gbAddNewStaff.Controls.Add(this.label1);
            this.gbAddNewStaff.Controls.Add(this.dtpDOB);
            this.gbAddNewStaff.Controls.Add(this.txtAddress);
            this.gbAddNewStaff.Controls.Add(this.lbAddress);
            this.gbAddNewStaff.Controls.Add(this.txtPhone);
            this.gbAddNewStaff.Controls.Add(this.lbPhone);
            this.gbAddNewStaff.Controls.Add(this.lbDOB);
            this.gbAddNewStaff.Controls.Add(this.btnAddNewStaff);
            this.gbAddNewStaff.Controls.Add(this.txtFullname);
            this.gbAddNewStaff.Controls.Add(this.lbFullname);
            this.gbAddNewStaff.Controls.Add(this.txtUsername);
            this.gbAddNewStaff.Controls.Add(this.lbUsername);
            this.gbAddNewStaff.Controls.Add(this.txtRetypePass);
            this.gbAddNewStaff.Controls.Add(this.lbRetype);
            this.gbAddNewStaff.Controls.Add(this.txtNewPass);
            this.gbAddNewStaff.Controls.Add(this.btnUpdate);
            this.gbAddNewStaff.Controls.Add(this.lbNewPass);
            this.gbAddNewStaff.Controls.Add(this.btnDeleteStaff);
            this.gbAddNewStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gbAddNewStaff.Location = new System.Drawing.Point(13, 13);
            this.gbAddNewStaff.Name = "gbAddNewStaff";
            this.gbAddNewStaff.Size = new System.Drawing.Size(300, 633);
            this.gbAddNewStaff.TabIndex = 1;
            this.gbAddNewStaff.TabStop = false;
            this.gbAddNewStaff.Text = "New Staff";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbSex.Location = new System.Drawing.Point(27, 277);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(248, 28);
            this.cbSex.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.Location = new System.Drawing.Point(23, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sex";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(23, 340);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(252, 27);
            this.dtpDOB.TabIndex = 34;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtAddress.Location = new System.Drawing.Point(23, 443);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(252, 26);
            this.txtAddress.TabIndex = 33;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbAddress.Location = new System.Drawing.Point(23, 421);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(58, 19);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "Address";
            this.lbAddress.Click += new System.EventHandler(this.lbAddress_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtPhone.Location = new System.Drawing.Point(23, 392);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(252, 26);
            this.txtPhone.TabIndex = 31;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbPhone.Location = new System.Drawing.Point(23, 370);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(48, 19);
            this.lbPhone.TabIndex = 30;
            this.lbPhone.Text = "Phone";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbDOB.Location = new System.Drawing.Point(23, 319);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(90, 19);
            this.lbDOB.TabIndex = 28;
            this.lbDOB.Text = "Date Of Birth";
            // 
            // btnAddNewStaff
            // 
            this.btnAddNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewStaff.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnAddNewStaff.Location = new System.Drawing.Point(200, 571);
            this.btnAddNewStaff.Name = "btnAddNewStaff";
            this.btnAddNewStaff.Size = new System.Drawing.Size(75, 36);
            this.btnAddNewStaff.TabIndex = 27;
            this.btnAddNewStaff.Text = "Add";
            this.btnAddNewStaff.UseVisualStyleBackColor = true;
            this.btnAddNewStaff.Click += new System.EventHandler(this.btnAddNewStaff_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtFullname.Location = new System.Drawing.Point(23, 119);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(252, 26);
            this.txtFullname.TabIndex = 26;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbFullname.Location = new System.Drawing.Point(23, 97);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(70, 19);
            this.lbFullname.TabIndex = 25;
            this.lbFullname.Text = "Full Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtUsername.Location = new System.Drawing.Point(23, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 26);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbUsername.Location = new System.Drawing.Point(23, 46);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 19);
            this.lbUsername.TabIndex = 23;
            this.lbUsername.Text = "User ID";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtRetypePass.Location = new System.Drawing.Point(23, 221);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(252, 26);
            this.txtRetypePass.TabIndex = 18;
            this.txtRetypePass.UseSystemPasswordChar = true;
            // 
            // lbRetype
            // 
            this.lbRetype.AutoSize = true;
            this.lbRetype.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbRetype.Location = new System.Drawing.Point(23, 199);
            this.lbRetype.Name = "lbRetype";
            this.lbRetype.Size = new System.Drawing.Size(113, 19);
            this.lbRetype.TabIndex = 17;
            this.lbRetype.Text = "Repeat Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtNewPass.Location = new System.Drawing.Point(23, 170);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(252, 26);
            this.txtNewPass.TabIndex = 16;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnUpdate.Location = new System.Drawing.Point(16, 571);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbNewPass.Location = new System.Drawing.Point(23, 148);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(98, 19);
            this.lbNewPass.TabIndex = 15;
            this.lbNewPass.Text = "New Password";
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnDeleteStaff.Location = new System.Drawing.Point(108, 571);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteStaff.TabIndex = 0;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // frmStaffManagement
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1038, 658);
            this.Controls.Add(this.gbAddNewStaff);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmStaffManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStaffManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmStaffManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.gbAddNewStaff.ResumeLayout(false);
            this.gbAddNewStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAddNewStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNewStaff;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lbRetype;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}
