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
using System.Windows.Forms;


namespace minesweeper_a_clone_client
{
    public class Field
    {
        Vector2 pos;
        Rectangle rect;
        public int mineFieldCoordsX;
        public int mineFieldCoordsY;
        public bool isMine;
        public Texture2D texture;
        public SpriteFont font;
        public FieldState fsFieldState;
        Field[,] map;

        public enum FieldState
        {
            mine, //after game is lost to maybe have something that the gamelogic displays as bomb/explosion
            unrevealed,//not revealed yet
            none, //revealed and no mines nearby
            minesNearby, //number of mines nerby
            markedAsMine, //flag
            markedPossibleMine //question mark
        }


        public Field(int mineFieldCoordsX, int minefieldCoordsY, Vector2 displayPos, ref Field[,] map)
        {
            this.pos = displayPos;
            this.mineFieldCoordsX = mineFieldCoordsX;
            this.mineFieldCoordsY = minefieldCoordsY;
            this.fsFieldState = FieldState.unrevealed;
            this.map = map;
            this.texture = manager.contentManager.fieldTexUnrevealed;
            this.font = manager.contentManager.fntMinesNerby;
            this.rect = new Rectangle((int)pos.X, (int)pos.Y, 16, 16);
        }

        public void showField(int x, int y)
        {
            int minesNearby = getMinesNerby(x, y);

            if (map[x, y].isMine)//game over
            {
                this.fsFieldState = FieldState.mine;
                this.texture = manager.contentManager.fieldTexMine;
            }
            else if (minesNearby != 0)//<minesNearby> mines nearby
            {
                this.fsFieldState = FieldState.minesNearby;
                this.texture = manager.contentManager.fieldTexNone;
            }
            else //empty field
            {
                this.texture = manager.contentManager.fieldTexNone;
                this.fsFieldState = FieldState.none;

                try
                {
                    showField(x, y - 1);//1
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x + 1, y - 1);//2
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x + 1, y);//3
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x + 1, y + 1);//4
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x, y + 1);//5
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x - 1, y + 1);//6
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x - 1, y);//7
                }
                catch (Exception ex)
                { }
                try
                {
                    showField(x - 1, y - 1);//8
                }
                catch (Exception ex)
                { }
            }
        }

        private int getMinesNerby(int x, int y)
        {
            int countMinesNearby = 0;
            //812
            //7#3
            //654
            //if (x == 0) //rand links ###
            //{
            //    if (map[x + 1, y].isMine)//3
            //    {
            //        countMinesNearby++;
            //    }

            //    if (y == 0) //rand links + oben
            //    {
            //        if (map[x + 1, y + 1].isMine)//4
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x, y + 1].isMine)//5
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //    else if (y == map.GetLength(1)) //rand links + unten
            //    {
            //        if (map[x, y - 1].isMine)//1
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x + 1, y - 1].isMine)//2
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //    else //rand nur links
            //    {
            //        if (map[x, y - 1].isMine)//1
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x + 1, y - 1].isMine)//2
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x + 1, y + 1].isMine)//4
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x, y + 1].isMine)//5
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //}
            //else if (x == map.GetLength(0)) //rand rechts ###
            //{
            //    if (map[x - 1, y].isMine)//7
            //    {
            //        countMinesNearby++;
            //    }

            //    if (y == 0) //rand rechts + oben
            //    {
            //        if (map[x, y + 1].isMine)//5
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x - 1, y + 1].isMine)//6
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //    else if (y == map.GetLength(1)) //rand rechts + unten
            //    {
            //        if (map[x, y - 1].isMine)//1
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x - 1, y - 1].isMine)//8
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //    else //rand nur rechts
            //    {
            //        if (map[x, y - 1].isMine)//1
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x, y + 1].isMine)//5
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x - 1, y + 1].isMine)//6
            //        {
            //            countMinesNearby++;
            //        }
            //        if (map[x - 1, y - 1].isMine)//8
            //        {
            //            countMinesNearby++;
            //        }
            //    }
            //}
            //else //kein rand rechts oder links
            //{
            //    if (map[x, y - 1].isMine)//1
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x + 1, y - 1].isMine)//2
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x + 1, y].isMine)//3
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x + 1, y + 1].isMine)//4
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x, y + 1].isMine)//5
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x - 1, y + 1].isMine)//6
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x - 1, y].isMine)//7
            //    {
            //        countMinesNearby++;
            //    }
            //    if (map[x - 1, y - 1].isMine)//8
            //    {
            //        countMinesNearby++;
            //    }
            //}
            try
            {
                if (map[x, y - 1].isMine)//1
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x + 1, y - 1].isMine)//2
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x + 1, y].isMine)//3
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x + 1, y + 1].isMine)//4
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x, y + 1].isMine)//5
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x - 1, y + 1].isMine)//6
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x - 1, y].isMine)//7
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            try
            {
                if (map[x - 1, y - 1].isMine)//8
                {
                    countMinesNearby++;
                }
            }
            catch (Exception ex)
            { }

            return countMinesNearby;
        }

        public void Update(GameTime gameTime, MouseState mouse)
        {
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (this.rect.Intersects(mouseRect) && mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                //field clicked
                showField(this.mineFieldCoordsX, this.mineFieldCoordsY);
            }
            else if (this.rect.Intersects(mouseRect) && mouse.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
            {
                //field right-clicked: "flag -> question mark -> normal" cycle
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rect, Color.White);
            if (this.fsFieldState == FieldState.minesNearby)
            {
                spriteBatch.DrawString(font, getMinesNerby(this.mineFieldCoordsX, this.mineFieldCoordsY).ToString(), new Vector2(pos.X + 5, pos.Y), Color.Yellow);
            }
        }
    }
}
