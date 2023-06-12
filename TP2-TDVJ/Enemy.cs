using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;

namespace TP2_TDVJ
{
    public class Enemy : Objects
    {

        bool grounded;

        public Enemy(Texture2D texture, Vector2 position) : base(texture)
        {
            this._texture = texture;
            this.position = position;
            this.height = 100;
            this.width = 100;
            this.grounded = true;
        }


        public override void Update(double deltatime, List<Objects> list)
        {
            CheckColision(list);
        }

        private void Die(List<Objects> list)
        {
            list.Remove(this);
        }

        private void CheckColision(List<Objects> objects)
        {
            foreach (Objects aux in objects)
            {
                if (aux == this)
                {
                    continue;
                }

                if ((this.velocity.X > 0 && this.IsTouchingLeft(aux)) || (this.velocity.X < 0 & this.IsTouchingRight(aux)))
                {
                    this.Die(objects);
                }

                if ((this.velocity.Y > 0 && this.IsTouchingTop(aux)) || (this.velocity.Y < 0 & this.IsTouchingBottom(aux)))
                {
                    this.velocity.Y = 0;
                    grounded = true;
                }
            }
        }

        public void DrawEnemy(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, hitbox, Color.White);
        }
    }
}
