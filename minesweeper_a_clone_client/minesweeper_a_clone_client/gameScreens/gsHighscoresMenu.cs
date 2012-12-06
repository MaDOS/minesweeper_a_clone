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
    public class HighscoreMenu : Microsoft.Xna.Framework.GameComponent
    {
        public menus.HighscoreMenu menuControl;
        private msgame game;

        public HighscoreMenu(msgame game)
            : base(game)
        {
            // TODO: Construct any child components here
            this.game = game;
            menuControl = new menus.HighscoreMenu();
            manager.ThemeManager.highscoreMenu = menuControl;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            menuControl.btnBack.Click += btnBack_Click;
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
                case manager.gameManager.GameState.highscoresMenu:
                    break;
            }

            base.Update(gameTime);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            manager.gameManager.currentGameState = manager.gameManager.GameState.mainMenu;
            game.menuHost.Child = game.mainMenu.menuControl;
        }

    }
}
