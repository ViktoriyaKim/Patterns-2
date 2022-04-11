using System.Drawing;

namespace Patterns.AbstractSuperclass
{
    internal abstract class Shape
    {
        protected Color _color;

        protected Graphics _graphics;

        public abstract double Area { get; }

        public abstract string ToString();

        public abstract void DrawShape();

        public Shape(Color shapeColor, Graphics graphics)
        {
            SetColor(shapeColor);

            _graphics = graphics;
        }

        public void SetColor(Color shapeColor)
        {
            _color = shapeColor;
        }
    }
}
