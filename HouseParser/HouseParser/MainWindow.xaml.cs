using System;
using System.Configuration;
using System.Windows;

namespace HouseParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void XmlOpen_Click(object sender, RoutedEventArgs e)
        {
            var openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "XML files (*.xml)|*.xml";

            var result = openFileDlg.ShowDialog();
            if (result == true)
            {
                SetFileNameTextBox(openFileDlg.FileName);
            }
        }

        private void SetFileNameTextBox(string fileName)
        {
            FileNameTextBox.Text = fileName;
        }
    }
}
