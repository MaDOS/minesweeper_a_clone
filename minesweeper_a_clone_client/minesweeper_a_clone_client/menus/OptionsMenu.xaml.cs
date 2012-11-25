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
    /// Interaktionslogik für optionsMenu.xaml
    /// </summary>
    public partial class OptionsMenu : UserControl
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            guiManager.btnBackPressed = true;
        }

        private void btnRefreshThemes_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.loadThemes(msgame.Directory + @"\themes");
            foreach (string themeName in ThemeManager.themes.Keys)
            {
                cmbBxTheme.Items.Add(themeName);
            }
        }

        private void cmbBxTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            guiManager.newThemeName = this.cmbBxTheme.SelectedItem.ToString();
            guiManager.themeChanged = true;
        }
    }
}
