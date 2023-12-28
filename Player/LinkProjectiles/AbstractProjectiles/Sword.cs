using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class Sword : LinkProjectileSecondary, ISword
    {
        public Sword(Link link) : base(link)
        {
            sprite = LinkSpriteFactory.Instance.CreateAttackLinkSwordSprite();
            //Starting animation doesn't have a sword
            sourceRectangle = new Rectangle(0, 0, 0, 0);
            HitBoxHeight = 0;
            HitBoxWidth = 0;
        }
    }
}
