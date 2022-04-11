using System;
using System.Windows.Forms;

namespace Patterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegating delegateForm = new Delegating();

            delegateForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbstractSuperclassForm superclassForm = new AbstractSuperclassForm();

            superclassForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FactoryMethodForm factoryMethodForm = new FactoryMethodForm();

            factoryMethodForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IteratorForm iterator = new IteratorForm();

            iterator.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StrategyForm strategy = new StrategyForm();

            strategy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuilderForm builder = new BuilderForm();

            builder.Show();
        }
    }
}
