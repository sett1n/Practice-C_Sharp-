using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        double x0; double xk; double dx; double a; double y; double b = -6.25;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x0 = double.Parse(textBox1.Text);
            xk = double.Parse(textBox2.Text);
            dx = double.Parse(textBox3.Text);
            a = double.Parse(textBox4.Text);
            while (x0 <= xk) 
            {
                y = a * Math.Pow(x0, 3) + Math.Pow(Math.Cos(Math.Pow(x0, 3) - b), 2);
                listBox1.Items.Add($"y({x0}) = {y}");
                x0 += dx;
            }
        }
    }
}
