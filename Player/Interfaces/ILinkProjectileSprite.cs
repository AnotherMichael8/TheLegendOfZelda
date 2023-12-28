using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Interfaces
{
    public interface ILinkProjectileSprite
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Rectangle sourceRectanlge, SpriteEffects flip);
    }
}
