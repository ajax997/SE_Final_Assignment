﻿namespace Shopping_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddNewStaff = new System.Windows.Forms.GroupBox();
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
            this.lbPermission = new System.Windows.Forms.Label();
            this.cbCashing = new System.Windows.Forms.CheckBox();
            this.cbCreateReport = new System.Windows.Forms.CheckBox();
            this.cbImport = new System.Windows.Forms.CheckBox();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lbRetype = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetail.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowTemplate.Height = 35;
            this.dgvDetail.RowTemplate.ReadOnly = true;
            this.dgvDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetail.Size = new System.Drawing.Size(695, 601);
            this.dgvDetail.TabIndex = 3;
            this.dgvDetail.SizeChanged += new System.EventHandler(this.dgvDetail_SizeChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BOB";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Permissions";
            this.Column5.Name = "Column5";
            // 
            // gbAddNewStaff
            // 
            this.gbAddNewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gbAddNewStaff.Controls.Add(this.lbPermission);
            this.gbAddNewStaff.Controls.Add(this.cbCashing);
            this.gbAddNewStaff.Controls.Add(this.cbCreateReport);
            this.gbAddNewStaff.Controls.Add(this.cbImport);
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
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtAddress.Location = new System.Drawing.Point(23, 374);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 26);
            this.txtAddress.TabIndex = 33;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbAddress.Location = new System.Drawing.Point(23, 352);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(58, 19);
            this.lbAddress.TabIndex = 32;
            this.lbAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtPhone.Location = new System.Drawing.Point(23, 323);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 26);
            this.txtPhone.TabIndex = 31;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbPhone.Location = new System.Drawing.Point(23, 301);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(48, 19);
            this.lbPhone.TabIndex = 30;
            this.lbPhone.Text = "Phone";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbDOB.Location = new System.Drawing.Point(23, 250);
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
            this.txtFullname.Size = new System.Drawing.Size(210, 26);
            this.txtFullname.TabIndex = 26;
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
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtUsername.Location = new System.Drawing.Point(23, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 26);
            this.txtUsername.TabIndex = 24;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbUsername.Location = new System.Drawing.Point(23, 46);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(71, 19);
            this.lbUsername.TabIndex = 23;
            this.lbUsername.Text = "Username";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbPermission.Location = new System.Drawing.Point(20, 436);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(81, 19);
            this.lbPermission.TabIndex = 22;
            this.lbPermission.Text = "Permissions";
            // 
            // cbCashing
            // 
            this.cbCashing.AutoSize = true;
            this.cbCashing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCashing.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbCashing.Location = new System.Drawing.Point(23, 529);
            this.cbCashing.Name = "cbCashing";
            this.cbCashing.Size = new System.Drawing.Size(125, 23);
            this.cbCashing.TabIndex = 21;
            this.cbCashing.Text = "Cashing (Selling)";
            this.cbCashing.UseVisualStyleBackColor = true;
            // 
            // cbCreateReport
            // 
            this.cbCreateReport.AutoSize = true;
            this.cbCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCreateReport.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbCreateReport.Location = new System.Drawing.Point(23, 495);
            this.cbCreateReport.Name = "cbCreateReport";
            this.cbCreateReport.Size = new System.Drawing.Size(110, 23);
            this.cbCreateReport.TabIndex = 20;
            this.cbCreateReport.Text = "Create Report";
            this.cbCreateReport.UseVisualStyleBackColor = true;
            // 
            // cbImport
            // 
            this.cbImport.AutoSize = true;
            this.cbImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbImport.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.cbImport.Location = new System.Drawing.Point(23, 461);
            this.cbImport.Name = "cbImport";
            this.cbImport.Size = new System.Drawing.Size(125, 23);
            this.cbImport.TabIndex = 19;
            this.cbImport.Text = "Import Products";
            this.cbImport.UseVisualStyleBackColor = true;
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtRetypePass.Location = new System.Drawing.Point(23, 221);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(210, 26);
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
            this.txtNewPass.Size = new System.Drawing.Size(210, 26);
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
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(23, 271);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(210, 27);
            this.dtpDOB.TabIndex = 34;
            // 
            // frmStaffManagement
            // 
            this.ClientSize = new System.Drawing.Size(1038, 658);
            this.Controls.Add(this.gbAddNewStaff);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.CheckBox cbCashing;
        private System.Windows.Forms.CheckBox cbCreateReport;
        private System.Windows.Forms.CheckBox cbImport;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lbRetype;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}
