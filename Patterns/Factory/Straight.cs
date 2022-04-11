using System.Drawing;

namespace Patterns.Factory
{
    class Straight : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawLine(pen, 250, 250, 500, 250);
        }
    }
}
