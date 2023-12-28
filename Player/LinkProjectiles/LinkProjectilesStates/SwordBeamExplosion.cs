using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class SwordBeamExplosion : LinkProjectileSecondary
    {
        public SwordBeamExplosion(Link link, Vector2 itemPosition) : base(link)
        {
            this.link = link;
            this.itemPosition = itemPosition;
            itemPosition.X += 15;
            itemPosition.Y += 15;
            currentFrame = 0;
            sourceRectangle = new Rectangle(27, 157, 8, 10);
            flip = SpriteEffects.None;
            sprite = LinkSpriteFactory.Instance.CreateSwordBeamExplosionSprite();
        }
        public override void Update()
        {
            if (currentFrame == 15)
            {
                link.Items.Remove(this);
            }
            itemPosition.X -= 4;
            itemPosition.Y -= 4;
            currentFrame++;
            sprite.Update();
        }
        public override Rectangle GetHitBox()
        {
            //Doesn't have a hit box
            return new Rectangle(0, 0, 0, 0);
        }

    }
}
