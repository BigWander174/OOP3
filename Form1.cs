using System;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        private Sorter _sorter;
        public Form1()
        {
            InitializeComponent();
            _sorter = new Sorter();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void UpdateValues()
        {
            _sorter.SetValues(textBoxA.Text, textBoxB.Text, textBoxC.Text);
            result.Text = _sorter.GetValues();
        }
    }
}
