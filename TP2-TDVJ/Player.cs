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
    public class Player : Objects
    {
        int speed, jumppower;
        bool grounded, isdead;

        public Player(Texture2D texture, Vector2 position) : base(texture)
        {
            this._texture = texture;
            this.position = position;
            this.velocity = Vector2.Zero;
            this.speed = 6;
            this.jumppower = 10;
            this.height = 100;
            this.width = 100;
            this.grounded = false;
            this.isdead = false;
        }
        public void UpdatePlayer(double deltatime, List<Objects> list)
        {
            Movement();
            Gravity(deltatime);
            
            CheckColision(list);
            position += velocity;
            Die();
        }


        public void DrawPlayer(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, hitbox, Color.White);

        }

        public void Movement()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && grounded == true)
            {
                Jump();
            }

            velocity.X = speed;
        }

        public void Gravity(double deltatime)
        {
            velocity.Y += (jumppower*2) * (float)(deltatime);
        }

        public void Die()
        {
            if (isdead == true)
            {

            }
        }
        private void Jump()
        {
            velocity.Y -= jumppower;
            grounded = false;

        }
        
        private void CheckColision(List<Objects> objects)
        {
            foreach (Objects aux in objects)
            {
                if (aux == this)
                    continue;

                if ((this.velocity.X > 0 && this.IsTouchingLeft(aux)) ||
                    (this.velocity.X < 0 & this.IsTouchingRight(aux)))
                    this.velocity.X = 0;

                if ((this.velocity.Y > 0 && this.IsTouchingTop(aux)) || (this.velocity.Y < 0 & this.IsTouchingBottom(aux)))
                {
                    this.velocity.Y = 0;
                    grounded = true;
                }
            }
        }

    }
}
