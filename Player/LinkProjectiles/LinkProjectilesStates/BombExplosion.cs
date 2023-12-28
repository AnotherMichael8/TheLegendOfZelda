using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class BombExplosion : LinkProjectileSecondary
    {
        private const int hitBoxWidth = 40;
        private const int hitBoxHeight = 40;
        private Vector2 startPosition;
        public BombExplosion(Link link, Vector2 position) : base(link)
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBombExplosion();
            itemPosition = position;
            sourceRectangle = new Rectangle(138, 185, 15, 15);
            flip = SpriteEffects.FlipHorizontally;
            startPosition.X = position.X - 22 * 3;
            startPosition.Y = position.Y - 15 * 3;

        }
        public override void Update()
        {
            if (currentFrame == 10)
            {
                CollisionManager.GameObjectList.Remove(this);
                link.Items.Remove(this);
            }
            currentFrame++;
            sprite.Update();
        }
        public override Rectangle GetHitBox()
        {
            return new Rectangle((int)startPosition.X, (int)startPosition.Y, hitBoxWidth * 3, hitBoxHeight * 3);
        }
    }
}
