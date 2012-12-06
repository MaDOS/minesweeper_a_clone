using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace minesweeper_a_clone_client.util
{
    public class Minefield
    {
        Random rnd;
        Field[,]map;
        int sizeX, sizeY, mines;
        Vector2 displayPos;

        public Minefield(Difficulty difficulty, Vector2 displayPos)
        {
            this.sizeX = difficulty.sizeX;
            this.sizeY = difficulty.sizeY;
            this.mines = difficulty.mines;
            this.displayPos = displayPos;
            this.map = new Field[sizeX, sizeY];
            rnd = new Random();
            this.generate();
        }

        public void Update(GameTime gameTime, MouseState mouse)
        {
            foreach (Field field in this.map)
            {
                field.Update(gameTime, mouse);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch sb)
        {
            foreach (Field field in this.map)
            {
                field.Draw(gameTime, sb);
            }
        }

        private void generate()
        {
            int x;
            int y;
            for (x = 0; x < sizeX; x++)
            {
                for (y = 0; y < sizeY; y++)
                {
                    this.map[x, y] = new Field(x, y, new Vector2(this.displayPos.X + ((x*16) + 1), this.displayPos.Y + ((y*16) + 1)), ref map);
                }
            }
            for (int i = 0; i < mines; i++)
            {
                while(true)
                {
                    x = rnd.Next(0, this.sizeX);
                    y = rnd.Next(0, this.sizeY);
                    if(!map[x,y].isMine)
                    {
                        this.map[x, y].isMine = true;
                        break;
                    }
                }
            }
            foreach (Field field in map)
            {
                field.calcMinesNerby();
            }
        }

        public void revealAllFields()
        {
            foreach (Field field in map)
            {
                field.revealField();
            }
        }

        public static void countFlags(ref Field[,] map)
        {
            foreach (Field field in map)
            {

            }
        }
    }
}
