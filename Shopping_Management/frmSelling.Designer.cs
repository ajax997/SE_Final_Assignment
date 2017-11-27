namespace Shopping_Management
{
    partial class frmSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelling));
            this.pnInfo = new System.Windows.Forms.Panel();
            this.gpPayment = new System.Windows.Forms.GroupBox();
            this.txtExtraMoney = new System.Windows.Forms.TextBox();
            this.txtMoneyReceived = new System.Windows.Forms.TextBox();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.lbExtraMoney = new System.Windows.Forms.Label();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.lbMoneyReceive = new System.Windows.Forms.Label();
            this.lbPaymentMenthol = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnCostumer = new System.Windows.Forms.Panel();
            this.gpNewProduct = new System.Windows.Forms.GroupBox();
            this.btnAddToCash = new System.Windows.Forms.Button();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.gpReceiptDetails = new System.Windows.Forms.GroupBox();
            this.lbReceiptNumber = new System.Windows.Forms.Label();
            this.lbReceiptDateTime = new System.Windows.Forms.Label();
            this.txtReceiptNumber = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.gpCostumerDetails = new System.Windows.Forms.GroupBox();
            this.lbCostumerName = new System.Windows.Forms.Label();
            this.lbCostumerID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSummary = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.Label();
            this.txtSatff = new System.Windows.Forms.TextBox();
            this.lbStaff = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnInfo.SuspendLayout();
            this.gpPayment.SuspendLayout();
            this.pnCostumer.SuspendLayout();
            this.gpNewProduct.SuspendLayout();
            this.gpReceiptDetails.SuspendLayout();
            this.gpCostumerDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.pnSummary.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInfo
            // 
            this.pnInfo.AutoSize = true;
            this.pnInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnInfo.Controls.Add(this.gpPayment);
            this.pnInfo.Controls.Add(this.btnPrevious);
            this.pnInfo.Controls.Add(this.btnDelete);
            this.pnInfo.Controls.Add(this.btnNext);
            this.pnInfo.Controls.Add(this.pnCostumer);
            this.pnInfo.Controls.Add(this.panel2);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(0, 24);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(1068, 575);
            this.pnInfo.TabIndex = 0;
            // 
            // gpPayment
            // 
            this.gpPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPayment.Controls.Add(this.txtExtraMoney);
            this.gpPayment.Controls.Add(this.txtMoneyReceived);
            this.gpPayment.Controls.Add(this.rbCash);
            this.gpPayment.Controls.Add(this.lbExtraMoney);
            this.gpPayment.Controls.Add(this.rbCard);
            this.gpPayment.Controls.Add(this.lbMoneyReceive);
            this.gpPayment.Controls.Add(this.lbPaymentMenthol);
            this.gpPayment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPayment.Location = new System.Drawing.Point(897, 311);
            this.gpPayment.Name = "gpPayment";
            this.gpPayment.Size = new System.Drawing.Size(161, 189);
            this.gpPayment.TabIndex = 7;
            this.gpPayment.TabStop = false;
            this.gpPayment.Text = "Payment";
            // 
            // txtExtraMoney
            // 
            this.txtExtraMoney.Enabled = false;
            this.txtExtraMoney.Location = new System.Drawing.Point(10, 150);
            this.txtExtraMoney.Name = "txtExtraMoney";
            this.txtExtraMoney.Size = new System.Drawing.Size(145, 22);
            this.txtExtraMoney.TabIndex = 3;
            this.txtExtraMoney.TextChanged += new System.EventHandler(this.txtExtraMoney_TextChanged);
            // 
            // txtMoneyReceived
            // 
            this.txtMoneyReceived.Enabled = false;
            this.txtMoneyReceived.Location = new System.Drawing.Point(10, 107);
            this.txtMoneyReceived.Name = "txtMoneyReceived";
            this.txtMoneyReceived.Size = new System.Drawing.Size(145, 22);
            this.txtMoneyReceived.TabIndex = 3;
            this.txtMoneyReceived.TextChanged += new System.EventHandler(this.txtMoneyReceived_TextChanged);
            this.txtMoneyReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneyReceived_KeyPress);
            this.txtMoneyReceived.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtMoneyReceived_PreviewKeyDown);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(10, 68);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(50, 17);
            this.rbCash.TabIndex = 2;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // lbExtraMoney
            // 
            this.lbExtraMoney.AutoSize = true;
            this.lbExtraMoney.Location = new System.Drawing.Point(7, 134);
            this.lbExtraMoney.Name = "lbExtraMoney";
            this.lbExtraMoney.Size = new System.Drawing.Size(70, 13);
            this.lbExtraMoney.TabIndex = 0;
            this.lbExtraMoney.Text = "Extra Money";
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(10, 45);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(68, 17);
            this.rbCard.TabIndex = 1;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Via Card";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // lbMoneyReceive
            // 
            this.lbMoneyReceive.AutoSize = true;
            this.lbMoneyReceive.Location = new System.Drawing.Point(7, 91);
            this.lbMoneyReceive.Name = "lbMoneyReceive";
            this.lbMoneyReceive.Size = new System.Drawing.Size(90, 13);
            this.lbMoneyReceive.TabIndex = 0;
            this.lbMoneyReceive.Text = "Money Received";
            // 
            // lbPaymentMenthol
            // 
            this.lbPaymentMenthol.AutoSize = true;
            this.lbPaymentMenthol.Location = new System.Drawing.Point(6, 20);
            this.lbPaymentMenthol.Name = "lbPaymentMenthol";
            this.lbPaymentMenthol.Size = new System.Drawing.Size(97, 13);
            this.lbPaymentMenthol.TabIndex = 0;
            this.lbPaymentMenthol.Text = "Payment Menthol";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnPrevious.Location = new System.Drawing.Point(929, 197);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(103, 46);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnDelete.Location = new System.Drawing.Point(929, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnNext.Location = new System.Drawing.Point(929, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnCostumer
            // 
            this.pnCostumer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCostumer.BackColor = System.Drawing.Color.Transparent;
            this.pnCostumer.Controls.Add(this.gpNewProduct);
            this.pnCostumer.Controls.Add(this.gpReceiptDetails);
            this.pnCostumer.Controls.Add(this.gpCostumerDetails);
            this.pnCostumer.Location = new System.Drawing.Point(12, 3);
            this.pnCostumer.Name = "pnCostumer";
            this.pnCostumer.Size = new System.Drawing.Size(1044, 137);
            this.pnCostumer.TabIndex = 4;
            // 
            // gpNewProduct
            // 
            this.gpNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpNewProduct.Controls.Add(this.btnAddToCash);
            this.gpNewProduct.Controls.Add(this.lbNumber);
            this.gpNewProduct.Controls.Add(this.lbProductID);
            this.gpNewProduct.Controls.Add(this.txtProductQuantity);
            this.gpNewProduct.Controls.Add(this.txtProductID);
            this.gpNewProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNewProduct.Location = new System.Drawing.Point(680, 3);
            this.gpNewProduct.Name = "gpNewProduct";
            this.gpNewProduct.Size = new System.Drawing.Size(364, 128);
            this.gpNewProduct.TabIndex = 2;
            this.gpNewProduct.TabStop = false;
            this.gpNewProduct.Text = "Add Product";
            // 
            // btnAddToCash
            // 
            this.btnAddToCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCash.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnAddToCash.Location = new System.Drawing.Point(229, 66);
            this.btnAddToCash.Name = "btnAddToCash";
            this.btnAddToCash.Size = new System.Drawing.Size(113, 29);
            this.btnAddToCash.TabIndex = 2;
            this.btnAddToCash.Text = "Add To Cash";
            this.btnAddToCash.UseVisualStyleBackColor = true;
            this.btnAddToCash.Click += new System.EventHandler(this.btnAddToCash_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Location = new System.Drawing.Point(16, 72);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(65, 20);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Text = "Quantity";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(16, 30);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 1;
            this.lbProductID.Text = "Product ID";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductQuantity.Location = new System.Drawing.Point(110, 67);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(113, 27);
            this.txtProductQuantity.TabIndex = 0;
            this.txtProductQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            this.txtProductQuantity.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtProductQuantity_PreviewKeyDown);
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Location = new System.Drawing.Point(110, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(232, 27);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // gpReceiptDetails
            // 
            this.gpReceiptDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpReceiptDetails.Controls.Add(this.lbReceiptNumber);
            this.gpReceiptDetails.Controls.Add(this.lbReceiptDateTime);
            this.gpReceiptDetails.Controls.Add(this.txtReceiptNumber);
            this.gpReceiptDetails.Controls.Add(this.txtDateTime);
            this.gpReceiptDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpReceiptDetails.Location = new System.Drawing.Point(3, 3);
            this.gpReceiptDetails.Name = "gpReceiptDetails";
            this.gpReceiptDetails.Size = new System.Drawing.Size(339, 128);
            this.gpReceiptDetails.TabIndex = 1;
            this.gpReceiptDetails.TabStop = false;
            this.gpReceiptDetails.Text = "Receipt Details";
            // 
            // lbReceiptNumber
            // 
            this.lbReceiptNumber.AutoSize = true;
            this.lbReceiptNumber.Location = new System.Drawing.Point(9, 71);
            this.lbReceiptNumber.Name = "lbReceiptNumber";
            this.lbReceiptNumber.Size = new System.Drawing.Size(117, 20);
            this.lbReceiptNumber.TabIndex = 4;
            this.lbReceiptNumber.Text = "Receipt Number";
            // 
            // lbReceiptDateTime
            // 
            this.lbReceiptDateTime.AutoSize = true;
            this.lbReceiptDateTime.Location = new System.Drawing.Point(9, 30);
            this.lbReceiptDateTime.Name = "lbReceiptDateTime";
            this.lbReceiptDateTime.Size = new System.Drawing.Size(78, 20);
            this.lbReceiptDateTime.TabIndex = 5;
            this.lbReceiptDateTime.Text = "Date Time";
            // 
            // txtReceiptNumber
            // 
            this.txtReceiptNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceiptNumber.Enabled = false;
            this.txtReceiptNumber.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtReceiptNumber.Location = new System.Drawing.Point(135, 68);
            this.txtReceiptNumber.Name = "txtReceiptNumber";
            this.txtReceiptNumber.Size = new System.Drawing.Size(192, 26);
            this.txtReceiptNumber.TabIndex = 2;
            this.txtReceiptNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtDateTime.Location = new System.Drawing.Point(135, 27);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(192, 26);
            this.txtDateTime.TabIndex = 3;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpCostumerDetails
            // 
            this.gpCostumerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCostumerDetails.Controls.Add(this.lbCostumerName);
            this.gpCostumerDetails.Controls.Add(this.lbCostumerID);
            this.gpCostumerDetails.Controls.Add(this.txtCustomerName);
            this.gpCostumerDetails.Controls.Add(this.txtCustomerID);
            this.gpCostumerDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCostumerDetails.Location = new System.Drawing.Point(352, 3);
            this.gpCostumerDetails.Name = "gpCostumerDetails";
            this.gpCostumerDetails.Size = new System.Drawing.Size(322, 128);
            this.gpCostumerDetails.TabIndex = 0;
            this.gpCostumerDetails.TabStop = false;
            this.gpCostumerDetails.Text = "Costumer";
            // 
            // lbCostumerName
            // 
            this.lbCostumerName.AutoSize = true;
            this.lbCostumerName.Location = new System.Drawing.Point(16, 72);
            this.lbCostumerName.Name = "lbCostumerName";
            this.lbCostumerName.Size = new System.Drawing.Size(116, 20);
            this.lbCostumerName.TabIndex = 1;
            this.lbCostumerName.Text = "Costumer Name";
            // 
            // lbCostumerID
            // 
            this.lbCostumerID.AutoSize = true;
            this.lbCostumerID.Location = new System.Drawing.Point(16, 34);
            this.lbCostumerID.Name = "lbCostumerID";
            this.lbCostumerID.Size = new System.Drawing.Size(91, 20);
            this.lbCostumerID.TabIndex = 1;
            this.lbCostumerID.Text = "Costumer ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtCustomerName.Location = new System.Drawing.Point(138, 68);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(169, 26);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(138, 30);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(169, 27);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtCustomerID_PreviewKeyDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvDetail);
            this.panel2.Location = new System.Drawing.Point(12, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 354);
            this.panel2.TabIndex = 2;
            // 
            // dgvDetail
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_code,
            this.name,
            this.unit_type,
            this.quantity,
            this.price,
            this.total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvDetail.RowTemplate.Height = 35;
            this.dgvDetail.RowTemplate.ReadOnly = true;
            this.dgvDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(879, 354);
            this.dgvDetail.TabIndex = 1;
            this.dgvDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetail_RowsAdded);
            this.dgvDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetail_RowsRemoved);
            this.dgvDetail.SelectionChanged += new System.EventHandler(this.dgvDetail_SelectionChanged);
            this.dgvDetail.SizeChanged += new System.EventHandler(this.dgvDetail_SizeChanged);
            // 
            // product_code
            // 
            this.product_code.HeaderText = "Product Code";
            this.product_code.Name = "product_code";
            this.product_code.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Product Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit_type
            // 
            this.unit_type.HeaderText = "Unit";
            this.unit_type.Name = "unit_type";
            this.unit_type.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // pnSummary
            // 
            this.pnSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSummary.BackColor = System.Drawing.Color.Transparent;
            this.pnSummary.Controls.Add(this.btnPayment);
            this.pnSummary.Controls.Add(this.txtTotal);
            this.pnSummary.Controls.Add(this.tbTotal);
            this.pnSummary.Controls.Add(this.txtSatff);
            this.pnSummary.Controls.Add(this.lbStaff);
            this.pnSummary.Location = new System.Drawing.Point(12, 530);
            this.pnSummary.Name = "pnSummary";
            this.pnSummary.Size = new System.Drawing.Size(1044, 57);
            this.pnSummary.TabIndex = 3;
            this.pnSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSummary_Paint);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.btnPayment.Location = new System.Drawing.Point(938, 6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(103, 46);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "Make a Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(591, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(241, 35);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.AutoSize = true;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(517, 14);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(59, 30);
            this.tbTotal.TabIndex = 1;
            this.tbTotal.Text = "Total";
            // 
            // txtSatff
            // 
            this.txtSatff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSatff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSatff.Enabled = false;
            this.txtSatff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatff.Location = new System.Drawing.Point(91, 12);
            this.txtSatff.Multiline = true;
            this.txtSatff.Name = "txtSatff";
            this.txtSatff.Size = new System.Drawing.Size(239, 35);
            this.txtSatff.TabIndex = 2;
            this.txtSatff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbStaff
            // 
            this.lbStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaff.Location = new System.Drawing.Point(29, 14);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(61, 30);
            this.lbStaff.TabIndex = 1;
            this.lbStaff.Text = "Staff:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newCustomerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newCustomerToolStripMenuItem.Text = "New &Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.pnSummary);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSelling";
            this.Text = "Selling ";
            this.Load += new System.EventHandler(this.frmSelling_Load);
            this.pnInfo.ResumeLayout(false);
            this.gpPayment.ResumeLayout(false);
            this.gpPayment.PerformLayout();
            this.pnCostumer.ResumeLayout(false);
            this.gpNewProduct.ResumeLayout(false);
            this.gpNewProduct.PerformLayout();
            this.gpReceiptDetails.ResumeLayout(false);
            this.gpReceiptDetails.PerformLayout();
            this.gpCostumerDetails.ResumeLayout(false);
            this.gpCostumerDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.pnSummary.ResumeLayout(false);
            this.pnSummary.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnSummary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnCostumer;
        private System.Windows.Forms.GroupBox gpReceiptDetails;
        private System.Windows.Forms.Label lbReceiptNumber;
        private System.Windows.Forms.Label lbReceiptDateTime;
        private System.Windows.Forms.TextBox txtReceiptNumber;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.GroupBox gpCostumerDetails;
        private System.Windows.Forms.Label lbCostumerName;
        private System.Windows.Forms.Label lbCostumerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label tbTotal;
        private System.Windows.Forms.TextBox txtSatff;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gpNewProduct;
        private System.Windows.Forms.Button btnAddToCash;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.GroupBox gpPayment;
        private System.Windows.Forms.TextBox txtExtraMoney;
        private System.Windows.Forms.TextBox txtMoneyReceived;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.Label lbExtraMoney;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label lbMoneyReceive;
        private System.Windows.Forms.Label lbPaymentMenthol;
    }
}