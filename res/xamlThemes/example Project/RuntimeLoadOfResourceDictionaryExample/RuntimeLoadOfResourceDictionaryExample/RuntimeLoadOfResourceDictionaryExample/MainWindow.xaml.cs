using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;

namespace RuntimeLoadOfResourceDictionaryExample
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

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuItem_Style_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            string stylefile = Path.Combine(App.Directory, "Styles", mi.Name + ".xaml");
            App.Instance.LoadStyleDictionaryFromFile(stylefile);
        }
    }
}
