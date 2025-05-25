using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeoInteractiva.Figuras
{
    public class Romboide : Figura
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public float Lado { get; set; }

        public override double CalcularArea()
            => Base * Altura;

        public override double CalcularPerimetro()
            => 2 * (Base + Lado);

        public override void Dibujar(Graphics g)
        {
            float inclinacion = Base / 4;

            PointF[] puntos = new PointF[]
            {
                new PointF(0, 0),
                new PointF(Base, 0),
                new PointF(Base - inclinacion, Altura),
                new PointF(-inclinacion, Altura)
            };

            using (var path = new GraphicsPath())
            {
                path.AddPolygon(puntos);

                var matrix = new Matrix();
                matrix.Scale(Escala, Escala);
                matrix.Rotate(Rotacion);
                matrix.Translate(Posicion.X, Posicion.Y);
                path.Transform(matrix);

                g.DrawPath(Pens.Orange, path);
            }
        }
    }
}
