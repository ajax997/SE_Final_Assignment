namespace Shopping_Management
{
    partial class frmImportProducts
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
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbUnitType = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lbProductCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.gbInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformation
            // 
            this.gbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbInformation.Controls.Add(this.txtPrice);
            this.gbInformation.Controls.Add(this.lbPrice);
            this.gbInformation.Controls.Add(this.button3);
            this.gbInformation.Controls.Add(this.btnAdd);
            this.gbInformation.Controls.Add(this.button1);
            this.gbInformation.Controls.Add(this.cbUnit);
            this.gbInformation.Controls.Add(this.txtquantity);
            this.gbInformation.Controls.Add(this.textBox4);
            this.gbInformation.Controls.Add(this.lbQuantity);
            this.gbInformation.Controls.Add(this.lbNote);
            this.gbInformation.Controls.Add(this.txtName);
            this.gbInformation.Controls.Add(this.lbProductName);
            this.gbInformation.Controls.Add(this.tbUnitType);
            this.gbInformation.Controls.Add(this.txtProductCode);
            this.gbInformation.Controls.Add(this.lbProductCode);
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.gbInformation.Location = new System.Drawing.Point(18, 20);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(284, 550);
            this.gbInformation.TabIndex = 0;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Informations";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.button3.Location = new System.Drawing.Point(39, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnAdd.Location = new System.Drawing.Point(96, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.button1.Location = new System.Drawing.Point(143, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbUnit
            // 
            this.cbUnit.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(25, 188);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(206, 23);
            this.cbUnit.TabIndex = 2;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtquantity.Location = new System.Drawing.Point(25, 251);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(206, 24);
            this.txtquantity.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBox4.Location = new System.Drawing.Point(27, 386);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 52);
            this.textBox4.TabIndex = 1;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbQuantity.Location = new System.Drawing.Point(22, 225);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(56, 17);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbNote.Location = new System.Drawing.Point(26, 357);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(37, 17);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Note";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtName.Location = new System.Drawing.Point(25, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 24);
            this.txtName.TabIndex = 1;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbProductName.Location = new System.Drawing.Point(22, 100);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(92, 17);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // tbUnitType
            // 
            this.tbUnitType.AutoSize = true;
            this.tbUnitType.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbUnitType.Location = new System.Drawing.Point(22, 162);
            this.tbUnitType.Name = "tbUnitType";
            this.tbUnitType.Size = new System.Drawing.Size(36, 17);
            this.tbUnitType.TabIndex = 0;
            this.tbUnitType.Text = "Type";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductCode.Location = new System.Drawing.Point(25, 66);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(206, 24);
            this.txtProductCode.TabIndex = 1;
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbProductCode.Location = new System.Drawing.Point(22, 40);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(88, 17);
            this.lbProductCode.TabIndex = 0;
            this.lbProductCode.Text = "Product Code";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvDetail);
            this.panel1.Location = new System.Drawing.Point(318, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 541);
            this.panel1.TabIndex = 1;
            // 
            // dgvDetail
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.id,
            this.productCode,
            this.productName,
            this.Unit,
            this.quantity,
            this.price,
            this.note});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.dgvDetail.Size = new System.Drawing.Size(721, 541);
            this.dgvDetail.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Code";
            this.productCode.Name = "productCode";
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPrice.Location = new System.Drawing.Point(27, 318);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(206, 24);
            this.txtPrice.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbPrice.Location = new System.Drawing.Point(24, 292);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 17);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price";
            // 
            // frmImportProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInformation);
            this.Name = "frmImportProducts";
            this.Text = "Import Products";
            this.Load += new System.EventHandler(this.frmImportProducts_Load);
            this.SizeChanged += new System.EventHandler(this.dgvDetail_SizeChanged);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label tbUnitType;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lbProductCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}