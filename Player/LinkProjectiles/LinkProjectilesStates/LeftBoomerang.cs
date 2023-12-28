using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class LeftBoomerang : Boomerang
    {
        public LeftBoomerang(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X - 23, (int)link.Position.Y + 12);
            sourceRectangle = new Rectangle(64, 189, 7, 7);
            sprite = LinkSpriteFactory.Instance.CreateBoomerangItem();
        }
        public override void Update()
        {
            int speed;
            if (!changeDirection && currentFrame >= 0 && currentFrame < 50)
            {
                speed = 5;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (!changeDirection && currentFrame >= 50 && currentFrame < 60)
            {
                speed = 2;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (!changeDirection && currentFrame >= 60 && currentFrame < 70)
            {
                speed = -2;
                itemPosition.X = itemPosition.X - speed;
            }
            else
            {
                itemPosition = BoomerangPositionUpdater(itemPosition, link.Position, 5);
            }
            sprite.Update();
            currentFrame++;

        }
    }
}