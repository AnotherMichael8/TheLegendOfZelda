using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using System.ComponentModel;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class ItemHit : LinkProjectileSecondary
    {
        public ItemHit(Link link, Vector2 itemPosition) : base(link)
        {
            this.link = link;
            this.itemPosition = itemPosition;
            currentFrame = 0;
            sourceRectangle = new Rectangle(118, 185, 7, 15);
            flip = SpriteEffects.None;
            sprite = LinkSpriteFactory.Instance.CreateItemHitSprite();
        }
        public override void Update()
        {
            if (currentFrame == 5)
            {
                link.Items.Remove(this);
            }
            currentFrame++;
        }
        public override Rectangle GetHitBox()
        {
            //Doesn't have a hit box
            return new Rectangle(0, 0, 0, 0);
        }

    }
}
