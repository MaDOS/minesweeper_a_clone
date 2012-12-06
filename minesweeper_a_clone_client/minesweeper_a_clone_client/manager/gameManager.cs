using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;

namespace minesweeper_a_clone_client.manager
{
    public class gameManager
    {
        public static string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static GameState currentGameState = GameState.none;
        public static util.Difficulty currentDifficulty;

        public enum GameState
        {
            none,
            starting,
            playing,
            won,
            lost,
            gameEnd,
            mainMenu,
            optionsMenu,
            highscoresMenu
        }

        public static bool isWon(ref Field[,] map)
        {
            foreach (Field field in map)
            {
                if (!field.isMine && field.fsFieldState == Field.FieldState.unrevealed)
                {
                    return false;
                }
            }

            manager.gameManager.currentGameState = GameState.won;
            return false;
        }
    }
}
