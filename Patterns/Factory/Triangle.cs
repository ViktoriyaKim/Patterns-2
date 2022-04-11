using System.Drawing;

namespace Patterns.Factory
{
    class Triangle : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            PointF[] triangleRect = new PointF[3];

            triangleRect[0] = new PointF(200, 150);

            triangleRect[1] = new PointF(250, 250);

            triangleRect[2] = new PointF(500, 250);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawPolygon(pen, triangleRect);
        }
    }
}
