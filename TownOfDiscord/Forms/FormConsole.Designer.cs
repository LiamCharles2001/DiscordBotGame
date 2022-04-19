namespace TownOfDiscord.Forms
{
    partial class FormConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelConsole = new System.Windows.Forms.Panel();
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.panelConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelConsole
            // 
            this.panelConsole.Controls.Add(this.lblDisplayText);
            this.panelConsole.Controls.Add(this.rtbConsole);
            this.panelConsole.Controls.Add(this.tbConsole);
            this.panelConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsole.Location = new System.Drawing.Point(4, 4);
            this.panelConsole.Name = "panelConsole";
            this.panelConsole.Size = new System.Drawing.Size(792, 442);
            this.panelConsole.TabIndex = 0;
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDisplayText.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayText.Location = new System.Drawing.Point(3, 422);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(69, 15);
            this.lblDisplayText.TabIndex = 2;
            this.lblDisplayText.Text = "Type Here...";
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsole.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbConsole.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtbConsole.Location = new System.Drawing.Point(0, 0);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(792, 419);
            this.rtbConsole.TabIndex = 1;
            this.rtbConsole.Text = "C:\\Users\\Liam> CD Cake/File\n";
            // 
            // tbConsole
            // 
            this.tbConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbConsole.Location = new System.Drawing.Point(0, 419);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(792, 23);
            this.tbConsole.TabIndex = 0;
            this.tbConsole.Enter += new System.EventHandler(this.tbConsole_Enter);
            this.tbConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbConsole_KeyDown);
            this.tbConsole.Leave += new System.EventHandler(this.tbConsole_Leave);
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsole";
            this.Text = "Console";
            this.panel1.ResumeLayout(false);
            this.panelConsole.ResumeLayout(false);
            this.panelConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelConsole;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Label lblDisplayText;
    }
}