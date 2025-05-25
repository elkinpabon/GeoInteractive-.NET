using System;
using System.Windows.Forms;

namespace GeoInteractiva
{
    public partial class FormRombo : Form
    {
        private Figuras.Rombo rombo = new Figuras.Rombo();

        public FormRombo()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtD1.Text, out float d1) &&
                float.TryParse(txtD2.Text, out float d2) &&
                d1 > 0 && d2 > 0)
            {
                rombo.DiagonalMayor = d1;
                rombo.DiagonalMenor = d2;
                lblArea.Text = $"Área: {rombo.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {rombo.CalcularPerimetro():F2}";
                panelDibujo.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            rombo.Rotar(10);
            panelDibujo.Invalidate();
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            rombo.Escalar(1.1f);
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            rombo.Dibujar(e.Graphics);
        }

        private void FormRombo_KeyDown(object sender, KeyEventArgs e)
        {
            int dx = 0, dy = 0;
            if (e.KeyCode == Keys.Left) dx = -10;
            if (e.KeyCode == Keys.Right) dx = 10;
            if (e.KeyCode == Keys.Up) dy = -10;
            if (e.KeyCode == Keys.Down) dy = 10;

            rombo.Trasladar(dx, dy);
            panelDibujo.Invalidate();
        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void FormRombo_Load(object sender, EventArgs e)
        {

        }
    }
}
