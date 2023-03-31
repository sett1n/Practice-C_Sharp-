using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task_1.Interfaces;
using Task_1.Models;
using Task_1.Share;
using MvvmDialogs;
using Microsoft.Win32;
using System.IO;

namespace Task_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information)).CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }
        private void PrintNote(Note note)
        {
            TextBlockXmlFileContent.Text = "========Note========" + Environment.NewLine;
            TextBlockXmlFileContent.Text += note?.ToString() ?? "Note not found";
        }
        private void PrintContries(List<Note> notes)
        {
            TextBlockXmlFileContent.Text = "========Note========" + Environment.NewLine;
            foreach (var note in notes)
            {
                TextBlockXmlFileContent.Text += note.ToString();
            }
            
        }
        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                TextBlockXmlFilePath.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            PrintContries(_worker.GetAll());
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            var note = _worker.FindBy(textBoxSearch.Text);
            PrintNote(note);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDelete.Text) || string.IsNullOrWhiteSpace(textBoxDelete.Text))
            {
                _worker.Delete(textBoxDelete.Text);
                PrintContries(_worker.GetAll());
            }
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                PrintContries(_worker.GetAll());
            }
        }
    }
}
