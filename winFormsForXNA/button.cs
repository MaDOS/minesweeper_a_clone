using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace minesweeper_a_clone_client
{
    public class button
    {
        public Texture2D texture;
        public Vector2 position;
        Rectangle rectangle;

        public Vector2 size;
        //public SpriteFont font; thinking about implementing text property... if it's possible to configure spritefonts from outsourced config
        public bool isClicked;


        public button(Texture2D initTexture, GraphicsDevice graphics)
        {
            this.texture = initTexture;
            this.size = new Vector2(graphics.Viewport.Width / 8, graphics.Viewport.Height / 30);
        }

        public button(Texture2D initTexture, GraphicsDevice graphics, Vector2 position)//Overload 1 to define position directly
        {
            this.texture = initTexture;
            this.size = new Vector2(graphics.Viewport.Width / 8, graphics.Viewport.Height / 30);
            this.position = position;
        }

        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mouseRect.Intersects(rectangle))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;
                }
            }
            else
            {
                isClicked = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
