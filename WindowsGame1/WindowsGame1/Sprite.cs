using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ErichGame
{
    class Sprite : Entity2D
    {
        Texture2D image;

        public Sprite(Vector2 pos, Texture2D image)
        {
            this.pos = pos;
            this.image = image;
        }

    }
}
