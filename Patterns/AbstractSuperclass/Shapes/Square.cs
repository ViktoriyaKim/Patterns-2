using System.Drawing;

namespace Patterns.AbstractSuperclass.Shapes
{
    class Square : Shape
    {
        private float _length;

        public Square(Color shapeColor, Graphics graphics, float length) : base(shapeColor, graphics)
        {
            _length = length;
        }

        public override double Area => _length * 2;

        public override void DrawShape()
        {
            _graphics.Clear(Color.White);

            Pen pen = new Pen(_color, 5);

            _graphics.DrawRectangle(pen, 300, 100, _length, _length);
        }

        public override string ToString()
        {
            return $"Square area is {Area}";
        }
    }
}
