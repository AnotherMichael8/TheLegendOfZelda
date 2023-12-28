using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class Fire : LinkProjectileSecondary, IFire
    {
        protected bool stop;
        public Fire(Link link) : base(link)
        {
            sprite = LinkSpriteFactory.Instance.CreateFireItem();
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(191, 185, 15, 15);
            HitBoxWidth = 45;
            HitBoxHeight = 45;
        }
        public void Stop()
        {
            stop = true;
        }
    }
}
