using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shopping_Management
{
    public partial class frmSelling : Form
    {
        bool fullScreen = true;
        string staffName;
        int staffID;
        InvoiceHelper InvoiceHelper = new InvoiceHelper();
        public frmSelling(bool en, string staffName, int staffID)
        {
            InitializeComponent();
            DataGirdViewResize();
            dgvDetail.Rows.Clear();
            this.staffName = staffName;
            this.staffID = staffID;
        }


        private void frmSelling_Load(object sender, EventArgs e)
        {

            GoFullscreen(true);
            dgvDetail.Rows.Clear();
            dgvDetail.ClearSelection();
            txtSatff.Text = staffName;
            rbCard.Checked = false;
            rbCash.Checked = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnDelete.Enabled = false;
            txtCustomerID.Text = "1";
            txtCustomerID_PreviewKeyDown(null, new PreviewKeyDownEventArgs(Keys.Enter));
            
            txtTotal.Text = "";
            txtProductID.Text = "";
            txtProductQuantity.Text = "";
            btnPayment.Enabled = false;
            
            txtDateTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            if (InvoiceHelper.GetCurrentInvoiceNumber() == -1)
                txtReceiptNumber.Text = "10000001";
            else
                txtReceiptNumber.Text = (InvoiceHelper.GetCurrentInvoiceNumber() + 1).ToString();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                fullScreen = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                fullScreen = false;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fullScreen)
                GoFullscreen(false);
            else
                GoFullscreen(true);

        }

        public void DataGirdViewResize()
        {
            foreach (DataGridViewColumn da in dgvDetail.Columns)
            {
                da.Width = dgvDetail.Width / dgvDetail.Columns.Count;
            }
            //if (dgvDetail.Height >= dgvDetail.Rows.Count * dgvDetail.RowTemplate.Height)
            //    for (int i = 0; i < (dgvDetail.Height) / (dgvDetail.RowTemplate.Height); i++)
            //    {
            //        dgvDetail.Rows.Add();
            //    }
        }
        private void dgvDetail_SizeChanged(object sender, EventArgs e)
        {
            DataGirdViewResize();
        }

        private void dgvDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = 0;
            int sum = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                try
                {
                    if (!row.Cells[5].Value.Equals(""))
                    {
                        sum += int.Parse(row.Cells[5].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);
                    }

                    if (i % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 160, 120);
                    }
                    else
                    { row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); }
                    i++;
                }
                catch { }
            }
            txtTotal.Text = sum.ToString("#,##0");
        }
        private void dgvDetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int i = 0;
            int sum = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                try
                {
                    if (!row.Cells[5].Value.Equals(""))
                    {
                        sum += int.Parse(row.Cells[5].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);
                    }

                    if (i % 2 == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(0, 160, 120);
                    }
                    else
                    { row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); }
                    i++;
                }
                catch { }
            }
            txtTotal.Text = sum.ToString("#,##0");
        }

        private void pnSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer addNewCustomer = new frmAddNewCustomer();
            addNewCustomer.ShowDialog();
        }

        private void txtCustomerID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (txtCustomerID.Text.Trim() == "1")
                {
                    txtCustomerName.Text = "Guest";
                }
                else
                {
                    string res = InvoiceHelper.CheckCustomerExist(txtCustomerID.Text);
                    if (res == "-1")
                    {
                        MessageBox.Show("There no customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtCustomerName.Text = res;
                    }
                }
            }
        }

        private void btnAddToCash_Click(object sender, EventArgs e)
        {
            if (txtProductQuantity.Text == "" || txtProductID.Text == "")
            {
                MessageBox.Show("Input quantity and Product ID!", "Input Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Product product = InvoiceHelper.CheckProductID(int.Parse(txtProductID.Text));
                if (product == null)
                {
                    string message = "There is no product with code" + txtProductID.Text + " please check again!";
                    MessageBox.Show(message, "No Product ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    for (int i = 0; i< dgvDetail.Rows.Count-1; i++)
                    {
                        DataGridViewRow r = dgvDetail.Rows[i];

                        if (r.Cells[0].Value.ToString().Equals(txtProductID.Text))
                        {
                            dgvDetail.BeginEdit(true);
                            r.Cells[3].Value = int.Parse(r.Cells[3].Value.ToString()) + int.Parse(txtProductQuantity.Text);
                            r.Cells[5].Value = (int.Parse(r.Cells[3].Value.ToString()) * int.Parse(product.price,
                                System.Globalization.NumberStyles.AllowThousands)).ToString("#,##0");
                            dgvDetail_RowsAdded(null, null);
                            if (txtMoneyReceived.Text.Length > 0)
                                txtMoneyReceived_PreviewKeyDown(null, new PreviewKeyDownEventArgs(Keys.Enter));
                            return;

                        }
                        
                    }
                    DataGridViewRow row = (DataGridViewRow)dgvDetail.Rows[dgvDetail.Rows.Count - 1].Clone();
                    row.Cells[0].Value = product.productID;
                    row.Cells[1].Value = product.productName;
                    row.Cells[2].Value = product.unit;
                    row.Cells[3].Value = txtProductQuantity.Text;
                    row.Cells[4].Value = product.price;



                    int price = int.Parse(product.price, System.Globalization.NumberStyles.AllowThousands);
                    row.Cells[5].Value = (price * (int.Parse(txtProductQuantity.Text))).ToString("#,##0");
                    dgvDetail.Rows.Add(row);
                    dgvDetail.ClearSelection();
                }

            }
        }

        private void txtProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void dgvDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetail.Rows.Count != 1)
            {
                btnDelete.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDetail.Rows.RemoveAt(dgvDetail.SelectedRows[0].Index);
                if (txtMoneyReceived.Text.Length > 0)
                    txtMoneyReceived_PreviewKeyDown(null, new PreviewKeyDownEventArgs(Keys.Enter));
                if (dgvDetail.Rows.Count == 1)
                {
                    btnNext.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPayment.Enabled = false;
                }
            }
            catch
            {

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDetail.Rows[dgvDetail.SelectedRows[0].Index - 1].Selected = true;
                if (dgvDetail.SelectedRows[0].Index == 0)
                    btnPrevious.Enabled = false;
            }
            catch
            { }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDetail.Rows[dgvDetail.SelectedRows[0].Index + 1].Selected = true;
                if (dgvDetail.SelectedRows[0].Index == dgvDetail.Rows.Count - 1)
                    btnNext.Enabled = false;
            }
            catch
            { }
            
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCard.Checked)
            {
                txtMoneyReceived.Enabled = false;
                btnPayment.Enabled = true;
            }
            else
            {
                txtMoneyReceived.Enabled = true;
            }
        }

        public string textWithcomma { get; set; }
        public string textWithoutcomma { get; set; }

        public string skipComma(string str)
        {
            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }


        private void txtMoneyReceived_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if(dgvDetail.Rows.Count == 1)
                {
                    MessageBox.Show("There no product to process yet!", "No product!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtExtraMoney.Text = "";
                    txtMoneyReceived.Text = "";
                    btnPayment.Enabled = false;
                    return;
                }
                if (txtMoneyReceived.Text.Length > 0)
                    if ((int.Parse(txtMoneyReceived.Text, System.Globalization.NumberStyles.AllowThousands) > int.Parse(txtTotal.Text, System.Globalization.NumberStyles.AllowThousands)))
                        txtExtraMoney.Text = (int.Parse(txtMoneyReceived.Text, System.Globalization.NumberStyles.AllowThousands)
                            - int.Parse(txtTotal.Text, System.Globalization.NumberStyles.AllowThousands)).ToString("#,##0");
                    else
                    {
                        MessageBox.Show("Recieved Money not enough for this invoice!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMoneyReceived.Text = "";
                        txtExtraMoney.Text = "";
                    }
            }
            if (e.KeyData == Keys.Tab)
            {
                if (txtMoneyReceived.Text.Length < 10)
                    txtMoneyReceived.Text += "000";
                e.IsInputKey = true;

            }

        }

        private void txtMoneyReceived_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneyReceived.Text == "")
            {
                txtMoneyReceived.Text = null;
                textWithcomma = "0"; //this property maintain the content of textbox with comma
                textWithoutcomma = "0";  //this property maintain the content of textbox without comma
            }
            else
            {
                if (txtMoneyReceived.Text != "")
                {
                    double d = Convert.ToDouble(skipComma(txtMoneyReceived.Text));
                    txtMoneyReceived.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = txtMoneyReceived.Text;//property maintain content of textbox with comma
                    textWithoutcomma = skipComma(txtMoneyReceived.Text);
                    //property maintain content of textbox without comma
                }
            }
            txtMoneyReceived.Select(txtMoneyReceived.Text.Length, 0);
        }

        private void txtMoneyReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            txtMoneyReceived.Enabled = !rbCard.Checked;
        }

        private void txtExtraMoney_TextChanged(object sender, EventArgs e)
        {
            btnPayment.Enabled = true;
        }

        private void txtProductQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnAddToCash_Click(null, null);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice(int.Parse(txtReceiptNumber.Text), staffID, staffName, int.Parse(txtCustomerID.Text)
                , txtDateTime.Text, txtTotal.Text, dgvDetail.Rows.Count - 1, rbCash.Checked ? "Cash" : "Card");

            for (int i = 0; i < dgvDetail.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dgvDetail.Rows[i];
                InvoiceItem invoiceItem = new InvoiceItem(int.Parse(txtReceiptNumber.Text), int.Parse(row.Cells[0].Value.ToString())
                    , row.Cells[1].Value.ToString(), (row.Cells[2]).Value.ToString(), int.Parse(row.Cells[3].Value.ToString(), System.Globalization.NumberStyles.AllowThousands),
                    row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString());
                InvoiceHelper.InsertInvoiceItem(invoiceItem);

                Product product = InvoiceHelper.CheckProductID(int.Parse(row.Cells[0].Value.ToString()));

                if(product.quantity <= int.Parse(row.Cells[3].Value.ToString()))
                {
                    InvoiceHelper.UpdateProduct(int.Parse(row.Cells[0].Value.ToString()), 0, 0);
                }
                else
                {
                    InvoiceHelper.UpdateProduct(int.Parse(row.Cells[0].Value.ToString()), product.quantity - int.Parse(row.Cells[3].Value.ToString()), 1);
                }
            }

            if(InvoiceHelper.InsertInvoice(invoice))
            {
               if( MessageBox.Show("Payment completed, Do you want to make a new cash?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    frmSelling_Load(this, null);
                }
               else
                {

                }
            }
        }
    }
}
