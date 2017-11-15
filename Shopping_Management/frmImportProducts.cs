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
    public partial class frmImportProducts : Form
    {
        public frmImportProducts(bool en)
        {
            InitializeComponent();
        }

        private void frmImportProducts_Load(object sender, EventArgs e)
        {
            this.Height = this.Height + 1;
        }

        public void DataGirdViewResize()
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
                i++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
