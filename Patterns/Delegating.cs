using System;
using System.Windows.Forms;

using Patterns.Delegate;

namespace Patterns
{
    public partial class Delegating : Form
    {
        private Procent _procent;

        public Delegating()
        {
            InitializeComponent();
        }

        private void Delegating_Load(object sender, EventArgs e)
        {
            _procent = new Procent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult(15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowResult(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowResult(3);
        }

        private void ShowResult(int procent)
        {
            textBox1.Text = _procent.CountSumTruncuated(GetNumbers(), procent).ToString();
        }

        private double GetNumbers()
        {
            double.TryParse(textBox1.Text, out double result);

            return result;
        }
    }
}
