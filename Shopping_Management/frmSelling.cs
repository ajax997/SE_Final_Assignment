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
        InvoiceHelper InvoiceHelper = new InvoiceHelper();
        public frmSelling(bool en, string staffName, int staffID)
        {
            InitializeComponent();
            DataGirdViewResize();
            dgvDetail.Rows.Clear();
            this.staffName = staffName;
        }


        private void frmSelling_Load(object sender, EventArgs e)
        {

            GoFullscreen(true);
            txtSatff.Text = staffName;
            txtDateTime.Text = DateTime.Now.ToShortDateString() + ":" + DateTime.Now.ToShortTimeString();

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
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (i % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(0, 160, 120);
                }
                else
                { row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); }
                i++;
            }
        }

        private void pnSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnAddToCash_Click(object sender, EventArgs e)
        {
            if (txtProductQuantity.Text == "")
            {
                MessageBox.Show("Input quantity!", "Quantity Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    DataGridViewRow row = (DataGridViewRow)dgvDetail.Rows[dgvDetail.Rows.Count].Clone();
                }
            }
        }
    }
}
