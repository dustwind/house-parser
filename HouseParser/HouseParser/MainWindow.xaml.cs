using HouseParser.Models;
using HouseParser.Storage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace HouseParser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set
            {
                if (value != filePath)
                {
                    filePath = value;
                    OnPropertyChanged("FilePath");
                }
            }
        }

        public List<ApartmentStorageEnum> ApartmentStorageInfoList { get; set; }

        private ApartmentStorageEnum currentApartmentStorageInfo;

        public ApartmentStorageEnum CurrentApartmentStorageInfo
        {
            get { return currentApartmentStorageInfo; }
            set
            {
                if (value != currentApartmentStorageInfo)
                {
                    currentApartmentStorageInfo = value;
                    OnPropertyChanged("CurrentApartmentStorageInfo");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            SetApartmentStorageProperties();

            InitializeComponent();

            DataContext = this;
        }

        private void SetApartmentStorageProperties()
        {
            //ApartmentStorageInfoList = new ObservableCollection<ApartmentStorageEnum>();
            ApartmentStorageInfoList = Enum.GetValues(typeof(ApartmentStorageEnum)).Cast<ApartmentStorageEnum>().ToList();

            CurrentApartmentStorageInfo = ApartmentStorageInfoList[0];
        }

        private void Xml_Open_Click(object sender, RoutedEventArgs e)
        {
            var openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "XML files (*.xml)|*.xml";

            var result = openFileDlg.ShowDialog();
            if (result == true)
            {
                SetFileNameTextBox(openFileDlg.FileName);
            }
        }

        private void Xml_Load_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DBSelector_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Change storage
        }

        private void SetFileNameTextBox(string fileName)
        {
            FilePath = fileName;
        }
    }
}
