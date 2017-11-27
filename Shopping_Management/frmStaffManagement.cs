using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shopping_Management
{
    public partial class frmStaffManagement: Form
    {
        AuthenticationHelper authentication;
        public frmStaffManagement(bool en)
        {
            InitializeComponent();
           authentication  = new AuthenticationHelper();
        }

        public void DataGirdViewResize()
        {
            foreach (DataGridViewColumn da in dgvDetail.Columns)
            {
                da.Width = dgvDetail.Width / dgvDetail.Columns.Count;
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
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                }
                i++;
            }
        }

        public int GetStaffIDInOther()
        {
            return authentication.GetCurrentStaffNumber() + 1;
        }
        private void frmStaffManagement_Load(object sender, EventArgs e)
        {

            this.Height += 1;
            dgvDetail.Rows.Clear();
            List<UserLogin> list = authentication.GetAllStaff(false);
            int index = 0;

            foreach(UserLogin user in list)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDetail.Rows[index].Clone();
                row.Cells[0].Value = user.staff_id;
                row.Cells[1].Value = user.fullname;
                row.Cells[2].Value = user.sex;
                row.Cells[3].Value = user.DOB;
                row.Cells[4].Value = user.phone;
                row.Cells[5].Value = user.admin;
                dgvDetail.Rows.Add(row);

                index++;
            }

            reset();

        }

        public int ValidateForm()
        {
            if (txtNewPass.Text != txtRetypePass.Text)
                return -1;
            if (txtUsername.Text.Length == 0)
                return 0;
            if (cbSex.Text.Length == 0 || txtPhone.Text.Length == 0 || txtAddress.Text.Length == 0)
                return 1;
            return -99;
        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            AuthenticationHelper authentication = new AuthenticationHelper();
           

            switch(ValidateForm())
            {
                case -1:
                    MessageBox.Show("Retype password is not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 0:
                    MessageBox.Show("User ID requested!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 1:
                    MessageBox.Show("Missing some informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case -99:
                    UserLogin user = new UserLogin(int.Parse(txtUsername.Text), Encryption.sha256(txtNewPass.Text), txtFullname.Text, cbSex.Text, dtpDOB.Value.ToShortDateString(), txtPhone.Text, txtAddress.Text, 0);
                    if (authentication.InsertUser(user))
                    {
                        MessageBox.Show("Insert User Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmStaffManagement_Load(null, null);
                    }
                    break;
            }
          
         }

        private void frmStaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            authentication.Close();
        }

        private void lbAddress_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetail_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = dgvDetail.SelectedRows[0].Cells[0].Value.ToString();
                txtFullname.Text = dgvDetail.SelectedRows[0].Cells[1].Value.ToString();
                cbSex.Text = dgvDetail.SelectedRows[0].Cells[2].Value.ToString();
                dtpDOB.Text = dgvDetail.SelectedRows[0].Cells[3].Value.ToString();
                txtPhone.Text = dgvDetail.SelectedRows[0].Cells[4].Value.ToString();
                txtAddress.Text = dgvDetail.SelectedRows[0].Cells[5].Value.ToString();
              
                btnAddNewStaff.Enabled = false;
                btnDeleteStaff.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch
            {

            }

        }


         public void reset()
        {
            txtUsername.Text = GetStaffIDInOther().ToString();
            dgvDetail.ClearSelection();
            cbSex.Text = "";
          
            txtRetypePass.Text = "";
            txtPhone.Text = "";
            txtNewPass.Text = "";
            txtFullname.Text = "";
            txtAddress.Text = "";
            btnAddNewStaff.Enabled = false;
          
            btnDeleteStaff.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void dgvDetail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                reset();
                
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnAddNewStaff.Enabled = true;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            btnAddNewStaff.Enabled = true;
        }
    }
}
