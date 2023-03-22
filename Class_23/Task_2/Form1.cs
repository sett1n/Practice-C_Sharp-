using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        double x; double y; double z; double f; double d;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);

            if (x > y)
            {
               d = Math.Pow((f - y), 3) + Math.Atan(f);
            }
            else if (y > x)
            {
                d = Math.Pow((y - f), 3) + Math.Atan(f);
            }
            else 
            {
                d = Math.Pow((y + f), 3) + 0.5;
            }
            textBox4.Text = d.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            f = Math.Sinh(x);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            f = Math.Pow(x, 2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            f = Math.Exp(x);
        }
    }
}
