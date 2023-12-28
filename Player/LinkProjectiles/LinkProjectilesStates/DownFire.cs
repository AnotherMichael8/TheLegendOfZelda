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
    public class DownFire : Fire
    {
        public DownFire(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X, (int)link.Position.Y + 45);
        }
        public override void Update()
        {
            if (currentFrame == 60)
            {
                link.Items.Remove(this);
                CollisionManager.GameObjectList.Remove(this);
            }
            sprite.Update();
            currentFrame++;
            if (!stop && currentFrame < 40)
            {
                itemPosition.Y = itemPosition.Y + 2;
            }

        }
    }
}
