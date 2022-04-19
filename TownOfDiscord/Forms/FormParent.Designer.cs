
using System.Windows.Forms;

namespace TownOfDiscord
{
    partial class FormParent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.pbCurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnConsole = new FontAwesome.Sharp.IconButton();
            this.panelProgram = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBarShadow = new System.Windows.Forms.Panel();
            this.panelCurrentForm = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentIcon)).BeginInit();
            this.panelNav.SuspendLayout();
            this.panelProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblCurrentTitle);
            this.panelTitleBar.Controls.Add(this.pbCurrentIcon);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(166, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(733, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(595, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 37);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(641, 7);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 37);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(687, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.AutoSize = true;
            this.lblCurrentTitle.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTitle.Location = new System.Drawing.Point(55, 24);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(40, 15);
            this.lblCurrentTitle.TabIndex = 1;
            this.lblCurrentTitle.Text = "Home";
            // 
            // pbCurrentIcon
            // 
            this.pbCurrentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.pbCurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.pbCurrentIcon.IconColor = System.Drawing.Color.White;
            this.pbCurrentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbCurrentIcon.IconSize = 45;
            this.pbCurrentIcon.Location = new System.Drawing.Point(6, 8);
            this.pbCurrentIcon.Name = "pbCurrentIcon";
            this.pbCurrentIcon.Size = new System.Drawing.Size(45, 45);
            this.pbCurrentIcon.TabIndex = 0;
            this.pbCurrentIcon.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panelNav.Controls.Add(this.btnConsole);
            this.panelNav.Controls.Add(this.panelProgram);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(166, 470);
            this.panelNav.TabIndex = 0;
            // 
            // btnConsole
            // 
            this.btnConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.ForeColor = System.Drawing.Color.White;
            this.btnConsole.IconChar = FontAwesome.Sharp.IconChar.GreaterThanEqual;
            this.btnConsole.IconColor = System.Drawing.Color.White;
            this.btnConsole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsole.IconSize = 32;
            this.btnConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsole.Location = new System.Drawing.Point(0, 63);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnConsole.Size = new System.Drawing.Size(166, 56);
            this.btnConsole.TabIndex = 1;
            this.btnConsole.Text = "Console";
            this.btnConsole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsole.UseVisualStyleBackColor = true;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // panelProgram
            // 
            this.panelProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panelProgram.Controls.Add(this.btnHome);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgram.Location = new System.Drawing.Point(0, 0);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(166, 63);
            this.panelProgram.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Yellow;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 38);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "</>";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBarShadow
            // 
            this.panelTitleBarShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.panelTitleBarShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBarShadow.Location = new System.Drawing.Point(166, 50);
            this.panelTitleBarShadow.Name = "panelTitleBarShadow";
            this.panelTitleBarShadow.Size = new System.Drawing.Size(733, 13);
            this.panelTitleBarShadow.TabIndex = 2;
            // 
            // panelCurrentForm
            // 
            this.panelCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.panelCurrentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurrentForm.Location = new System.Drawing.Point(166, 63);
            this.panelCurrentForm.Name = "panelCurrentForm";
            this.panelCurrentForm.Size = new System.Drawing.Size(733, 407);
            this.panelCurrentForm.TabIndex = 3;
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 470);
            this.Controls.Add(this.panelCurrentForm);
            this.Controls.Add(this.panelTitleBarShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelNav);
            this.Name = "FormParent";
            this.Text = "App";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentIcon)).EndInit();
            this.panelNav.ResumeLayout(false);
            this.panelProgram.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitleBar;
        private Panel panelNav;
        private Panel panelTitleBarShadow;
        private Panel panelCurrentForm;
        private Panel panelProgram;
        private FontAwesome.Sharp.IconButton btnConsole;
        private FontAwesome.Sharp.IconPictureBox pbCurrentIcon;
        private Label lblCurrentTitle;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}