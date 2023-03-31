using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Task_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            double h = 0.1;
            List<KeyValuePair<double, double>> data = new List<KeyValuePair<double, double>>();

            if (!Double.TryParse(textBox.Text, out x))
            {
                MessageBox.Show("Введите корректное значение X");
                return;
            }

            while (x < Math.PI / 2)
            {
                y = Math.Tan(x);
                data.Add(new KeyValuePair<double, double>(x, y));
                x += h;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("X\tY");
            foreach (KeyValuePair<double, double> pair in data)
            {
                sb.AppendLine(pair.Key.ToString() + "\t" + pair.Value.ToString());
            }
            textBlock.Text = sb.ToString();

            chart.Series.Clear();
            chart.Series.Add(new LineSeries
            {
                ItemsSource = data,
                DependentValuePath = "Value",
                IndependentValuePath = "Key"
            });
        }
    }
}
