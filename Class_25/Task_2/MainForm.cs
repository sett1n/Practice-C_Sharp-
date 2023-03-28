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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "End";
            toolStripProgressBar1.Value = 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                toolStripLabel1.Text = $"In Progres: {i}%";
                toolStripProgressBar1.Value = i;
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
            toolStripLabel1.Text = "End";
            toolStripProgressBar1.Value = 0;
        }
    }
}
