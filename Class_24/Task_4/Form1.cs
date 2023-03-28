using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void CreateButton(Button b, int x, int y)
        {
            Button temp = new Button();
            temp.Text = "КНОПКА";
            temp.Width = b.Width;
            temp.Location = new Point(x, y);
            temp.MouseMove += delegate { temp.Dispose(); };
            Controls.Add(temp);
        }
        void CreateLabel(int x, int y)
        {
            Label temp = new Label();
            temp.Text = "МЕТКА";
            temp.Location = new Point(x, y);
            temp.MouseMove += delegate { temp.Dispose(); };
            Controls.Add(temp);
        }
        void CreateTextBox(int x, int y)
        {
            TextBox temp = new TextBox();
            temp.Text = "Поле ввода";
            temp.Location = new Point(x, y);
            temp.MouseMove += delegate { temp.Dispose(); };
            Controls.Add(temp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (textBox1.Text)
            {
                case "К": CreateButton(b, int.Parse(textBox2.Text), int.Parse(textBox2.Text)); break;
                case "М": CreateLabel(int.Parse(textBox2.Text), int.Parse(textBox2.Text)); break;
                case "П": CreateTextBox(int.Parse(textBox2.Text), int.Parse(textBox2.Text)); break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
