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
    public class OptionsMenu : Microsoft.Xna.Framework.GameComponent
    {
        public menus.OptionsMenu menuControl;
        private msgame game;
        private bool txtHeightFocus = false;
        private bool txtWidthFocus = false;
        private bool txtMinesFocus = false;
        private bool txtNameFocus = false;

        public OptionsMenu(msgame game)
            : base(game)
        {
            // TODO: Construct any child components here
            this.game = game;
            menuControl = new menus.OptionsMenu();
            manager.ThemeManager.optionsMenu = menuControl;
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            menuControl.btnNewDifficultyCreate.Click += btnNewDifficultyCreate_Click;
            menuControl.txtNewDifficultyHeight.GotFocus += txtNewDifficultyHeight_GotFocus;
            menuControl.txtNewDifficultyHeight.LostFocus += txtNewDifficultyHeight_LostFocus;
            menuControl.txtNewDifficultyWidth.GotFocus += txtNewDifficultyWidth_GotFocus;
            menuControl.txtNewDifficultyWidth.LostFocus += txtNewDifficultyWidth_LostFocus;
            menuControl.txtNewDifficultyMines.GotFocus += txtNewDifficultyMines_GotFocus;
            menuControl.txtNewDifficultyMines.LostFocus += txtNewDifficultyMines_LostFocus;
            menuControl.txtNewDifficultyName.GotFocus += txtNewDifficultyName_GotFocus;
            menuControl.txtNewDifficultyName.LostFocus += txtNewDifficultyName_LostFocus;
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
                case manager.gameManager.GameState.optionsMenu:
                    KeyboardState keyboard = Keyboard.GetState();
                    if (this.txtHeightFocus)
                    {
                        foreach (Keys key in keyboard.GetPressedKeys())
                        {
                            menuControl.txtNewDifficultyHeight.Text += key.ToString();
                        }
                    }
                    else if (this.txtWidthFocus)
                    {
                        foreach (Keys key in keyboard.GetPressedKeys())
                        {
                            menuControl.txtNewDifficultyWidth.Text += key.ToString();
                        }
                    }
                    else if (this.txtMinesFocus)
                    {
                        foreach (Keys key in keyboard.GetPressedKeys())
                        {
                            menuControl.txtNewDifficultyMines.Text += key.ToString();
                        }
                    }
                    else if (this.txtNameFocus)
                    {
                        foreach (Keys key in keyboard.GetPressedKeys())
                        {
                            menuControl.txtNewDifficultyName.Text += key.ToString();
                        }
                    }
                    break;
            }

            base.Update(gameTime);
        }

        private void btnNewDifficultyCreate_Click(object sender, RoutedEventArgs e)
        {
            string name = menuControl.txtNewDifficultyName.Text;
            int sizeX = Convert.ToInt32(menuControl.txtNewDifficultyWidth.Text),
                sizeY = Convert.ToInt32(menuControl.txtNewDifficultyHeight.Text),
                mines = Convert.ToInt32(menuControl.txtNewDifficultyMines.Text);

            manager.difficultyManager.addUnofficialDifficulty(name, sizeX, sizeY, mines);
            manager.difficultyManager.saveDifficulty(name);
            menuControl.cmbBxDifficulty.Items.Add(name);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            manager.gameManager.currentGameState = manager.gameManager.GameState.mainMenu;
            game.menuHost.Child = game.mainMenu.menuControl;
            manager.SettingsManager.save(manager.gameManager.Directory + @"\settings.ini");
        }

        private void txtNewDifficultyHeight_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtHeightFocus = true;
        }
        private void txtNewDifficultyHeight_LostFocus(object sender, RoutedEventArgs e)
        {
            this.txtHeightFocus = false;
        }

        private void txtNewDifficultyWidth_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtWidthFocus = true;
        }
        private void txtNewDifficultyWidth_LostFocus(object sender, RoutedEventArgs e)
        {
            this.txtWidthFocus = false;
        }

        private void txtNewDifficultyMines_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtMinesFocus = true;
        }
        private void txtNewDifficultyMines_LostFocus(object sender, RoutedEventArgs e)
        {
            this.txtMinesFocus = false;
        }

        private void txtNewDifficultyName_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtNameFocus = true;
        }
        private void txtNewDifficultyName_LostFocus(object sender, RoutedEventArgs e)
        {
            this.txtNameFocus = false;
        }

    }
}
