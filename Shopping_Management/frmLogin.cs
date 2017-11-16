using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Shopping_Management
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        bool _en;
        public frmLogin(bool en)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            _en = en;
            ChangeLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmWelcome frm = new frmWelcome();
            frm.Show();
            this.Dispose();
        }

        public void ChangeLanguage()
        {
            lbLogin.Text = Language.GetStringMessage(_en, "frmLogin_lbLogin");
            lbUser.Text = Language.GetStringMessage(_en, "frmLogin_lbUsername");
            lbPassword.Text = Language.GetStringMessage(_en, "frmLogin_lbPassword");
            btnLogin.Text = Language.GetStringMessage(_en, "frmLogin_btnLogin");
            btnCancel.Text = Language.GetStringMessage(_en, "frmLogin_btnCancel");
        }

        private bool mouseDown;
        private Point lastLocation;

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            frmDashboard frm = new frmDashboard(_en);
            frm.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(18, 115, 170);
            pnWarning.BackColor = Color.FromArgb(204, 51, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
