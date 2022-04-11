using System;
using System.Drawing;

namespace Patterns.AbstractSuperclass.Shapes
{
    class Ellipse : Shape
    {
        private float _length;
        private float _width;

        public Ellipse(Color shapeColor, Graphics graphics, float length, float width) : base(shapeColor, graphics)
        {
            _length = length;
            _width = width;
        }

        public override double Area => Math.PI * _length * _width / 4;

        public override void DrawShape()
        {
            _graphics.Clear(Color.White);

            Pen pn = new Pen(_color, 5);

            _graphics.DrawEllipse(pn, 350, 100, _length, _width);
        }

        public override string ToString()
        {
            return $"Ellipse area is {Area}";
        }
    }
}
