using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using minesweeper_a_clone_client;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

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

        GameState gsCurrentGamestate;

        button btnPlay;
        button btnOptions;
        button btnHighscore;
        button btnQuit;

        SpriteFont fntMainMenuTitle;

        Texture2D btnDefaultTexture;
        Texture2D texSpace;

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

            //init buttons
            //loading default button texture
            btnDefaultTexture = Content.Load<Texture2D>(@"buttons\button_default");
            btnPlay = new button(btnDefaultTexture, graphics.GraphicsDevice);
            btnOptions = new button(btnDefaultTexture, graphics.GraphicsDevice);
            btnHighscore = new button(btnDefaultTexture, graphics.GraphicsDevice);
            btnQuit = new button(btnDefaultTexture, graphics.GraphicsDevice);

            //Vector2 btnBasePos = new Vector2(((graphics.GraphicsDevice.Viewport.Height / 2) - 200), ((graphics.GraphicsDevice.Viewport.Width / 2) + 100));

            btnPlay.position = new Vector2(((graphics.GraphicsDevice.Viewport.Width / 2) - 50), ((graphics.GraphicsDevice.Viewport.Height / 2) - 150));
            btnOptions.position = new Vector2(((graphics.GraphicsDevice.Viewport.Width / 2) - 50), ((graphics.GraphicsDevice.Viewport.Height / 2) - 100));
            btnHighscore.position = new Vector2(((graphics.GraphicsDevice.Viewport.Width / 2) - 50), ((graphics.GraphicsDevice.Viewport.Height / 2) - 50));
            btnQuit.position = new Vector2(((graphics.GraphicsDevice.Viewport.Width / 2) - 50), ((graphics.GraphicsDevice.Viewport.Height / 2) - 0));



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
            btnPlay.texture = Content.Load<Texture2D>(@"buttons\button_play");
            btnOptions.texture = Content.Load<Texture2D>(@"buttons\button_options");
            btnHighscore.texture = Content.Load<Texture2D>(@"buttons\button_highscore");
            btnQuit.texture = Content.Load<Texture2D>(@"buttons\button_quit");
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            MouseState mouse = Mouse.GetState();
            switch(gsCurrentGamestate)
            {
                case GameState.mainMenu:
                    //Update Play-Button
                    btnPlay.Update(mouse);
                    if (btnPlay.isClicked == true)
                    {
                        gsCurrentGamestate = GameState.playing;
                    }
                    //Update Option-Button
                    btnOptions.Update(mouse);
                    if(btnOptions.isClicked == true)
                    {
                        gsCurrentGamestate = GameState.options;
                    }
                    //Update Highscore-Button
                    btnHighscore.Update(mouse);
                    if (btnHighscore.isClicked == true)
                    {
                        gsCurrentGamestate = GameState.highscores;
                    }
                    //update Quit-Button
                    btnQuit.Update(mouse);
                    if (btnQuit.isClicked)
                    {
                        this.Exit();
                    }
                    break;
                case GameState.options:
                    break;
                case GameState.highscores:
                    break;
                case GameState.playing:
                    break;
            }

            base.Update(gameTime);
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
            switch (gsCurrentGamestate)
            {
                case GameState.mainMenu:
                    btnPlay.Draw(spriteBatch);
                    btnOptions.Draw(spriteBatch);
                    btnHighscore.Draw(spriteBatch);
                    btnQuit.Draw(spriteBatch);
                    break;
                case GameState.options:
                    break;
                case GameState.highscores:
                    break;
                case GameState.playing:
                    break;
            }

            spriteBatch.DrawString(fntMainMenuTitle, "minesweeper a clone", new Vector2(10, 10), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
