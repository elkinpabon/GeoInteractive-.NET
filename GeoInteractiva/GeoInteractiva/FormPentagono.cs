using System;
using System.Windows.Forms;

namespace GeoInteractiva
{
    public partial class FormPentagono : Form
    {
        private Figuras.Pentagono pentagono = new Figuras.Pentagono();

        public FormPentagono()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLado.Text, out float lado) &&
                float.TryParse(txtApotema.Text, out float apotema) &&
                lado > 0 && apotema > 0)
            {
                pentagono.Lado = lado;
                pentagono.Apotema = apotema;
                lblArea.Text = $"Área: {pentagono.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {pentagono.CalcularPerimetro():F2}";
                panelDibujo.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            pentagono.Rotar(10);
            panelDibujo.Invalidate();
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            pentagono.Escalar(1.1f);
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            pentagono.Dibujar(e.Graphics);
        }

        private void FormPentagono_KeyDown(object sender, KeyEventArgs e)
        {
            int dx = 0, dy = 0;
            if (e.KeyCode == Keys.Left) dx = -10;
            if (e.KeyCode == Keys.Right) dx = 10;
            if (e.KeyCode == Keys.Up) dy = -10;
            if (e.KeyCode == Keys.Down) dy = 10;

            pentagono.Trasladar(dx, dy);
            panelDibujo.Invalidate();
        }
    }
}
