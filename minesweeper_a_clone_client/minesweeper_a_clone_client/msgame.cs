using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading;
using minesweeper_a_clone_client.manager;
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
        int screenHeihgt = 600, screenWidth = 800;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        FpsCounter fps;
        public gameScreens.MainMenu mainMenu;
        public gameScreens.OptionsMenu optionMenu;
        public gameScreens.HighscoreMenu highscoreMenu;

        public ElementHost menuHost = new ElementHost();

        public util.Minefield minefield;

        public msgame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            fps = new FpsCounter(this);
            mainMenu = new gameScreens.MainMenu(this);
            optionMenu = new gameScreens.OptionsMenu(this);
            highscoreMenu = new gameScreens.HighscoreMenu(this);
            Components.Add(mainMenu);
            Components.Add(optionMenu);
            Components.Add(highscoreMenu);
            Components.Add(fps);
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
            manager.gameManager.currentGameState = manager.gameManager.GameState.mainMenu;

            menuHost.Location = new System.Drawing.Point(0, 0);
            menuHost.Name = "mainMenuHost";
            menuHost.Size = new System.Drawing.Size(800, 600);
            menuHost.TabIndex = 1;
            menuHost.Text = "mainMenuHost";
            menuHost.Child = this.mainMenu.menuControl;
            Control.FromHandle(Window.Handle).Controls.Add(menuHost);


            base.Initialize();
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
            contentManager.fntMinesNerby = Content.Load<SpriteFont>(@"default\sprFntMinesNearby");

            contentManager.fieldTexUnrevealed = Content.Load<Texture2D>(@"default\field_unrevealed");
            contentManager.fieldTexNone = Content.Load<Texture2D>(@"default\field_none");
            contentManager.fieldTexMarkedAsMine = Content.Load<Texture2D>(@"default\field_markedAsMine");
            contentManager.fieldTexMarkedPossibleMine = Content.Load<Texture2D>(@"default\field_markedPossibleMine");
            contentManager.fieldTexMine = Content.Load<Texture2D>(@"default\field_mine");
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
            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();

            if (keyboard.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                this.menuHost.Visible = true;
                this.menuHost.Child = this.mainMenu.menuControl;
                manager.gameManager.currentGameState = manager.gameManager.GameState.mainMenu;
            }


            if (manager.gameManager.currentGameState == manager.gameManager.GameState.playing) //in-game update
            {
                
                //playing
                this.minefield.Update(gameTime, mouse);

                
                if (manager.gameManager.currentGameState == manager.gameManager.GameState.lost) //lost
                {
                    this.minefield.revealAllFields();

                }
                else if (manager.gameManager.currentGameState == manager.gameManager.GameState.won) //won
                {
                    MessageBox.Show("Congratulations");
                }
            }
            else
            {
                //menu
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

            if (manager.gameManager.currentGameState == manager.gameManager.GameState.playing ||
                manager.gameManager.currentGameState == manager.gameManager.GameState.won ||
                manager.gameManager.currentGameState == manager.gameManager.GameState.lost) //in-game update
            {
                this.minefield.Draw(gameTime, spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
