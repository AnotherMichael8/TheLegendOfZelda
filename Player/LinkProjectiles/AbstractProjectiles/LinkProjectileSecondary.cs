using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;


namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class LinkProjectileSecondary : ILinkProjectile
    {
        protected Link link;
        protected int currentFrame;
        protected Vector2 itemPosition;
        protected SpriteEffects flip;
        protected Rectangle sourceRectangle;
        protected int HitBoxWidth;
        protected int HitBoxHeight;
        protected ILinkProjectileSprite sprite;
        public LinkProjectileSecondary(Link link)
        {
            this.link = link;
            currentFrame = 0;
            flip = SpriteEffects.None;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }
        public virtual Rectangle GetHitBox()
        {
            return new Rectangle((int)itemPosition.X, (int)itemPosition.Y, HitBoxWidth, HitBoxHeight);
        }
        public abstract void Update();
    }
}
