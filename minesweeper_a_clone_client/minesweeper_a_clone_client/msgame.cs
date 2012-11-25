using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms.Integration;
using System.Windows.Forms;

namespace minesweeper_a_clone_client
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public partial class msgame : Microsoft.Xna.Framework.Game
    {
        public static string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        int screenHeihgt = 600, screenWidth = 800;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        GameState gsCurrentGamestate;

        MainMenu mainMenu;
        OptionsMenu optionsMenu;
        HighscoreMenu highscoreMenu; 
        ElementHost menuHost = new ElementHost();

        SpriteFont fntMainMenuTitle;

        ThemeManager themeManager;

        enum GameState
        {
            mainMenu,
            options,
            highscores,
            playing
        }

        public msgame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //graphicDevice-Tweaking
            graphics.PreferredBackBufferHeight = screenHeihgt;
            graphics.PreferredBackBufferWidth = screenWidth;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();

            //draw main-menu after starting
            gsCurrentGamestate = GameState.mainMenu;

            mainMenu = new MainMenu();
            optionsMenu = new OptionsMenu();
            highscoreMenu = new HighscoreMenu();

            menuHost.Location = new System.Drawing.Point(0, 0);
            menuHost.Name = "mainMenuHost";
            menuHost.Size = new System.Drawing.Size(800, 600);
            menuHost.TabIndex = 1;
            menuHost.Text = "mainMenuHost";
            menuHost.Child = this.mainMenu;
            Control.FromHandle(Window.Handle).Controls.Add(menuHost);

            themeManager = new ThemeManager(ref this.mainMenu, ref this.optionsMenu, ref this.highscoreMenu);

            base.Initialize();;
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            fntMainMenuTitle = Content.Load<SpriteFont>(@"sprFntMainMenuTitle");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            if (gsCurrentGamestate == GameState.playing) //in-game update
            {
                //playing
            }
            else
            {
                //menu
                switch (gsCurrentGamestate)
                {
                    case GameState.mainMenu: 
                    //##################################################################main menu update
                        if (guiManager.btnPlayPressed) //mainMenu - btnPlay
                        {
                            runtestgame();

                            guiManager.btnPlayPressed = false;
                        }
                        else if (guiManager.btnOptionsPressed) //mainMenu - btnOptions
                        {
                            this.gsCurrentGamestate = GameState.options;
                            this.menuHost.Child = this.optionsMenu;

                            guiManager.btnOptionsPressed = false;
                        }
                        else if (guiManager.btnHighscoresPressed) //mainMenu - btnHighsocores
                        {
                            this.gsCurrentGamestate = GameState.highscores;
                            this.menuHost.Child = this.highscoreMenu;

                            guiManager.btnHighscoresPressed = false;
                        }
                        else if (guiManager.btnQuitPressed) //mainMenu - btnQuit
                        {
                            this.Exit();
                        }
                        break;
                    case GameState.options:
                    //##################################################################option menu update
                        if (guiManager.btnBackPressed)
                        {
                            this.gsCurrentGamestate = GameState.mainMenu;
                            this.menuHost.Child = this.mainMenu;
                            guiManager.btnBackPressed = false;
                        }

                        if (guiManager.themeChanged)
                        {
                            themeManager.applyTheme(guiManager.newThemeName);
                            guiManager.themeChanged = false;
                        }
                        break;
                    case GameState.highscores:
                        if (guiManager.btnBackPressed)
                        {
                            this.gsCurrentGamestate = GameState.mainMenu;
                            this.menuHost.Child = this.mainMenu;
                            guiManager.btnBackPressed = false;
                        }
                    //##################################################################highscore menu upate
                        break;
                }
            }
            
            base.Update(gameTime);
        }

        void runtestgame()
        {
            new Thread(new ThreadStart(delegate() { using (testgame game = new testgame()) { game.Run(); } })).Start();
        }
        
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
           
            spriteBatch.DrawString(fntMainMenuTitle, "minesweeper a clone", new Vector2(10, 10), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
