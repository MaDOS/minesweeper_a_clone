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
using System.Windows.Shapes;

namespace minesweeper_a_clone_client
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnPlayPressed = true;
        }

        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnOptionsPressed = true;
        }

        private void btnHighscores_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnHighscoresPressed = true;
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnQuitPressed = true;
        }
    }
}
