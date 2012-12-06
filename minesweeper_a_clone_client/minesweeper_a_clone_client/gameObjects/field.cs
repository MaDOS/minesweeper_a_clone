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
        int minesNearby;
        bool rightMouseButtonWasReleased; //preventing from toggling right clicks to fast

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
            revealed, //revealed and no mines nearby
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

        public void revealField()
        {
            if (this.fsFieldState != FieldState.unrevealed)
            {
                return;
            }
            else if (this.isMine)
            {
                this.fsFieldState = FieldState.mine;
            }

            int x = this.mineFieldCoordsX;
            int y = this.mineFieldCoordsY;

            if (this.isMine)
            {
                if (this.fsFieldState != FieldState.markedAsMine) //don't reveal marked mines as mines if the game ends
                {
                    this.texture = manager.contentManager.fieldTexMine;
                }

                if (manager.gameManager.currentGameState != manager.gameManager.GameState.won) //if not already won and a mine is revealed -> game over
                {
                    manager.gameManager.currentGameState = manager.gameManager.GameState.lost; //game over
                }
            }
            else if (this.minesNearby != 0)//<this.minesNearby> mines nearby
            {
                this.fsFieldState = FieldState.minesNearby;
                this.texture = manager.contentManager.fieldTexNone;
            }
            else //empty field
            {
                this.texture = manager.contentManager.fieldTexNone;
                this.fsFieldState = FieldState.revealed;

                //812
                //7#3
                //654

                if (x == 0) //rand links ###
                {
                    map[x + 1, y].revealField();//3

                    if (y == 0) //rand links + oben
                    {
                        map[x + 1, y + 1].revealField();//4
                        map[x, y + 1].revealField();//5
                    }
                    else if (y == (map.GetLength(1) - 1)) //rand links + unten
                    {
                        map[x, y - 1].revealField();//1
                        map[x + 1, y - 1].revealField();//2
                    }
                    else //rand nur links
                    {
                        map[x, y - 1].revealField();//1
                        map[x + 1, y - 1].revealField();//2
                        map[x + 1, y + 1].revealField();//4
                        map[x, y + 1].revealField();//5
                    }
                }
                else if (x == (map.GetLength(0) - 1)) //rand rechts ###
                {
                    map[x - 1, y].revealField();//7

                    if (y == 0) //rand rechts + oben
                    {
                        map[x, y + 1].revealField();//5
                        map[x - 1, y + 1].revealField();//6
                    }
                    else if (y == (map.GetLength(1) - 1)) //rand rechts + unten
                    {
                        map[x, y - 1].revealField();//1
                        map[x - 1, y - 1].revealField();//8
                    }
                    else //rand nur rechts
                    {
                        map[x, y - 1].revealField();//1
                        map[x, y + 1].revealField();//5
                        map[x - 1, y + 1].revealField();//6
                        map[x - 1, y - 1].revealField();//8
                    }

                }
                else if (y == 0) //rand oben
                {
                    map[x, y + 1].revealField();//5

                    if (x == 0) //rand oben + links
                    {
                        map[x + 1, y].revealField();//3
                        map[x + 1, y + 1].revealField();//4
                    }
                    else if (x == (map.GetLength(0) - 1)) //rand oben + rechts
                    {
                        map[x - 1, y + 1].revealField();//6
                        map[x - 1, y].revealField();//7
                    }
                    else //rand nur oben
                    {
                        map[x + 1, y].revealField();//3
                        map[x + 1, y + 1].revealField();//4
                        map[x - 1, y + 1].revealField();//6
                        map[x - 1, y].revealField();//7
                    }
                }
                else if (y == (map.GetLength(1) - 1)) //rand unten
                {
                    map[x, y - 1].revealField();//1

                    if (x == 0) //rand unten + links
                    {
                        map[x + 1, y - 1].revealField();//2
                        map[x + 1, y].revealField();//3
                    }
                    else if (x == (map.GetLength(0) - 1)) //rand unten + rechts
                    {
                        map[x - 1, y].revealField();//7
                        map[x - 1, y - 1].revealField();//8
                    }
                    else //rand nur unten
                    {
                        map[x + 1, y - 1].revealField();//2
                        map[x + 1, y].revealField();//3
                        map[x - 1, y].revealField();//7
                        map[x - 1, y - 1].revealField();//8
                    }
                }
                else //kein rand
                {
                    map[x, y - 1].revealField();//1
                    map[x + 1, y - 1].revealField();//2
                    map[x + 1, y].revealField();//3
                    map[x + 1, y + 1].revealField();//4
                    map[x, y + 1].revealField();//5
                    map[x - 1, y + 1].revealField();//6
                    map[x - 1, y].revealField();//7
                    map[x - 1, y - 1].revealField();//8
                }
            }

            manager.gameManager.isWon(ref map);
        }

        public void calcMinesNerby()
        {
            int countminesNearby = 0;
            int x = this.mineFieldCoordsX;
            int y = this.mineFieldCoordsY;
            //812
            //7#3
            //654
            if (x == 0) //rand links ###
            {
                if (map[x + 1, y].isMine)//3
                {
                    countminesNearby++;
                }

                if (y == 0) //rand links + oben
                {
                    if (map[x + 1, y + 1].isMine)//4
                    {
                        countminesNearby++;
                    }
                    if (map[x, y + 1].isMine)//5
                    {
                        countminesNearby++;
                    }
                }
                else if (y == (map.GetLength(1) - 1)) //rand links + unten
                {
                    if (map[x, y - 1].isMine)//1
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y - 1].isMine)//2
                    {
                        countminesNearby++;
                    }
                }
                else //rand nur links
                {
                    if (map[x, y - 1].isMine)//1
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y - 1].isMine)//2
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y + 1].isMine)//4
                    {
                        countminesNearby++;
                    }
                    if (map[x, y + 1].isMine)//5
                    {
                        countminesNearby++;
                    }
                }
            }
            else if (x == (map.GetLength(0) - 1)) //rand rechts ###
            {
                if (map[x - 1, y].isMine)//7
                {
                    countminesNearby++;
                }

                if (y == 0) //rand rechts + oben
                {
                    if (map[x, y + 1].isMine)//5
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y + 1].isMine)//6
                    {
                        countminesNearby++;
                    }
                }
                else if (y == (map.GetLength(1) - 1)) //rand rechts + unten
                {
                    if (map[x, y - 1].isMine)//1
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y - 1].isMine)//8
                    {
                        countminesNearby++;
                    }
                }
                else //rand nur rechts
                {
                    if (map[x, y - 1].isMine)//1
                    {
                        countminesNearby++;
                    }
                    if (map[x, y + 1].isMine)//5
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y + 1].isMine)//6
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y - 1].isMine)//8
                    {
                        countminesNearby++;
                    }
                }
                
            }
            else if (y == 0) //rand oben
            {
                if (map[x, y + 1].isMine)//5
                {
                    countminesNearby++;
                }

                if (x == 0) //rand oben + links
                {
                    if (map[x + 1, y].isMine)//3
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y + 1].isMine)//4
                    {
                        countminesNearby++;
                    }
                }
                else if (x == (map.GetLength(0) - 1)) //rand oben + rechts
                {
                    if (map[x - 1, y + 1].isMine)//6
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y].isMine)//7
                    {
                        countminesNearby++;
                    }
                }
                else //rand nur oben
                {
                    if (map[x + 1, y].isMine)//3
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y + 1].isMine)//4
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y + 1].isMine)//6
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y].isMine)//7
                    {
                        countminesNearby++;
                    }
                }
            }
            else if (y == (map.GetLength(1) - 1)) //rand unten
            {
                if (map[x, y - 1].isMine)//1
                {
                    countminesNearby++;
                }

                if (x == 0) //rand unten + links
                {
                    if (map[x + 1, y - 1].isMine)//2
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y].isMine)//3
                    {
                        countminesNearby++;
                    }
                }
                else if (x == (map.GetLength(0) - 1)) //rand unten + rechts
                {
                    if (map[x - 1, y].isMine)//7
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y - 1].isMine)//8
                    {
                        countminesNearby++;
                    }
                }
                else //rand nur unten
                {
                    if (map[x + 1, y - 1].isMine)//2
                    {
                        countminesNearby++;
                    }
                    if (map[x + 1, y].isMine)//3
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y].isMine)//7
                    {
                        countminesNearby++;
                    }
                    if (map[x - 1, y - 1].isMine)//8
                    {
                        countminesNearby++;
                    }
                }
            }
            else //kein rand
            {
                if (map[x, y - 1].isMine)//1
                {
                    countminesNearby++;
                }
                if (map[x + 1, y - 1].isMine)//2
                {
                    countminesNearby++;
                }
                if (map[x + 1, y].isMine)//3
                {
                    countminesNearby++;
                }
                if (map[x + 1, y + 1].isMine)//4
                {
                    countminesNearby++;
                }
                if (map[x, y + 1].isMine)//5
                {
                    countminesNearby++;
                }
                if (map[x - 1, y + 1].isMine)//6
                {
                    countminesNearby++;
                }
                if (map[x - 1, y].isMine)//7
                {
                    countminesNearby++;
                }
                if (map[x - 1, y - 1].isMine)//8
                {
                    countminesNearby++;
                }
            }

            this.minesNearby = countminesNearby;
        }

        public void Update(GameTime gameTime, MouseState mouse)
        {
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (this.rect.Intersects(mouseRect))
            {
                if (mouse.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released && !this.rightMouseButtonWasReleased)
                {
                    //mouse button was released since last time he was pressed
                    this.rightMouseButtonWasReleased = true; //prevention from toggling to fast
                }

                if (mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    //field left-clicked
                    if (this.fsFieldState == FieldState.unrevealed || this.fsFieldState == FieldState.markedPossibleMine)
                    {
                        this.revealField();
                    }
                }
                else if (mouse.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed) //field right-clicked: "flag -> question mark -> normal" cycle
                {
                    if (this.rightMouseButtonWasReleased) //prevention from toggling to fast
                    {
                        if (this.fsFieldState == FieldState.unrevealed)
                        {
                            this.fsFieldState = FieldState.markedAsMine;
                            this.texture = manager.contentManager.fieldTexMarkedAsMine;
                        }
                        else if (this.fsFieldState == FieldState.markedAsMine) //marked with flag
                        {
                            this.fsFieldState = FieldState.markedPossibleMine;
                            this.texture = manager.contentManager.fieldTexMarkedPossibleMine;
                        }
                        else if (this.fsFieldState == FieldState.markedPossibleMine) //marked with ?
                        {
                            this.fsFieldState = FieldState.unrevealed;
                            this.texture = manager.contentManager.fieldTexUnrevealed;
                        }
                        this.rightMouseButtonWasReleased = false; //preventing from toggling right clicks to fast
                    }
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, rect, Color.White);
            if (this.fsFieldState == FieldState.minesNearby)
            {
                spriteBatch.DrawString(this.font, this.minesNearby.ToString(), new Vector2(this.pos.X + 5, this.pos.Y), Color.Yellow);
            }
        }

    }
}
