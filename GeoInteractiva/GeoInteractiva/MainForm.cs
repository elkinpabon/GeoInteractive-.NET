using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoInteractiva
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            StartPosition = FormStartPosition.CenterScreen; 
            Size = new Size(900, 600); 
            MaximizeBox = false;
        }

        private void AbrirFormulario(Form form)
        {
            foreach (Form hijo in MdiChildren)
            {
                hijo.Close();
            }

            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new Size(600, 500);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRombo());
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPentagono());
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormRomboide());
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormTrapezoide());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
