using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TownOfDiscord.Forms
{
    public partial class FormConsole : Form
    {
        public FormConsole()
        {
            InitializeComponent();
        }

        private void tbConsole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            rtbConsole.Text += $"{tbConsole.Text}\n";
            tbConsole.Text = "";
        }

        private void tbConsole_Enter(object sender, EventArgs e)
        {
            lblDisplayText.Visible = false;
        }

        private void tbConsole_Leave(object sender, EventArgs e)
        {
            if (tbConsole.Text == "")
                lblDisplayText.Visible = true;
            else
                lblDisplayText.Visible = false;
        }
    }
}
