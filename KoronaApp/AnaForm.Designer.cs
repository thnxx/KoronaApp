
namespace KoronaApp
{
    partial class AnaForm
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
            this.tespitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belirtiTespitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yuzdeTespitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tespitToolStripMenuItem,
            this.yardimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tespitToolStripMenuItem
            // 
            this.tespitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.belirtiTespitToolStripMenuItem,
            this.yuzdeTespitToolStripMenuItem});
            this.tespitToolStripMenuItem.Name = "tespitToolStripMenuItem";
            this.tespitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.tespitToolStripMenuItem.Text = "Tespit";
            // 
            // yardimToolStripMenuItem
            // 
            this.yardimToolStripMenuItem.Name = "yardimToolStripMenuItem";
            this.yardimToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardimToolStripMenuItem.Text = "Yardim";
            this.yardimToolStripMenuItem.Click += new System.EventHandler(this.yardimToolStripMenuItem_Click);
            // 
            // belirtiTespitToolStripMenuItem
            // 
            this.belirtiTespitToolStripMenuItem.Name = "belirtiTespitToolStripMenuItem";
            this.belirtiTespitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.belirtiTespitToolStripMenuItem.Text = "Belirti Tespit";
            // 
            // yuzdeTespitToolStripMenuItem
            // 
            this.yuzdeTespitToolStripMenuItem.Name = "yuzdeTespitToolStripMenuItem";
            this.yuzdeTespitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yuzdeTespitToolStripMenuItem.Text = "Yuzde Tespit";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Korona App";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tespitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belirtiTespitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yuzdeTespitToolStripMenuItem;
    }
}

