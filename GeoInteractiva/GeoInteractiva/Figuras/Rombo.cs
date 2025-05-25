using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeoInteractiva.Figuras
{
    public class Rombo : Figura
    {
        public float DiagonalMayor { get; set; }
        public float DiagonalMenor { get; set; }

        public override double CalcularArea()
            => (DiagonalMayor * DiagonalMenor) / 2.0;

        public override double CalcularPerimetro()
        {
            double a = DiagonalMayor / 2.0;
            double b = DiagonalMenor / 2.0;
            return 4 * Math.Sqrt(a * a + b * b);
        }

        public override void Dibujar(Graphics g)
        {
            PointF[] puntos = new PointF[]
            {
                new PointF(0, -DiagonalMayor / 2),
                new PointF(DiagonalMenor / 2, 0),
                new PointF(0, DiagonalMayor / 2),
                new PointF(-DiagonalMenor / 2, 0)
            };

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(puntos);

                var matrix = new Matrix();
                matrix.Scale(Escala, Escala);
                matrix.Rotate(Rotacion);
                matrix.Translate(Posicion.X, Posicion.Y);
                path.Transform(matrix);

                g.DrawPath(Pens.Blue, path);
            }
        }
    }
}
