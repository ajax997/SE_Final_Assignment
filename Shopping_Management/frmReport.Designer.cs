namespace Shopping_Management
{
    partial class frmReport
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpReportType = new System.Windows.Forms.GroupBox();
            this.btnReview = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gpReview = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lbBussinessName = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbValueOfExpiredProduct = new System.Windows.Forms.Label();
            this.lbExpiredProdcut = new System.Windows.Forms.Label();
            this.lbImportQuantity = new System.Windows.Forms.Label();
            this.lbReportDuration = new System.Windows.Forms.Label();
            this.lbNameOfReport = new System.Windows.Forms.Label();
            this.lbProductInStorge = new System.Windows.Forms.Label();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.lbTaxCode = new System.Windows.Forms.Label();
            this.gpInfomation = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lbDateCreateReport = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbExportStaff = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.gpReportType.SuspendLayout();
            this.gpReview.SuspendLayout();
            this.gpInfomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a report type";
            // 
            // gpReportType
            // 
            this.gpReportType.Controls.Add(this.btnReview);
            this.gpReportType.Controls.Add(this.comboBox2);
            this.gpReportType.Controls.Add(this.comboBox1);
            this.gpReportType.Controls.Add(this.label1);
            this.gpReportType.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gpReportType.Location = new System.Drawing.Point(12, 12);
            this.gpReportType.Name = "gpReportType";
            this.gpReportType.Size = new System.Drawing.Size(510, 84);
            this.gpReportType.TabIndex = 2;
            this.gpReportType.TabStop = false;
            this.gpReportType.Text = "Report Type";
            // 
            // btnReview
            // 
            this.btnReview.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnReview.Location = new System.Drawing.Point(335, 37);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(109, 28);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Make an review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // gpReview
            // 
            this.gpReview.Controls.Add(this.textBox11);
            this.gpReview.Controls.Add(this.lbBussinessName);
            this.gpReview.Controls.Add(this.textBox7);
            this.gpReview.Controls.Add(this.textBox6);
            this.gpReview.Controls.Add(this.textBox5);
            this.gpReview.Controls.Add(this.textBox4);
            this.gpReview.Controls.Add(this.textBox9);
            this.gpReview.Controls.Add(this.textBox8);
            this.gpReview.Controls.Add(this.textBox3);
            this.gpReview.Controls.Add(this.textBox2);
            this.gpReview.Controls.Add(this.lbValueOfExpiredProduct);
            this.gpReview.Controls.Add(this.lbExpiredProdcut);
            this.gpReview.Controls.Add(this.lbImportQuantity);
            this.gpReview.Controls.Add(this.lbReportDuration);
            this.gpReview.Controls.Add(this.lbNameOfReport);
            this.gpReview.Controls.Add(this.lbProductInStorge);
            this.gpReview.Controls.Add(this.lbRevenue);
            this.gpReview.Controls.Add(this.lbTaxCode);
            this.gpReview.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gpReview.Location = new System.Drawing.Point(13, 103);
            this.gpReview.Name = "gpReview";
            this.gpReview.Size = new System.Drawing.Size(509, 327);
            this.gpReview.TabIndex = 3;
            this.gpReview.TabStop = false;
            this.gpReview.Text = "Review";
            this.gpReview.Enter += new System.EventHandler(this.gpReview_Enter);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox11.Location = new System.Drawing.Point(172, 28);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(318, 24);
            this.textBox11.TabIndex = 3;
            // 
            // lbBussinessName
            // 
            this.lbBussinessName.AutoSize = true;
            this.lbBussinessName.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbBussinessName.Location = new System.Drawing.Point(11, 35);
            this.lbBussinessName.Name = "lbBussinessName";
            this.lbBussinessName.Size = new System.Drawing.Size(102, 17);
            this.lbBussinessName.TabIndex = 2;
            this.lbBussinessName.Text = "Bussiness Name";
            this.lbBussinessName.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox7.Location = new System.Drawing.Point(172, 268);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(318, 24);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox6.Location = new System.Drawing.Point(172, 238);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(318, 24);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox5.Location = new System.Drawing.Point(172, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(318, 24);
            this.textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox4.Location = new System.Drawing.Point(172, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 24);
            this.textBox4.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox9.Location = new System.Drawing.Point(172, 148);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(318, 24);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox8.Location = new System.Drawing.Point(172, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(318, 24);
            this.textBox8.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox3.Location = new System.Drawing.Point(172, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(318, 24);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox2.Location = new System.Drawing.Point(172, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 24);
            this.textBox2.TabIndex = 1;
            // 
            // lbValueOfExpiredProduct
            // 
            this.lbValueOfExpiredProduct.AutoSize = true;
            this.lbValueOfExpiredProduct.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbValueOfExpiredProduct.Location = new System.Drawing.Point(11, 275);
            this.lbValueOfExpiredProduct.Name = "lbValueOfExpiredProduct";
            this.lbValueOfExpiredProduct.Size = new System.Drawing.Size(155, 17);
            this.lbValueOfExpiredProduct.TabIndex = 0;
            this.lbValueOfExpiredProduct.Text = "Value Of Expired Product";
            // 
            // lbExpiredProdcut
            // 
            this.lbExpiredProdcut.AutoSize = true;
            this.lbExpiredProdcut.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbExpiredProdcut.Location = new System.Drawing.Point(11, 245);
            this.lbExpiredProdcut.Name = "lbExpiredProdcut";
            this.lbExpiredProdcut.Size = new System.Drawing.Size(101, 17);
            this.lbExpiredProdcut.TabIndex = 0;
            this.lbExpiredProdcut.Text = "Expired Product";
            // 
            // lbImportQuantity
            // 
            this.lbImportQuantity.AutoSize = true;
            this.lbImportQuantity.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbImportQuantity.Location = new System.Drawing.Point(11, 215);
            this.lbImportQuantity.Name = "lbImportQuantity";
            this.lbImportQuantity.Size = new System.Drawing.Size(99, 17);
            this.lbImportQuantity.TabIndex = 0;
            this.lbImportQuantity.Text = "Import Quantity";
            // 
            // lbReportDuration
            // 
            this.lbReportDuration.AutoSize = true;
            this.lbReportDuration.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbReportDuration.Location = new System.Drawing.Point(11, 155);
            this.lbReportDuration.Name = "lbReportDuration";
            this.lbReportDuration.Size = new System.Drawing.Size(102, 17);
            this.lbReportDuration.TabIndex = 0;
            this.lbReportDuration.Text = "Report Duration";
            // 
            // lbNameOfReport
            // 
            this.lbNameOfReport.AutoSize = true;
            this.lbNameOfReport.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbNameOfReport.Location = new System.Drawing.Point(11, 125);
            this.lbNameOfReport.Name = "lbNameOfReport";
            this.lbNameOfReport.Size = new System.Drawing.Size(105, 17);
            this.lbNameOfReport.TabIndex = 0;
            this.lbNameOfReport.Text = "Name Of Report";
            // 
            // lbProductInStorge
            // 
            this.lbProductInStorge.AutoSize = true;
            this.lbProductInStorge.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbProductInStorge.Location = new System.Drawing.Point(11, 185);
            this.lbProductInStorge.Name = "lbProductInStorge";
            this.lbProductInStorge.Size = new System.Drawing.Size(110, 17);
            this.lbProductInStorge.TabIndex = 0;
            this.lbProductInStorge.Text = "Product In Storge";
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbRevenue.Location = new System.Drawing.Point(11, 95);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(57, 17);
            this.lbRevenue.TabIndex = 0;
            this.lbRevenue.Text = "Revenue";
            // 
            // lbTaxCode
            // 
            this.lbTaxCode.AutoSize = true;
            this.lbTaxCode.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbTaxCode.Location = new System.Drawing.Point(11, 65);
            this.lbTaxCode.Name = "lbTaxCode";
            this.lbTaxCode.Size = new System.Drawing.Size(63, 17);
            this.lbTaxCode.TabIndex = 0;
            this.lbTaxCode.Text = "Tax Code";
            this.lbTaxCode.Click += new System.EventHandler(this.lbTaxCode_Click);
            // 
            // gpInfomation
            // 
            this.gpInfomation.Controls.Add(this.textBox10);
            this.gpInfomation.Controls.Add(this.lbDateCreateReport);
            this.gpInfomation.Controls.Add(this.textBox1);
            this.gpInfomation.Controls.Add(this.lbExportStaff);
            this.gpInfomation.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gpInfomation.Location = new System.Drawing.Point(13, 436);
            this.gpInfomation.Name = "gpInfomation";
            this.gpInfomation.Size = new System.Drawing.Size(509, 100);
            this.gpInfomation.TabIndex = 4;
            this.gpInfomation.TabStop = false;
            this.gpInfomation.Text = "Infomations";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox10.Location = new System.Drawing.Point(172, 31);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(318, 24);
            this.textBox10.TabIndex = 1;
            // 
            // lbDateCreateReport
            // 
            this.lbDateCreateReport.AutoSize = true;
            this.lbDateCreateReport.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbDateCreateReport.Location = new System.Drawing.Point(8, 34);
            this.lbDateCreateReport.Name = "lbDateCreateReport";
            this.lbDateCreateReport.Size = new System.Drawing.Size(121, 17);
            this.lbDateCreateReport.TabIndex = 0;
            this.lbDateCreateReport.Text = "Date Create Report";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox1.Location = new System.Drawing.Point(172, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 24);
            this.textBox1.TabIndex = 1;
            // 
            // lbExportStaff
            // 
            this.lbExportStaff.AutoSize = true;
            this.lbExportStaff.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbExportStaff.Location = new System.Drawing.Point(8, 64);
            this.lbExportStaff.Name = "lbExportStaff";
            this.lbExportStaff.Size = new System.Drawing.Size(120, 17);
            this.lbExportStaff.TabIndex = 0;
            this.lbExportStaff.Text = "Staff Create Report";
            // 
            // btnExportReport
            // 
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnExportReport.Location = new System.Drawing.Point(413, 548);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(109, 28);
            this.btnExportReport.TabIndex = 3;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 589);
            this.Controls.Add(this.btnExportReport);
            this.Controls.Add(this.gpInfomation);
            this.Controls.Add(this.gpReview);
            this.Controls.Add(this.gpReportType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.gpReportType.ResumeLayout(false);
            this.gpReportType.PerformLayout();
            this.gpReview.ResumeLayout(false);
            this.gpReview.PerformLayout();
            this.gpInfomation.ResumeLayout(false);
            this.gpInfomation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpReportType;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.GroupBox gpReview;
        private System.Windows.Forms.Label lbExpiredProdcut;
        private System.Windows.Forms.Label lbImportQuantity;
        private System.Windows.Forms.Label lbProductInStorge;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label lbTaxCode;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbValueOfExpiredProduct;
        private System.Windows.Forms.GroupBox gpInfomation;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbReportDuration;
        private System.Windows.Forms.Label lbNameOfReport;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lbDateCreateReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbExportStaff;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label lbBussinessName;
        private System.Windows.Forms.Button btnExportReport;
    }
}