using System;
using System.Drawing;
using System.Windows.Forms;

using Patterns.AbstractSuperclass.Shapes;

namespace Patterns
{
    public partial class AbstractSuperclassForm : Form
    {
        private Graphics _formGraphics;
        public AbstractSuperclassForm()
        {
            InitializeComponent();
        }

        private void AbstractSuperclass_Load(object sender, EventArgs e)
        {
            _formGraphics = CreateGraphics();
        }

        private void _circleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Color.Black, _formGraphics, 200);
            circle.DrawShape();
        }

        private void _rectangleButton_Click(object sender, EventArgs e)
        {
            AbstractSuperclass.Shapes.Rectangle rectangle =
                new AbstractSuperclass.Shapes.Rectangle(Color.Black, _formGraphics, 200, 100);
            rectangle.DrawShape();
        }

        private void _ellipseButton_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse(Color.Black, _formGraphics, 100, 200);
            ellipse.DrawShape();
        }

        private void _squareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square(Color.Black, _formGraphics, 200);
            square.DrawShape();
        }

    }
}
