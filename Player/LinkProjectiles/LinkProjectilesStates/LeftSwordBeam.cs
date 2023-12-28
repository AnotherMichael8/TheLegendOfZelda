using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class LeftSwordBeam : SwordBeam
    {
        public LeftSwordBeam(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X - 45, (int)link.Position.Y + 15);
            flip = SpriteEffects.FlipHorizontally;
            sourceRectangle = new Rectangle(10, 159, 16, 7);
            HitBoxWidth = 48;
            HitBoxHeight = 21;
        }
        public override void Update()
        {
            sprite.Update();
            currentFrame++;
            itemPosition.X = itemPosition.X - speed;
        }
    }
}