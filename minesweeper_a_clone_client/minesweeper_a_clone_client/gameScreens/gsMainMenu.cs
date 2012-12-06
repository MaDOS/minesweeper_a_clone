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
using System.Windows;


namespace minesweeper_a_clone_client.gameScreens
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class MainMenu : Microsoft.Xna.Framework.GameComponent
    {
        public menus.MainMenu menuControl;
        private msgame game;

        public MainMenu(msgame game)
            : base(game)
        {
            // TODO: Construct any child components here
            this.game = game;
            menuControl = new menus.MainMenu();
            manager.ThemeManager.mainMenu = menuControl;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            menuControl.btnPlay.Click += btnPlay_Click;
            menuControl.btnOptions.Click += btnOptions_Click;
            menuControl.btnHighscores.Click += btnHighscores_Click;
            menuControl.btnQuit.Click += btnQuit_Click;
            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here
            switch (manager.gameManager.currentGameState)
            {
                case manager.gameManager.GameState.mainMenu:
                    break;
            }

            base.Update(gameTime);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            manager.gameManager.currentGameState = manager.gameManager.GameState.starting; //starting

            game.minefield = new util.Minefield(manager.gameManager.currentDifficulty, new Vector2(80.0f, 80.0f));
            game.menuHost.Visible = false;

            manager.gameManager.currentGameState = manager.gameManager.GameState.playing; //playing
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            manager.gameManager.currentGameState = manager.gameManager.GameState.optionsMenu; //optionScreen
            game.menuHost.Child = game.optionMenu.menuControl;
        }

        private void btnHighscores_Click(object sender, EventArgs e)
        {
            manager.gameManager.currentGameState = manager.gameManager.GameState.highscoresMenu; //highscoreScreen
            game.menuHost.Child = game.highscoreMenu.menuControl;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            game.Exit();
        }

    }
}
