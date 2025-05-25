using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeoInteractiva.Figuras
{
    public abstract class Figura
    {
        public Point Posicion { get; set; } = new Point(200, 200);
        public float Escala { get; set; } = 1.0f;
        public float Rotacion { get; set; } = 0f;

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public abstract void Dibujar(Graphics g);

        public void Rotar(float angulo) => Rotacion += angulo;
        public void Escalar(float factor) => Escala *= factor;
        public void Trasladar(int dx, int dy) => Posicion = new Point(Posicion.X + dx, Posicion.Y + dy);
    }
}
