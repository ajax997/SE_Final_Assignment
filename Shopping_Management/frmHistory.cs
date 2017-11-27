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
    public partial class frmHistory : Form
    {

        InvoiceHelper InvoiceHelper = new InvoiceHelper();
        public frmHistory(bool en)
        {
            InitializeComponent();
           
            
        }


        public void DataGirdViewResize(DataGridView dgvDetail )
        {
            foreach (DataGridViewColumn da in dgvDetail.Columns)
            {
                da.Width = dgvDetail.Width / dgvDetail.Columns.Count;
            }
            if (dgvDetail.Height >= dgvDetail.Rows.Count * dgvDetail.RowTemplate.Height)
                for (int i = 0; i < (dgvDetail.Height) / (dgvDetail.RowTemplate.Height); i++)
                {
                    dgvDetail.Rows.Add();
                }
        }
        private void dgvDetail_SizeChanged(object sender, EventArgs e)
        {
            DataGirdViewResize((DataGridView)sender);
        }

        private void dgvDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = 0;
            DataGridView data = sender as DataGridView;
            foreach (DataGridViewRow row in data.Rows)
            {
                if (i % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(172, 216, 233);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                }
                i++;
            }
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            
            dgvDetail.Rows.Clear();
            List<Invoice> list = InvoiceHelper.GetAllInvoice();
            int index = 0;
            foreach(Invoice invoice in list)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDetail.Rows[index].Clone();
                row.Cells[0].Value = invoice.invoice_id;
                row.Cells[1].Value = invoice.staff_id;
                row.Cells[2].Value = invoice.staff_name;
                row.Cells[3].Value = invoice.customer_id;
                row.Cells[4].Value = invoice.date;
                row.Cells[5].Value = invoice.total_price;
                row.Cells[6].Value = invoice.product_quantity;
                row.Cells[7].Value = invoice.payment_menthol;
                dgvDetail.Rows.Add(row);

                index++;
            }

           this.Height += 1;
        }

        private void dgvDetail_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int invoice_id = (int)dgvDetail.SelectedRows[0].Cells[0].Value;
            List<InvoiceItem> invoiceItems = InvoiceHelper.GetAllItemFromInvoiceID(invoice_id);
            dgDetails.Rows.Clear();
            int index = 0;
            foreach(InvoiceItem invoice in invoiceItems)
            {
                DataGridViewRow row = (DataGridViewRow)dgDetails.Rows[index].Clone();
                row.Cells[0].Value = invoice.ProductID;
                row.Cells[1].Value = invoice.Name;
                row.Cells[2].Value = invoice.Quantity;
                row.Cells[3].Value = invoice.Unit;
                row.Cells[4].Value = invoice.Price;
                row.Cells[5].Value = invoice.Total;
                dgDetails.Rows.Add(row);

                index++;

            }
            dgDetails.ClearSelection();
            tpDetail.Text = "List Items - " + invoice_id;
            tabDetails.SelectedIndex = 1;
        }
    }


}
