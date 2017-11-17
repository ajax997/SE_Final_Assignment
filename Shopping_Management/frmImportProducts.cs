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
            dgvDetail.ClearSelection();
            FormClear();
            cbUnit.SelectedIndex = 0;
        }
        private void dgvDetail_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
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

      

        public void FormClear()
        {
            dgvDetail.ClearSelection();
            txtName.Text = "";
            txtProductCode.Text = "";
            txtquantity.Text = "";
            txtPrice.Text = "";
            cbUnit.SelectedIndex = 0;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtProductCode.Enabled = true;
            cbAvailable.Enabled = false;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtProductCode.Text == "" || txtName.Text =="" || txtquantity.Text =="" || txtPrice.Text =="")
            {
                MessageBox.Show("Please fill all fields to process this action!", "Field missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int current = 0;
            foreach (DataGridViewRow row in dgvDetail.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if ((int)row.Cells[0].Value == int.Parse(txtProductCode.Text.Trim()))
                    {
                        current = (int)row.Cells[3].Value;
                    }
                }
               
            }

            Product pro = new Product(int.Parse(txtProductCode.Text), txtName.Text, cbUnit.Text, int.Parse(txtquantity.Text) + current,txtPrice.Text, 1);
            if (ProductHelper.InsertProduct(pro))
            {
                UpdateTable();
                FormClear();
            }
            else
            {
                MessageBox.Show("Error while trying to insert or update product to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = null;
                textWithcomma = "0"; //this property maintain the content of textbox with comma
                textWithoutcomma = "0";  //this property maintain the content of textbox without comma
            }
            else
            {
                if (txtPrice.Text != "")
                {
                    double d = Convert.ToDouble(skipComma(txtPrice.Text));
                    txtPrice.Text = d.ToString("#,#",
                      System.Globalization.CultureInfo.InvariantCulture);
                    textWithcomma = txtPrice.Text;//property maintain content of textbox with comma
                    textWithoutcomma = skipComma(txtPrice.Text);
                    //property maintain content of textbox without comma
                }
            }
            txtPrice.Select(txtPrice.Text.Length, 0);
        }

        private void txtPrice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                txtPrice.Text += "000";
                e.IsInputKey = true;
            }
        }

        private void dgvDetail_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                txtProductCode.Enabled = false;
                cbAvailable.Enabled = true;
                DataGridViewRow row = dgvDetail.SelectedRows[0];
                txtProductCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cbUnit.Text = row.Cells[2].Value.ToString();
                txtquantity.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                cbAvailable.Checked = (int.Parse(row.Cells[5].ToString()) == 1);
            }
            catch
            {

            }
        }

        private void frmImportProducts_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void frmImportProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                FormClear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to edit this product, this action can not undo?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Product pro = new Product(int.Parse(txtProductCode.Text), txtName.Text, cbUnit.Text, int.Parse(txtquantity.Text), txtPrice.Text, cbAvailable.Checked ? 1 : 0);
                ProductHelper.UpdateProduct(pro);
                UpdateTable();
                FormClear();
            }
   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this product, this action can not undo?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductHelper.DeleteProduct(int.Parse(txtProductCode.Text));
                UpdateTable();
                FormClear();
            }
        }
    }
}
