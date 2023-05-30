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

        public Vector2 position;
        public Vector2 velocity;
        public Color color = Color.White;

        public Rectangle rectangle
        {
            get
            {
                return new Rectangle ((int)position.X, (int)position.Y, _texture.Width, _texture.Height);
            }
        }
        
        public Objects(Texture2D texture)
        {
            _texture = texture;
        }

        public virtual void Update(GameTime gameTime, List<Objects> objects)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, color);
        }

        #region Colloision
        protected bool IsTouchingLeft(Objects sprite)
        {
            return this.rectangle.Right + this.velocity.X > sprite.rectangle.Left &&
              this.rectangle.Left < sprite.rectangle.Left &&
              this.rectangle.Bottom > sprite.rectangle.Top &&
              this.rectangle.Top < sprite.rectangle.Bottom;
        }

        protected bool IsTouchingRight(Objects sprite)
        {
            return this.rectangle.Left + this.velocity.X < sprite.rectangle.Right &&
              this.rectangle.Right > sprite.rectangle.Right &&
              this.rectangle.Bottom > sprite.rectangle.Top &&
              this.rectangle.Top < sprite.rectangle.Bottom;
        }

        protected bool IsTouchingTop(Objects sprite)
        {
            return this.rectangle.Bottom + this.velocity.Y > sprite.rectangle.Top &&
              this.rectangle.Top < sprite.rectangle.Top &&
              this.rectangle.Right > sprite.rectangle.Left &&
              this.rectangle.Left < sprite.rectangle.Right;
        }

        protected bool IsTouchingBottom(Objects sprite)
        {
            return this.rectangle.Top + this.velocity.Y < sprite.rectangle.Bottom &&
              this.rectangle.Bottom > sprite.rectangle.Bottom &&
              this.rectangle.Right > sprite.rectangle.Left &&
              this.rectangle.Left < sprite.rectangle.Right;
        }

        #endregion
    }

}
