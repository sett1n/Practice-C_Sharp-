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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddCustomToolStrip();
        }
        private void AddCustomToolStrip()
        {
            var customToolStrip = new CustomToolStrip();
            Controls.Add(customToolStrip);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
    public class CustomToolStrip : ToolStrip
    {
        private readonly Button _button;

        public CustomToolStrip()
        {
            _button = new Button();
            _button.Text = "КНОПКА";
            _button.Click += Button_Click;
            Items.Add(new ToolStripControlHost(_button));
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Да!");
        }
    }
}
