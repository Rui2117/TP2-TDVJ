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
        Rectangle hitbox { get => new Rectangle((int) position.X, (int) position.Y, width, height); } 
        int speed, jumppower, height, width;
        bool grounded, isdead;

        public Player(Texture2D texture, Vector2 position) : base(texture)
        {
            this._texture = texture;
            this.position = position;
            this.velocity = Vector2.Zero;
            this.speed = 6;
            this.jumppower = -300;
            this.height = 100;
            this.width = 100;
            this.grounded = false;
            this.isdead = false;
        }
        public void UpdatePlayer(double deltatime)
        {
            Movement();
            Gravity(deltatime);

            position += velocity;
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
            velocity.Y -= jumppower * (float)(deltatime);
        }

        private void Jump()
        {
            velocity.Y = jumppower;
            grounded = false;

        }

    }
}
