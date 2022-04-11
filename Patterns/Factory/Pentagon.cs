using System.Drawing;

namespace Patterns.Factory
{
    class Pentagon : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            PointF[] pentagonleRect = new PointF[5];

            pentagonleRect[0] = new PointF(400, 100);

            pentagonleRect[1] = new PointF(500, 160);

            pentagonleRect[2] = new Point(450, 240);

            pentagonleRect[3] = new PointF(350, 240);

            pentagonleRect[4] = new PointF(300, 160);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawPolygon(pen, pentagonleRect);
        }
    }
}
