﻿using System;
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
    /// Interaktionslogik für highscoreMenu.xaml
    /// </summary>
    public partial class HighscoreMenu : UserControl
    {
        public HighscoreMenu()
        {
            InitializeComponent();
        }

        private void btnHighscoresBack_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnBackPressed = true;
        }
    }
}