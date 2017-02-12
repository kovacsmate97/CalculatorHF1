using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double egyikszam = 0;
        double masikszam = 0;

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            masikszam = Convert.ToDouble(textBox1.Text);
        }

        private void elojel(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
                textBox1.Text = textBox1.Text.Substring(1);
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
                textBox1.Text = "-" + textBox1.Text;
        }

        private void C(object sender, EventArgs e)
        {
            textBox1.Clear();
            Calculator.C(egyikszam, masikszam);
        }

        private void CE(object sender, EventArgs e)
        {
            textBox1.Clear();
            Calculator.CE(masikszam);
        }

    }
}
