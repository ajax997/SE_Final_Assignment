using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace Shopping_Management
{
    public partial class frmDashboard : Form
    {
        private bool en;
        private string fullname;
        private int staffID;
        public frmDashboard(bool en, bool admin, string fullname, int staffID)
        {
           
            InitializeComponent();
            this.en = en;
            this.fullname = fullname;
            this.staffID = staffID;

           

        }

        private bool mouseDown;
        private Point lastLocation;

        private void frmDashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmDashBoard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void picSelling_Click(object sender, EventArgs e)
        {
            frmSelling frm = new frmSelling(en,fullname, staffID);
            frm.Show();
        }
        private void picReport_MouseHover(object sender, EventArgs e)
        {
            lbInfor.Text = Language.GetStringMessage(en,"frmDashBoard_picReport");
            Color c = this.BackColor;
            picReport.BackColor = Color.FromArgb(Math.Max(c.A - 10, (byte)0), c.R, c.G, c.B);
        }

        private void picSelling_MouseHover(object sender, EventArgs e)
        {
           lbInfor.Text = Language.GetStringMessage(en,"frmDashBoard_picSelling");
        }

        private void picStatictis_MouseHover(object sender, EventArgs e)
        {
         lbInfor.Text =Language.GetStringMessage(en,"frmDashBoard_picStatistic");
        }

        private void picSetting_MouseHover(object sender, EventArgs e)
        {
           lbInfor.Text = Language.GetStringMessage(en,"frmDashBoard_picSetting");
        }

        private void picStaffManagement_MouseHover(object sender, EventArgs e)
        {
           lbInfor.Text =Language.GetStringMessage(en,"frmDashBoard_picStaff");
        }

        private void picImport_MouseHover(object sender, EventArgs e)
        {
            lbInfor.Text = Language.GetStringMessage(en,"frmDashBoard_picImport");
        }

        private void picStaffManagement_MouseLeave(object sender, EventArgs e)
        {
            lbInfor.Text = "";
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show(fullname);
            lbDashboard.Text = Language.GetStringMessage(en, "frmDashBoard_lbDashBoard");
            this.Text = Language.GetStringMessage(en, "frmDashBoard_Title");
        }

        private void picImport_Click(object sender, EventArgs e)
        {
            frmImportProducts importProducts = new frmImportProducts(en);
            importProducts.Show();
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            frmWelcome frm = new frmWelcome();
            frm.Show();
               
            this.Dispose();
            
        }

        private void picReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport( en);
            report.Show();
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting(en);
            setting.ShowDialog();
        }

        private void picStatictis_Click(object sender, EventArgs e)
        {
            frmHistory frmHistory = new frmHistory(en);
            frmHistory.Show();
        }

        private void picStaffManagement_Click(object sender, EventArgs e)
        {
            frmStaffManagement frmStaff = new frmStaffManagement(en);
            frmStaff.Show();
        }
    }
}
