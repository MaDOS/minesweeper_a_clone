using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace minesweeper_a_clone_client.manager
{
    public class ThemeManager
    {
        public static Dictionary<string, Theme> themes = new Dictionary<string,Theme>();
        public static string currentTheme;

        public static menus.MainMenu mainMenu;
        public static menus.OptionsMenu optionsMenu;
        public static menus.HighscoreMenu highscoreMenu;

        //public ThemeManager(ref menus.MainMenu mainMenu_param, ref OptionsMenu optionsMenu_param, ref HighscoreMenu highscoreMenu_param)
        //{
        //    this.mainMenu = mainMenu_param;
        //    this.optionsMenu = optionsMenu_param;
        //    this.highscoreMenu = highscoreMenu_param;
        //}

        static void addTheme(string name, Theme theme)
        {
            themes.Add(name, theme);
        }

        public static void loadThemes(string path)
        {
            DirectoryInfo dInfo = new DirectoryInfo(path);

            string themeName = "";
            string themePath = "";

            foreach (FileInfo file in dInfo.GetFiles())
            {
                if (file.Extension == ".xaml")
                {
                    themeName = file.Name;
                    themePath = file.FullName;
                    addTheme(themeName, new Theme(themePath, themeName, LoadStyleDictionaryFromFile(themePath)));
                }
            }
        }

        public static ResourceDictionary LoadStyleDictionaryFromFile(string inFileName)
        {
            if (File.Exists(inFileName))
            {
                try
                {
                    FileStream fs = new FileStream(inFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    return (ResourceDictionary)XamlReader.Load(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                throw new Exception("File existiert nicht!");
            }

            return null;
        }

        public static void applyTheme(string name)
        {
            mainMenu.Resources.MergedDictionaries.Clear();
            mainMenu.Resources.MergedDictionaries.Add(themes[name].xamlRes);
            //optionsMenu.Resources.MergedDictionaries.Clear();
            //optionsMenu.Resources.MergedDictionaries.Add(themes[name].xamlRes);
            //highscoreMenu.Resources.MergedDictionaries.Clear();
            //highscoreMenu.Resources.MergedDictionaries.Add(themes[name].xamlRes);
        }
    }
}
