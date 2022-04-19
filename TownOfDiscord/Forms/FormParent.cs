using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using TownOfDiscord.Forms;
using TownOfDiscord.Game;
using System.Diagnostics;

namespace TownOfDiscord
{
    public partial class FormParent : Form
    {
        private IconButton currentNavBtn;
        private Panel leftBoarderBtn;
        private Form currentChildForm;

        public FormParent()
        {
            InitializeComponent();

            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7, 56);
            panelNav.Controls.Add(leftBoarderBtn);

            //Form - remove boarder
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // Form - Formats it to the screen better
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color red = Color.FromArgb(255, 77, 77);
            public static Color orange = Color.FromArgb(255, 102, 0);
            public static Color yellow = Color.FromArgb(255, 255, 0);
            public static Color green = Color.FromArgb(0, 153, 51);
            public static Color blue = Color.FromArgb(51, 51, 255);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentNavBtn = (IconButton)senderBtn;
                currentNavBtn.BackColor = Color.FromArgb(23, 23, 24);
                currentNavBtn.ForeColor = color;
                currentNavBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentNavBtn.IconColor = color;
                currentNavBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentNavBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Boarder Button
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0, currentNavBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                // Icon current child form
                pbCurrentIcon.IconChar = currentNavBtn.IconChar;
                pbCurrentIcon.IconColor = color;
                // planelShadow
                panelTitleBarShadow.BackColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentNavBtn != null)
            {
                currentNavBtn.BackColor = Color.FromArgb(36, 37, 39);
                currentNavBtn.ForeColor = Color.White;
                currentNavBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentNavBtn.IconColor = Color.White;
                currentNavBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentNavBtn.ImageAlign = ContentAlignment.MiddleLeft;
                panelTitleBarShadow.BackColor = Color.FromArgb(36, 37, 39);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCurrentForm.Controls.Add(childForm);
            panelCurrentForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentTitle.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBoarderBtn.Visible = false;

            pbCurrentIcon.IconChar = IconChar.Home;
            pbCurrentIcon.IconColor = Color.White;
            lblCurrentTitle.Text = "Home";
        }

        //Buttons
        private void btnConsole_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.red);
            OpenChildForm(new FormConsole());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}