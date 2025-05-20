using System.IO;
using System.Windows;

namespace DocumentCreator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateDocument_Click(object sender, RoutedEventArgs e)
        {
            var generator = new DocumentGenerator();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Output.docx");
            generator.Generate(path, GreetingCheck.IsChecked == true, BodyCheck.IsChecked == true, ConclusionCheck.IsChecked == true);
            MessageBox.Show($"Document generated at {path}");
        }
    }
}
