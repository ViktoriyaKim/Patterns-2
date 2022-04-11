using System;
using System.Drawing;
using System.Windows.Forms;

using Patterns.Factory;

namespace Patterns
{
    public partial class FactoryMethodForm : Form
    {
        private ShapeFactory _shapeFactory;
        private Graphics _formGraphycs;

        public FactoryMethodForm()
        {
            InitializeComponent();
        }

        private void FactoryMethodForm_Load(object sender, EventArgs e)
        {
            _shapeFactory = new ShapeFactory();
            _formGraphycs = CreateGraphics();
        }

        private void _createShapeButton_Click(object sender, EventArgs e)
        {
            IDrawable drawable = _shapeFactory.CreateShape(_shapeCouner.SelectedIndex);

            drawable.Draw(_formGraphycs);
        }
    }
}
