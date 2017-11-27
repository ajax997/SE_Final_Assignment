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
    public partial class frmSetting : Form
    {

        AuthenticationHelper authentication = new AuthenticationHelper();
        List<UserLogin> user;
        public frmSetting(bool en)
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
             user = authentication.GetAllStaff(true);
            foreach(UserLogin u in user )
            {
                cbID.Items.Add(u.staff_id);
            }

        }
        public string FindName(int id)
        {
            foreach (UserLogin u in user)
            {
                if (u.staff_id == id)
                    return u.fullname;
            }
            return "";
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFullname.Text = FindName(int.Parse(cbID.Text));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text != txtRetypePass.Text)
            {
                MessageBox.Show("Retype Password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
               if( authentication.UpdateUser(new UserLogin(int.Parse(cbID.Text), Encryption.sha256(txtNewPass.Text), txtFullname.Text, " ", "", "", "", 1), true))
                {
                    MessageBox.Show("Update Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Unknown Error!", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
