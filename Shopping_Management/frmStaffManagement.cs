﻿using System;
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

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            this.Height += 1;
        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            AuthenticationHelper authentication = new AuthenticationHelper();
            int sex = 0;
            if (cbSex.SelectedIndex == 1)
                sex = 1;
            else
                sex = 0;
            UserLogin user = new UserLogin(int.Parse(txtUsername.Text), Encryption.sha256(txtNewPass.Text), txtFullname.Text, sex, dtpDOB.Value.ToShortDateString(), txtPhone.Text, txtAddress.Text, 1);
            if (authentication.InsertUser(user))
            {
                MessageBox.Show("Insert User Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void frmStaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            authentication.Close();
        }

        private void lbAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
