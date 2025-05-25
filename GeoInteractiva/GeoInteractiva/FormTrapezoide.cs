using System;
using System.Windows.Forms;

namespace GeoInteractiva
{
    public partial class FormTrapezoide : Form
    {
        private Figuras.Trapezoide trapezoide = new Figuras.Trapezoide();

        public FormTrapezoide()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBaseMayor.Text, out float bM) &&
                float.TryParse(txtBaseMenor.Text, out float bmen) &&
                float.TryParse(txtAltura.Text, out float h) &&
                float.TryParse(txtLado1.Text, out float l1) &&
                float.TryParse(txtLado2.Text, out float l2) &&
                bM > 0 && bmen > 0 && h > 0 && l1 > 0 && l2 > 0)
            {
                trapezoide.BaseMayor = bM;
                trapezoide.BaseMenor = bmen;
                trapezoide.Altura = h;
                trapezoide.Lado1 = l1;
                trapezoide.Lado2 = l2;
                lblArea.Text = $"Área: {trapezoide.CalcularArea():F2}";
                lblPerimetro.Text = $"Perímetro: {trapezoide.CalcularPerimetro():F2}";
                panelDibujo.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos mayores a 0.");
            }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            trapezoide.Rotar(10);
            panelDibujo.Invalidate();
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            trapezoide.Escalar(1.1f);
            panelDibujo.Invalidate();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            trapezoide.Dibujar(e.Graphics);
        }

        private void FormTrapezoide_KeyDown(object sender, KeyEventArgs e)
        {
            int dx = 0, dy = 0;
            if (e.KeyCode == Keys.Left) dx = -10;
            if (e.KeyCode == Keys.Right) dx = 10;
            if (e.KeyCode == Keys.Up) dy = -10;
            if (e.KeyCode == Keys.Down) dy = 10;

            trapezoide.Trasladar(dx, dy);
            panelDibujo.Invalidate();
        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void FormTrapezoide_Load(object sender, EventArgs e)
        {

        }
    }
}
