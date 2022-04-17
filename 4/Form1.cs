using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox2.Text);
            double xk = Convert.ToDouble(textBox3.Text);
            double dx = Convert.ToDouble(textBox4.Text);
            double d = Convert.ToDouble(textBox5.Text);
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y =(x*x*x*x)+Math.Cos(2+(x*x*x)-d);
                textBox1.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;

                x = x + dx;
            }
        }
    }
}
