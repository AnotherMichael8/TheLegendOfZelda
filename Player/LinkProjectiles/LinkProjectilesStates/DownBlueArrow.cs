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
    public class DownBlueArrow : Arrow
    {
        public DownBlueArrow(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 15, (int)link.Position.Y + 45);
            flip = SpriteEffects.FlipVertically;
            sourceRectangle = new Rectangle(29, 185, 5, 15);
            HitBoxWidth = 15;
            HitBoxHeight = 45;
        }
        public override void Update()
        {
            if (currentFrame == 55)
            {
                DestroyArrow();
            }
            sprite.Update();
            currentFrame++;
            itemPosition.Y = itemPosition.Y + 7;

        }
    }
}
