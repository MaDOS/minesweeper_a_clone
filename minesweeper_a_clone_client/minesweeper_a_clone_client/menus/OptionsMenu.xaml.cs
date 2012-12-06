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
using System.Windows.Forms.Integration;

namespace minesweeper_a_clone_client.menus
{
    public partial class OptionsMenu : UserControl
    {
        public OptionsMenu()
        {
            InitializeComponent();

            //load difficulties
            this.cmbBxDifficulty.Items.Add(manager.difficultyManager.officialEasy.name);
            this.cmbBxDifficulty.Items.Add(manager.difficultyManager.officialMedium.name);
            this.cmbBxDifficulty.Items.Add(manager.difficultyManager.officialHard.name);

            foreach(util.Difficulty difficulty in manager.difficultyManager.unofficialDifficulties.Values)
            {
                this.cmbBxDifficulty.Items.Add(difficulty.name);
            }

            //load installed themes
            manager.ThemeManager.loadThemes(manager.gameManager.Directory + @"\themes");
            foreach (string themeName in manager.ThemeManager.themes.Keys)
            {
                cmbBxTheme.Items.Add(themeName);
            }

            //load settings
            //this.chkBxDownloadHighscores.IsChecked = (bool)manager.SettingsManager.settings[manager.SettingsManager.settingType.onlineHighscores];
            //this.cmbBxDifficulty.SelectedItem = (string)manager.SettingsManager.settings[manager.SettingsManager.settingType.selectedDifficulty];
            //this.cmbBxTheme.SelectedItem = (string)manager.SettingsManager.settings[manager.SettingsManager.settingType.selectedTheme];
        }

        private void cmbBxTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            manager.ThemeManager.applyTheme(this.cmbBxTheme.SelectedItem.ToString());
        }

        private void cmbBxDifficulty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = this.cmbBxDifficulty.SelectedItem.ToString();
            if (name == "easy")
            {
                manager.gameManager.currentDifficulty = manager.difficultyManager.officialEasy;
            }
            else if (name == "medium")
            {
                manager.gameManager.currentDifficulty = manager.difficultyManager.officialMedium;
            }
            else if (name == "hard")
            {
                manager.gameManager.currentDifficulty = manager.difficultyManager.officialHard;
            }
            else
            {
                manager.gameManager.currentDifficulty = manager.difficultyManager.unofficialDifficulties[name];
            }
        }
    }
}
