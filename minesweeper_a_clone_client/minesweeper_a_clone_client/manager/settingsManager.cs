using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace minesweeper_a_clone_client.manager
{
    public class SettingsManager
    {
        public static Dictionary<settingType, object> settings = new Dictionary<settingType, object>();

        public enum settingType
        {
            selectedTheme,
            selectedDifficulty,
            onlineHighscores,
            none
        }

        public static void save(string path)
        {
            if (File.Exists(path))
            {
                StreamWriter sw = new StreamWriter(path, false);

                sw.Write("selectedTheme=");
                sw.Write(((string)settings[settingType.selectedTheme]).ToString());
                sw.Write(System.Environment.NewLine);

                sw.Write("selectedDifficulty=");
                sw.Write(((string)settings[settingType.selectedDifficulty]).ToString());
                sw.Write(System.Environment.NewLine);

                sw.Write("onlineHighscores=");
                sw.Write(((bool)settings[settingType.onlineHighscores]).ToString());
                sw.Write(System.Environment.NewLine);
            }
        }

        public static void load(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);

                string[] line = {"", ""};
                string setting = "";
                string value = "";

                while (true)
                {
                    line = sr.ReadLine().Split('=');

                    setting = line[0];
                    value = line[1];

                    if (setting == "selectedTheme")
                    {
                        settings.Add(settingType.selectedTheme, value);
                    }
                    else if (setting == "selectedeDifficulty")
                    {
                        settings.Add(settingType.selectedDifficulty, value);
                    }
                    else if (setting == "onlineHighscores")
                    {
                        settings.Add(settingType.onlineHighscores, Convert.ToBoolean(value));
                    }

                    if (line[0] == "")
                    {
                        break;
                    }
                }

            }
        }
    }
}
