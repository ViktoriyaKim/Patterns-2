using System;
using System.Drawing;

namespace Patterns.Factory
{
    internal class Angle : IDrawable
    {
        public void Draw(Graphics graphics)
        {
            graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Black, 5);

            graphics.DrawLine(pen, 150, 100, 250, 251);

            graphics.DrawLine(pen, 250, 250, 500, 250);
        }
    }
}
