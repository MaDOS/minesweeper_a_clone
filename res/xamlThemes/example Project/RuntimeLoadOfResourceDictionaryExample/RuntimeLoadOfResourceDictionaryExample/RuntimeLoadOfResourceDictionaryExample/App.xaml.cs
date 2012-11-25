using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace RuntimeLoadOfResourceDictionaryExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static App Instance;
        public static String Directory;
        private String _DefaultStyle = "BlueStyle.xaml";

        public App()
        {
            Instance = this;
            Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string stringsFile = Path.Combine(Directory, "Styles", _DefaultStyle);
            LoadStyleDictionaryFromFile(stringsFile);
        }

        /// <summary>
        /// Dynamically load a style from a file
        /// </summary>
        public void LoadStyleDictionaryFromFile(string inFileName)
        {
            if (File.Exists(inFileName))
            {
                try
                {
                    using (var fs = new FileStream(inFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        // Read in ResourceDictionary File
                        var dic = (ResourceDictionary)XamlReader.Load(fs);
                        // Clear any previous dictionaries loaded
                        Resources.MergedDictionaries.Clear();
                        // Add in newly loaded Resource Dictionary
                        Resources.MergedDictionaries.Add(dic);
                    }
                }
                catch
                {
                }
            }
        }
    }
}
