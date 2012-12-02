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

namespace minesweeper_a_clone_client.manager
{
    public class contentManager
    {
        public static SpriteFont fntMinesNerby;
        public static Texture2D fieldTexMine;
        public static Texture2D fieldTexUnrevealed;
        public static Texture2D fieldTexNone;
        public static Texture2D fieldTexMarkedAsMine;
        public static Texture2D fieldTexMarkedPossibleMine;
    }
}
