using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;

namespace TP2_TDVJ
{
    public class Platform : Objects
    {
        public Platform(Texture2D texture, int height, int width, Vector2 position) : base(texture)
        {
            this._texture = texture;
            this.width = height;
            this.height = width;
            this.position = position;
            this.color = Color.White;
        }

        public void DrawPlatform(SpriteBatch spriteBatch, int x, int y)
        {
            spriteBatch.Draw(_texture, hitbox, Color.White);
        }
    }
}
