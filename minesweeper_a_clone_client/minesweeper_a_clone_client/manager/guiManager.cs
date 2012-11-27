using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minesweeper_a_clone_client
{
    class guiManager
    {
        public static bool btnPlayPressed = false;
        public static bool btnHighscoresPressed = false;
        public static bool btnOptionsPressed = false;
        public static bool btnQuitPressed = false;
        public static bool btnBackPressed = false;
        public static bool themeChanged = false;
        public static bool txtNewDifficultyHeightFocused = false;
        public static bool txtNewDifficultyWidthFocused = false;
        public static bool txtNewDifficultyMinesFocused = false;
        public static bool txtNewDifficultyNameFocused = false;

        public static string newThemeName = "";

        public static int otherSizeX = 0;
        public static int otherSizeY = 0;
        public static int otherSizeMines = 0;

        public static dificulty choosenDifficulty = dificulty.none;

        public enum dificulty
        {
            none,
            easy,
            medium,
            hard,
            other
        }
    }
}
