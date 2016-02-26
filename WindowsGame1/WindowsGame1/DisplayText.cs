using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErichGame
{
    class DisplayText : Entity2D
    {

        string text;
        public DisplayText(int x, int y, string text)
        {
            this.text = text;
            this.pos = new Vector2();
            this.pos.X = x;
            this.pos.Y = y;
        }

        public DisplayText(Vector2 pos, string text)
        {
            this.text = text;
            this.pos = pos;
        }
    }
}
