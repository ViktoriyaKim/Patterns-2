using System.Drawing;

namespace Patterns.AbstractSuperclass.Shapes
{
    internal class Rectangle : Shape
    {
        private float _length;
        private float _width;

        public Rectangle(Color shapeColor, Graphics graphics, float length, float width) : base(shapeColor, graphics)
        {
            _length = length;
            _width = width;
        }

        public override double Area => _length * _width;

        public override void DrawShape()
        {
            _graphics.Clear(Color.White);

            Pen pen = new Pen(_color, 5);

            _graphics.DrawRectangle(pen, 350, 100, _width, _length);
        }

        public override string ToString()
        {
            return $"Rectangle area is {Area}";
        }
    }
}
