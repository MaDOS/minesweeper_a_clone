using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minesweeper_a_clone_client.util
{
    public class Difficulty
    {
       public int sizeX, sizeY, mines = 0;
       public difficultyType type;
       public string name = "";

       public enum difficultyType
       {
           none,
           easy,
           medium,
           hard,
           unofficial
       }

        public Difficulty(difficultyType officialDifficulty)
        {
            if (officialDifficulty == difficultyType.easy)
            {
                this.sizeX = 9;
                this.sizeY = 9;
                this.mines = 10;
                this.name = "easy";
                this.type = officialDifficulty;
            }
            else if (officialDifficulty == difficultyType.medium)
            {
                this.sizeX = 16;
                this.sizeY = 16;
                this.mines = 40;
                this.name = "medium";
                this.type = officialDifficulty;
            }
            else if (officialDifficulty == difficultyType.hard)
            {
                this.sizeX = 30;
                this.sizeY = 16;
                this.mines = 99;
                this.name = "hard";
                this.type = officialDifficulty;
            }
            else
            {
                this.type = difficultyType.none;
                throw new Exception("difficulty given is not an official difficulty");
                return;
            }
        }

        public Difficulty(int sizeX, int sizeY, int mines, string name)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.mines = mines;
            this.name = name;
            this.type = difficultyType.unofficial;
        }
    }
}
