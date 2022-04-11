using System;
using System.Drawing;

namespace Patterns.AbstractSuperclass.Shapes
{
    internal class Circle : Shape
    {
        private float _radius;

        public Circle(Color shapeColor, Graphics graphics ,float radius) : base(shapeColor, graphics)
        {
            _radius = radius;
        }

        public override double Area => Math.PI * Math.Pow(_radius, 2);

        public override void DrawShape()
        {
            _graphics.Clear(Color.White);

            Pen pn = new Pen(_color, 5);

            _graphics.DrawEllipse(pn, 300, 100, _radius, _radius);
        }

        public override string ToString()
        {
            return $"Circle area is {Area}";
        }
    }
}
