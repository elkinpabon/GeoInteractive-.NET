using System;
using System.Windows.Forms;

namespace GeoInteractiva
{
    public partial class FormRomboide : Form
    {
        private Figuras.Romboide romboide = new Figuras.Romboide();

        public FormRomboide()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBase.Text, out float b) &&
                float.TryParse(txtAltura.Text, out float h) &&
                float.TryParse(txtLado.Text, out float l) &&
                b > 0 && h > 0 && l > 0)
            {
                romboide.Base = b;
                romboide.Altura = h;
                romboide.Lado = l;
                lblArea.Text = $"Área: {romboide.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {romboide.CalcularPerimetro():F2}";
                panelDibujo.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            romboide.Rotar(10);
            panelDibujo.Invalidate();
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            romboide.Escalar(1.1f);
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            romboide.Dibujar(e.Graphics);
        }

        private void FormRomboide_KeyDown(object sender, KeyEventArgs e)
        {
            int dx = 0, dy = 0;
            if (e.KeyCode == Keys.Left) dx = -10;
            if (e.KeyCode == Keys.Right) dx = 10;
            if (e.KeyCode == Keys.Up) dy = -10;
            if (e.KeyCode == Keys.Down) dy = 10;

            romboide.Trasladar(dx, dy);
            panelDibujo.Invalidate();
        }
    }
}
