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
    public class Bullet
    {
        int speed;

        public Vector2 position;
        public Vector2 velocity;

        public Rectangle hitbox { get => new Rectangle((int)position.X, (int)position.Y, 20, 20); }
        private Texture2D texture;

        public Bullet(Vector2 position, Texture2D bulletTexture)
        {
            this.position = position;
            this.velocity = Vector2.Zero;
            this.texture = bulletTexture;
            this.speed = 9;
            // Define o retângulo de hitbox com base na textura da bala
            
        }

        public void Update(GameTime gametime)
        {
            velocity.X = speed;
            // Atualiza a posição da bala com base na velocidade
            position += velocity;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            //Position = position;
            spriteBatch.Draw(texture, hitbox, Color.White);
        }

        private void Hit(List<Bullet> bullets)
        {
            bullets.Remove(this);
        }

        //private void CheckColision(List<Objects> objects)
        //{
        //    foreach (Objects aux in objects)
        //    {
        //        if (aux == this)
        //        {
        //            continue;
        //        }

        //        if ((this.velocity.X > 0 && this.IsTouchingLeft(aux)) || (this.velocity.X < 0 & this.IsTouchingRight(aux)))
        //        {
        //            this.Hit(objects);
        //        }

        //        if ((this.velocity.Y > 0 && this.IsTouchingTop(aux)) || (this.velocity.Y < 0 & this.IsTouchingBottom(aux)))
        //        {
        //            this.velocity.Y = 0;
        //        }
        //    }
        //}
    }
    
}

