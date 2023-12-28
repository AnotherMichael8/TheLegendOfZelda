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
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class LeftArrow : Arrow, IArrow
    {
        public LeftArrow(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X - 45, (int)link.Position.Y + 15);
            flip = SpriteEffects.FlipHorizontally;
            sourceRectangle = new Rectangle(10, 190, 15, 5);
            HitBoxWidth = 45;
            HitBoxHeight = 15;
        }
        public override void Update()
        {
            if (currentFrame == 55)
            {
                DestroyArrow();
            }
            sprite.Update();
            currentFrame++;
            itemPosition.X = itemPosition.X - 5;

        }
    }
}
