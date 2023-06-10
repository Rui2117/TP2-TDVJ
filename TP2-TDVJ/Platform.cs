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
        public Platform(Texture2D texture, Vector2 position) : base(texture)
        {
            this._texture = texture;
            this.width = 100;
            this.height = 100;
            this.position = position;
            this.color = Color.White;
        }

        public void DrawPlatform(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, hitbox, Color.White);
        }
    }
}
