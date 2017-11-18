using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shopping_Management
{
    public partial class frmAddNewCustomer : Form
    {
        CustomerHelper customerHelper = new CustomerHelper();
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(txtFullname.Text, dtpDOB.Value.ToShortDateString(), cbSex.SelectedIndex == 0 ? 1 : 0, 1, txtPhone.Text, txtAddress.Text);
            if(customerHelper.AddNewCustomer(customer))
            {
                MessageBox.Show("Insert customer successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
