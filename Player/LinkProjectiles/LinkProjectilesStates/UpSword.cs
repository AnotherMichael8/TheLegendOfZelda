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
    public class UpSword : Sword
    {
        public UpSword(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 17, (int)link.Position.Y);
            flip = SpriteEffects.FlipVertically;
        }

        public override void Update()
        {
            if (currentFrame == 20)
            {
                link.Items.Remove(this);
                CollisionManager.GameObjectList.Remove(this);
            }
            if (currentFrame >= 5 && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(25, 63, 3, 11);
                itemPosition.Y = link.Position.Y - 33;
                itemPosition.X = link.Position.X + 17;
                HitBoxWidth = 9;
                HitBoxHeight = 33;
            }
            else if (currentFrame >= 10 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(42, 63, 3, 7);
                itemPosition.Y = link.Position.Y - 21;
                itemPosition.X = link.Position.X + 17;
                HitBoxWidth = 9;
                HitBoxHeight = 21;
            }
            else if (currentFrame >= 15 && currentFrame < 20)
            {
                sourceRectangle = new Rectangle(59, 63, 3, 3);
                itemPosition.Y = link.Position.Y - 9;
                itemPosition.X = link.Position.X + 17;
                HitBoxWidth = 9;
                HitBoxHeight = 9;
            }
            else if(currentFrame >= 20)
            {
                link.Items.Remove(this);
                CollisionManager.GameObjectList.Remove(this);
            }
            sprite.Update();
            currentFrame++;
        }
    }
}
