using System.Drawing;

namespace Patterns.Factory
{
    internal class Circle : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawEllipse(pen, 300, 100, 200, 200);
        }
    }
}
