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
    public class Objects
    {
        protected Texture2D _texture;

        public int height, width;
        public Vector2 position;
        public Vector2 velocity;
        public Color color = Color.White;
        public Rectangle hitbox { get => new Rectangle((int)position.X, (int)position.Y, width, height); }
        
        public Objects(Texture2D texture)
        {
            _texture = texture;
        }

        public virtual void Update(List<Objects> objects, List<Bullet> bullets)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, color);
        }

        #region Colloision
        protected bool IsTouchingLeft(Objects sprite)
        {
            return this.hitbox.Right + this.velocity.X > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Left &&
              this.hitbox.Bottom > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Bottom;
        }

        protected bool IsTouchingRight(Objects sprite)
        {
            return this.hitbox.Left + this.velocity.X < sprite.hitbox.Right &&
              this.hitbox.Right > sprite.hitbox.Right &&
              this.hitbox.Bottom > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Bottom;
        }

        protected bool IsTouchingTop(Objects sprite)
        {
            return this.hitbox.Bottom + this.velocity.Y > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Top &&
              this.hitbox.Right > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Right;
        }

        protected bool IsTouchingBottom(Objects sprite)
        {
            return this.hitbox.Top + this.velocity.Y < sprite.hitbox.Bottom &&
              this.hitbox.Bottom > sprite.hitbox.Bottom &&
              this.hitbox.Right > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Right;
        }

        protected bool IsTouchingLeft(Bullet sprite)
        {
            return this.hitbox.Right + this.velocity.X > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Left &&
              this.hitbox.Bottom > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Bottom;
        }

        protected bool IsTouchingRight(Bullet sprite)
        {
            return this.hitbox.Left + this.velocity.X < sprite.hitbox.Right &&
              this.hitbox.Right > sprite.hitbox.Right &&
              this.hitbox.Bottom > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Bottom;
        }

        protected bool IsTouchingTop(Bullet sprite)
        {
            return this.hitbox.Bottom + this.velocity.Y > sprite.hitbox.Top &&
              this.hitbox.Top < sprite.hitbox.Top &&
              this.hitbox.Right > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Right;
        }

        protected bool IsTouchingBottom(Bullet sprite)
        {
            return this.hitbox.Top + this.velocity.Y < sprite.hitbox.Bottom &&
              this.hitbox.Bottom > sprite.hitbox.Bottom &&
              this.hitbox.Right > sprite.hitbox.Left &&
              this.hitbox.Left < sprite.hitbox.Right;
        }
        #endregion
    }

}
