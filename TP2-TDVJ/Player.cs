using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;

namespace TP2_TDVJ
{
    public class Player : Objects
    {
        int speed, jumppower;
        bool grounded, isdead;
        private ContentManager content { get; set; }

        private bool isShootKeyPressed = false;

        public Player(Texture2D texture, Vector2 position, ContentManager content) : base(texture)
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
            this.content = content;
        }
        public void UpdatePlayer(double deltatime, List<Objects> list, List<Bullet> bullets)
        {
            Movement();
            UpdateInput(bullets);
            Gravity(deltatime);
            
            CheckColision(list);
            position += velocity;
            if (position.Y > 500)
            {
                Die();
            }
            Die();
        }

        public void UpdateInput(List<Bullet> bullets)
        {
            // Dispara uma bala quando a tecla de espaço é pressionada
            if (Keyboard.GetState().IsKeyDown(Keys.LeftControl))
            {
                Shoot(bullets);
                //isShootKeyPressed = true;
            }
            else if (Keyboard.GetState().IsKeyUp(Keys.LeftControl))
            {
                isShootKeyPressed = false;
            }
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
            //if (Keyboard.GetState().IsKeyDown(Keys.E))
            //{
            //    Shoot(bullets);
            //}
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
        
        private void Shoot(List<Bullet> bullets)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.LeftControl))
            {
                // Cria uma bala com base na posição atual do jogador
                Vector2 bulletPosition = new Vector2(position.X + position.Y);

                Texture2D bulletTexture = content.Load<Texture2D>("bullet_04");

                Bullet bullet = new Bullet(bulletPosition, bulletTexture);

                bullets.Add(bullet);
            }
        }

        private void CheckColision(List<Objects> objects)
        {
            foreach (Objects aux in objects)
            {
                if (aux == this)
                    continue;

                if ((this.velocity.X > 0 && this.IsTouchingLeft(aux)) || (this.velocity.X < 0 & this.IsTouchingRight(aux)))
                {
                    this.velocity.X = 0;
                    this.isdead = true;
                }

                if ((this.velocity.Y > 0 && this.IsTouchingTop(aux)) || (this.velocity.Y < 0 & this.IsTouchingBottom(aux)))
                {
                    this.velocity.Y = 0;
                    grounded = true;
                }
            }
        }

    }
}
