using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace minesweeper_a_clone_client.manager
{
    class difficultyManager
    {
        public static Dictionary<string, util.Difficulty> unofficialDifficulties = new Dictionary<string, util.Difficulty>();

        public static util.Difficulty officialEasy = new util.Difficulty(util.Difficulty.difficultyType.easy);
        public static util.Difficulty officialMedium = new util.Difficulty(util.Difficulty.difficultyType.medium);
        public static util.Difficulty officialHard = new util.Difficulty(util.Difficulty.difficultyType.hard);

        public static void addUnofficialDifficulty(string name, int sizeX, int sizeY, int mines)
        {
            unofficialDifficulties.Add(name, new util.Difficulty(sizeX, sizeY, mines, name));
        }

        public static void saveDifficulty(string name)
        {
            string file = gameManager.Directory + @"difficulties\" + name + ".ini";

            if (!File.Exists(file))
            {
                File.Create(file);
            }

            StreamWriter sw = new StreamWriter(file);

            util.Difficulty difficulty = unofficialDifficulties[name];

            sw.WriteLine("sizex=" + difficulty.sizeX.ToString());
            sw.WriteLine("sizey=" + difficulty.sizeY.ToString());
            sw.WriteLine("mines=" + difficulty.mines.ToString());

            sw.Close();
        }

        public static void loadDifficulty(string name)
        {
            string file = gameManager.Directory + @"difficulties\" + name + ".ini";

            if(File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);
                string line = "";
                string[] lineSplitted = {"", ""};
                string desc = "";
                string value = "";
                int sizeX = 0, sizeY = 0, mines = 0;

                while (true)
                {
                    line = sr.ReadLine();

                    lineSplitted = line.Split('=');

                    desc = lineSplitted[0];

                    if (desc == "sizex")
                    {
                        sizeX = Convert.ToInt32(value);
                    }
                    else if (desc == "sizey")
                    {
                        sizeY = Convert.ToInt32(value);
                    }
                    else if (desc == "mines")
                    {
                        mines = Convert.ToInt32(value);
                    }

                    sr.Close();

                    if (line == "")
                    {
                        break;
                    }
                }

                addUnofficialDifficulty(name, sizeX, sizeY, mines);
            }
        }
    }
}
