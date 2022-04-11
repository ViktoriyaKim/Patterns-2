using Patterns.Iterator;
using System;
using System.Windows.Forms;

namespace Patterns
{
    public partial class IteratorForm : Form
    {
        private ImageCollection _imageCollection;

        private IIterator _iterator;
        public IteratorForm()
        {
            InitializeComponent();

            _imageCollection = new ImageCollection(Environment.CurrentDirectory + "\\Images", pictureBox1);

            _iterator = _imageCollection.GetIterator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Previous();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Next();
            pictureBox1.Image = (System.Drawing.Image)_iterator.Previous();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (System.Drawing.Image)_iterator.Next();
        }
    }
}
