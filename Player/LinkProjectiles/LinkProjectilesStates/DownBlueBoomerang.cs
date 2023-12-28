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
    public class DownBlueBoomerang : Boomerang
    {
        public DownBlueBoomerang(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 12, (int)link.Position.Y + 45);
            sourceRectangle = new Rectangle(91, 189, 7, 7);
            sprite = LinkSpriteFactory.Instance.CreateBlueBoomerangItem();
        }

        public override void Update()
        {
            int speed;
            if (!changeDirection && currentFrame >= 0 && currentFrame < 50)
            {
                speed = 7;
                itemPosition.Y = itemPosition.Y + speed;
            }
            else if (!changeDirection && currentFrame >= 50 && currentFrame < 60)
            {
                speed = 3;
                itemPosition.Y = itemPosition.Y + speed;
            }
            else if (!changeDirection && currentFrame >= 60 && currentFrame < 70)
            {
                speed = -3;
                itemPosition.Y = itemPosition.Y + speed;
            }
            else
            {
                itemPosition = BoomerangPositionUpdater(itemPosition, link.Position, 7);
            }

            sprite.Update();
            currentFrame++;
        }
    }
}