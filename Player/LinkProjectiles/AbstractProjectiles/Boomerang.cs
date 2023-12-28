using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class Boomerang : LinkProjectileSecondary, IBoomerang
    {
        protected bool changeDirection;

        public Boomerang(Link link) : base(link)
        { 
            changeDirection = false;
        }
        public Vector2 BoomerangPositionUpdater(Vector2 itemPosition, Vector2 linkPosition, int speed)
        {
            Vector2 newItemPosition = itemPosition;
            Vector2 actualLinkPosition;
            //The center of link
            actualLinkPosition.X = linkPosition.X + 7;
            actualLinkPosition.Y = linkPosition.Y + 7;

            //Find the slope and yInt for vector pointing towards link from the boomerang
            float slope = (itemPosition.Y - actualLinkPosition.Y) / (itemPosition.X - actualLinkPosition.X);
            float yInt = itemPosition.Y - slope * itemPosition.X;

            if (Math.Abs(itemPosition.X - actualLinkPosition.X) > Math.Abs(itemPosition.Y - actualLinkPosition.Y))
            {
                if (itemPosition.X > actualLinkPosition.X)
                {
                    newItemPosition.X -= speed;
                }
                else
                {
                    newItemPosition.X += speed;
                }
                newItemPosition.Y = slope * newItemPosition.X + yInt;
            }
            else
            {
                if (itemPosition.Y > actualLinkPosition.Y)
                {
                    newItemPosition.Y -= speed;
                }
                else
                {
                    newItemPosition.Y += speed;
                }
                newItemPosition.X = (newItemPosition.Y - yInt) / slope;
            }
            return newItemPosition;
        }
        public void ReverseDirection()
        {
            if (!changeDirection)
            {
                link.Items.Add(new ItemHit(link, itemPosition));
                changeDirection = true;
            }
        }
    }

}
