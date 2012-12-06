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

public class FpsCounter : Microsoft.Xna.Framework.DrawableGameComponent
{
    private float elapsed;
    private float frameRate;
    private float frames;
    private SpriteBatch spriteBatch;
    private SpriteFont font; 

    public FpsCounter(Game game) : base(game)
    {
        elapsed = 0.0f;
        frameRate = 0.0f;
        frames = 0.0f;
    }

    public override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        font = Game.Content.Load<SpriteFont>(@"default\sprFntMainMenuTitle");
    } 

    protected override void UnloadContent()
    {
    }

    public override void Update(GameTime gameTime)
    {
    }

    public override void Draw(GameTime gameTime)
    {
        elapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (elapsed > 1.0f)
        {
            elapsed -= 1.0f;
            frameRate = frames;
            frames = 0;
        }
        else
        {
            frames += 1;
        }

        spriteBatch.Begin();
        spriteBatch.DrawString(font, "fps: " + frameRate.ToString("0.00"), new Vector2(500, 10), Color.DarkGreen);
        spriteBatch.End();
    }
} 
