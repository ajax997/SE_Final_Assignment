using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace Shopping_Management
{
    public partial class frmWelcome : Form
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

        public frmWelcome()
        {
            InitializeComponent();
           // MessageBox.Show(Language.GetStringMessage(false, "frmWelcome_txtWelcome"));
            picLogin.BackColor = Color.Transparent;
            lbLanguage.BackColor = Color.Transparent;
            cbLanguage.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private bool mouseDown;
        private Point lastLocation;

        private void frmWelcome_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmWelcome_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Change_Language(bool en)
        {

            if (en)
            {

                lbInfo.Text = Language.GetStringMessage(en, "frmWelcome_txtWelcome");
                lbLanguage.Text = Language.GetStringMessage(en, "frmWelcome_lbLang");
                cbLanguage.Items.Clear();
                cbLanguage.Items.Add(Language.GetStringMessage(en, "frmWelcome_cbLang1"));
                cbLanguage.Items.Add(Language.GetStringMessage(en, "frmWelcome_cbLang2"));
                cbLanguage.SelectedIndex = 0;

                btnClose.Text = Language.GetStringMessage(en, "frmWelcome_btnClose");
            }
            else
            {
                lbInfo.Text = Language.GetStringMessage(en, "frmWelcome_txtWelcome");
                lbLanguage.Text = Language.GetStringMessage(en, "frmWelcome_lbLang");
                cbLanguage.Items.Clear();
                cbLanguage.Items.Add(Language.GetStringMessage(en, "frmWelcome_cbLang1"));
                cbLanguage.Items.Add(Language.GetStringMessage(en, "frmWelcome_cbLang2"));
                cbLanguage.SelectedIndex = 1;

                btnClose.Text = Language.GetStringMessage(en, "frmWelcome_btnClose");
            }
        }
            

        private void picLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(cbLanguage.SelectedIndex == 0);
            login.ShowDialog();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }
        bool en=true;
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbLanguage.SelectedIndex == 0 && !en)
            {
                en = true;
                Change_Language(true);
              
            }
            if (cbLanguage.SelectedIndex == 1 && en)
            {
                en = false;
                Change_Language(false);
               
            }
        }
    }
}
