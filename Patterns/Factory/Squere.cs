using System.Drawing;

namespace Patterns.Factory
{
    class Squere : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawRectangle(pen, 300, 100, 200, 200);
        }
    }
}
