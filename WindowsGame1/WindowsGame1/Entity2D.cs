﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ErichGame
{
    class Entity2D
    {
        public Entity2D(Vector2 pos)
        {
            this.pos = pos;
        }

        public Entity2D(int x, int y)
        {
            this.pos = new Vector2(x, y);
        }

        protected Vector2 pos;
        public Vector2 getPosition() { return pos; }
        public void setPosition(Vector2 pos) { this.pos = pos; }
        
        public void move(Vector2 move) {
            this.pos.X += move.X;
            this.pos.Y += move.Y;
        }
    }
}
