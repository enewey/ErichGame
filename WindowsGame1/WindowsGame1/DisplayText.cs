using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErichGame
{
    class DisplayText : Entity2D
    {
        public DisplayText(Vector2 pos, string text)
            : base(pos)
        {
            this.setText(text);
        }

        public DisplayText(int x, int y, string text)
            : base(x,y)
        {
            this.setText(text);
        }

        string text;
        public string getText() { return text; }
        public void setText(string text) { this.text = text; }
   
    }
}
