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

        ProductHelper ProductHelper = new ProductHelper();
        public frmImportProducts(bool en)
        {
            InitializeComponent();
        }

        private void frmImportProducts_Load(object sender, EventArgs e)
        {
            this.Height = this.Height + 1;
            UpdateTable();
        }


        public void UpdateTable()
        {
            dgvDetail.Rows.Clear();
            List<Product> res = ProductHelper.getAll();
            int index = 0;
            foreach(Product pro in res)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDetail.Rows[index].Clone();
                row.Cells[0].Value = pro.productID;
                row.Cells[1].Value = pro.productName ;
                row.Cells[2].Value = pro.unit;
                row.Cells[3].Value = pro.quantity;
                row.Cells[4].Value = pro.price;
                row.Cells[5].Value = pro.available;
                dgvDetail.Rows.Add(row);
                index++;
            }
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
            int current = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if ((int)row.Cells[0].Value == int.Parse(txtProductCode.Text))
                    {
                        current = (int)row.Cells[3].Value;
                    }
                }
            }

            Product pro = new Product(int.Parse(txtProductCode.Text), txtName.Text, int.Parse(cbUnit.SelectedIndex.ToString()), int.Parse(txtquantity.Text) + current,txtPrice.Text, 1);
            if (ProductHelper.InsertProduct(pro))
                UpdateTable();
            else
            {
                MessageBox.Show("Error while trying to insert or update product to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
