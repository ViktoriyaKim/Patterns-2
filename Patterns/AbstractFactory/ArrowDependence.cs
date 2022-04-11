using System;
using System.Drawing;

namespace Patterns.AbstractFactory
{
    internal class ArrowDependence : AbstractProductArrow
    {
        private double _arrowHeadSize;

        public ArrowDependence(double x, double y, double w, double h)
        {
            _color = Color.Black;


            _arrowHeadSize = 0.09 * Math.Sqrt((_startPositionX - _endPositionX) * (_startPositionX - _endPositionX)
                + (_startPositionX - _endPositionX) * (_startPositionX - _endPositionX));

            //if (_arrowHeadSize < 2) _arrowHeadSize = 0.146 * start.distance(end);

            //if (_arrowHeadSize < 2) _arrowHeadSize = 0.236 * start.distance(end);
        }

        public override void Draw(Graphics graphic)
        {

        }
    }
}
