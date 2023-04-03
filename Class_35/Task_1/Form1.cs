using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string digits = "";

            foreach (string item in listBox1.SelectedItems)
            {
                foreach (char c in item)
                {
                    if (char.IsDigit(c))
                    {
                        digits += c;
                    }
                }
            }

            label1.Text = "Цифры: " + digits.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("abc123");
            listBox1.Items.Add("1, 2, 3");
            listBox1.Items.Add("4567");
            listBox1.Items.Add("8-9-10");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
