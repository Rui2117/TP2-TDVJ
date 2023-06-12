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
    public class Camera
    {
        public Matrix Transform { get; private set; }

        public void Follow(Objects target)
        {
            var position = Matrix.CreateTranslation(-target.position.X - (target.hitbox.Width / 2), -250, 0);

            var offset = Matrix.CreateTranslation(Game1.screenWidth/4, Game1.screenHeight / 2, 0);

            Transform = position * offset;
        }
    }

}
