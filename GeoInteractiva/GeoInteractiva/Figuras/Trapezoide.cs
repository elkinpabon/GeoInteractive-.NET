using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeoInteractiva.Figuras
{
    public class Trapezoide : Figura
    {
        public float BaseMayor { get; set; }
        public float BaseMenor { get; set; }
        public float Altura { get; set; }
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }

        public override double CalcularArea()
            => ((BaseMayor + BaseMenor) * Altura) / 2.0;

        public override double CalcularPerimetro()
            => BaseMayor + BaseMenor + Lado1 + Lado2;

        public override void Dibujar(Graphics g)
        {
            float desplazamiento = (BaseMayor - BaseMenor) / 2;

            PointF[] puntos = new PointF[]
            {
                new PointF(0, 0),
                new PointF(BaseMayor, 0),
                new PointF(BaseMayor - desplazamiento, Altura),
                new PointF(desplazamiento, Altura)
            };

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(puntos);

                var matrix = new Matrix();
                matrix.Scale(Escala, Escala);
                matrix.Rotate(Rotacion);
                matrix.Translate(Posicion.X, Posicion.Y);
                path.Transform(matrix);

                g.DrawPath(Pens.Purple, path);
            }
        }
    }
}
