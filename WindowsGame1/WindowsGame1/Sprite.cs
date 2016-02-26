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
        public Sprite(Vector2 pos, Texture2D image)
            : base(pos)
        {
            this.image = image;
        }

        public Sprite(int x, int y, Texture2D image)
            : base(x,y)
        {
            this.image = image;
        }

        //Fields
        Texture2D image;
        public Texture2D getImage() { return image; }
        public void setImage(Texture2D image) { this.image = image; }
    }
}
