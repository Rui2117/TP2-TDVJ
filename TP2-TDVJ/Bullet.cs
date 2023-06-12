using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_TDVJ
{
    public class Bullet : Objects
    {
        public Bullet(Texture2D texture) : base(texture)
        {
            this._texture = texture;
        }

        public override void Update(double deltatime, List<Objects> list)
        {
            CheckColision(list);
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
                    this.Hit(objects);
                }

                if ((this.velocity.Y > 0 && this.IsTouchingTop(aux)) || (this.velocity.Y < 0 & this.IsTouchingBottom(aux)))
                {
                    this.velocity.Y = 0;
                }
            }
        }

        private void Hit(List<Objects> list)
        {
            list.Remove(this);
        }
    }
}
