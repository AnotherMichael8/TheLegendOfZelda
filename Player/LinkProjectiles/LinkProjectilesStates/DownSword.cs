using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class DownSword : Sword
    {
        public DownSword(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 21, (int)link.Position.Y + 45);
            sourceRectangle = new Rectangle(25, 63, 3, 11);
            flip = SpriteEffects.None;
        }

        public override void Update()
        {
            if (currentFrame >= 5 && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(25, 63, 3, 11);
                itemPosition.X = link.Position.X + 21;
                itemPosition.Y = link.Position.Y + 45;
                HitBoxWidth = 9;
                HitBoxHeight = 33;
            }
            else if (currentFrame >= 10 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(42, 63, 3, 7);
                itemPosition.X = link.Position.X + 21;
                itemPosition.Y = link.Position.Y + 45;
                HitBoxWidth = 9;
                HitBoxHeight = 21;
            }
            else if (currentFrame >= 15 && currentFrame < 20)
            {
                sourceRectangle = new Rectangle(59, 63, 3, 3);
                itemPosition.X = link.Position.X + 21;
                itemPosition.Y = link.Position.Y + 45;
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
