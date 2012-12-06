using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
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
    public partial class testgame : Microsoft.Xna.Framework.Game
    {
        int screenHeihgt = 600, screenWidth = 800;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont fntTestGame;

        FpsCounter fps;

        Texture2D texTestPlayer;
        Vector2 vecTestPlayer;

        public testgame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            fps = new FpsCounter(this);
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
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();

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
            fntTestGame = Content.Load<SpriteFont>(@"testgame\testGameFont");
            texTestPlayer = Content.Load<Texture2D>(@"testgame\testplayer");
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
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                vecTestPlayer = new Vector2(vecTestPlayer.X, vecTestPlayer.Y - 10);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                vecTestPlayer = new Vector2(vecTestPlayer.X, vecTestPlayer.Y + 10);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                vecTestPlayer = new Vector2(vecTestPlayer.X + 10, vecTestPlayer.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                vecTestPlayer = new Vector2(vecTestPlayer.X - 10, vecTestPlayer.Y);
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

            spriteBatch.DrawString(fntTestGame, "time: " + gameTime.TotalGameTime.Seconds + "sec", new Vector2(10, 10), Color.Maroon);
            spriteBatch.Draw(texTestPlayer, vecTestPlayer, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
