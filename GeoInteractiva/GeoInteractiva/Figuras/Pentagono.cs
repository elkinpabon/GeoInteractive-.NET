using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeoInteractiva.Figuras
{
    public class Pentagono : Figura
    {
        public float Lado { get; set; }
        public float Apotema { get; set; }

        public override double CalcularArea()
            => (5 * Lado * Apotema) / 2.0;

        public override double CalcularPerimetro()
            => 5 * Lado;

        public override void Dibujar(Graphics g)
        {
            PointF[] puntos = new PointF[5];
            double anguloInicial = -Math.PI / 2;
            double radio = Lado / (2 * Math.Sin(Math.PI / 5));

            for (int i = 0; i < 5; i++)
            {
                double angulo = anguloInicial + i * 2 * Math.PI / 5;
                puntos[i] = new PointF(
                    (float)(radio * Math.Cos(angulo)),
                    (float)(radio * Math.Sin(angulo))
                );
            }

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(puntos);

                var matrix = new Matrix();
                matrix.Scale(Escala, Escala);
                matrix.Rotate(Rotacion);
                matrix.Translate(Posicion.X, Posicion.Y);
                path.Transform(matrix);

                g.DrawPath(Pens.Green, path);
            }
        }
    }
}
