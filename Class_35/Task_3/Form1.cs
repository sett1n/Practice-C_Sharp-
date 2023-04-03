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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Green); 

          
            int x = this.ClientSize.Width / 2;
            int y = 50;

            Point[] points = new Point[] 
            {
                 new Point(x, y),
                new Point(x - 50, y + 100),
                 new Point(x + 50, y + 100)
            };
            g.FillPolygon(brush, points); 

            Pen pen = new Pen(Color.Brown, 2);
            g.FillRectangle(pen.Brush, x - 10, y + 100, 20, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
