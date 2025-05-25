using System.Windows.Forms;

namespace GeoInteractiva
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem figurasToolStripMenuItem;
        private ToolStripMenuItem romboToolStripMenuItem;
        private ToolStripMenuItem pentagonoToolStripMenuItem;
        private ToolStripMenuItem romboideToolStripMenuItem;
        private ToolStripMenuItem trapezoideToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romboToolStripMenuItem,
            this.pentagonoToolStripMenuItem,
            this.romboideToolStripMenuItem,
            this.trapezoideToolStripMenuItem});
            this.figurasToolStripMenuItem.Font = new System.Drawing.Font("Unispace", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.figurasToolStripMenuItem.Text = "Figuras Geometricas";
            this.figurasToolStripMenuItem.Click += new System.EventHandler(this.figurasToolStripMenuItem_Click);
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboToolStripMenuItem.Text = "Rombo";
            this.romboToolStripMenuItem.Click += new System.EventHandler(this.romboToolStripMenuItem_Click);
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentagonoToolStripMenuItem.Text = "Pentágono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.romboideToolStripMenuItem.Text = "Romboide";
            this.romboideToolStripMenuItem.Click += new System.EventHandler(this.romboideToolStripMenuItem_Click);
            // 
            // trapezoideToolStripMenuItem
            // 
            this.trapezoideToolStripMenuItem.Name = "trapezoideToolStripMenuItem";
            this.trapezoideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trapezoideToolStripMenuItem.Text = "Trapezoide";
            this.trapezoideToolStripMenuItem.Click += new System.EventHandler(this.trapezoideToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GeoInteractiva - Figuras Geométricas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
