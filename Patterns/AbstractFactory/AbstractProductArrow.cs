using System.Drawing;

namespace Patterns.AbstractFactory
{
    internal abstract class AbstractProductArrow
    {
        protected Color _color;
        protected double _width;
        protected double _startPositionX;
        protected double _startPositionY;
        protected double _endPositionX;
        protected double _endPositionY;

        public abstract void Draw(Graphics graphic);
    }
}
