﻿namespace setur
{
    partial class AnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEZERVASYONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITLARToolStripMenuItem,
            this.iŞLEMLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITLARToolStripMenuItem
            // 
            this.kAYITLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONELToolStripMenuItem,
            this.oTELToolStripMenuItem});
            this.kAYITLARToolStripMenuItem.Name = "kAYITLARToolStripMenuItem";
            this.kAYITLARToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.kAYITLARToolStripMenuItem.Text = "KAYITLAR";
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pERSONELToolStripMenuItem.Text = "PERSONEL";
            this.pERSONELToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem_Click);
            // 
            // oTELToolStripMenuItem
            // 
            this.oTELToolStripMenuItem.Name = "oTELToolStripMenuItem";
            this.oTELToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTELToolStripMenuItem.Text = "OTEL";
            this.oTELToolStripMenuItem.Click += new System.EventHandler(this.oTELToolStripMenuItem_Click);
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEZERVASYONToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // rEZERVASYONToolStripMenuItem
            // 
            this.rEZERVASYONToolStripMenuItem.Name = "rEZERVASYONToolStripMenuItem";
            this.rEZERVASYONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rEZERVASYONToolStripMenuItem.Text = "REZERVASYON";
            this.rEZERVASYONToolStripMenuItem.Click += new System.EventHandler(this.rEZERVASYONToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.Text = "SETUR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEZERVASYONToolStripMenuItem;
    }
}

