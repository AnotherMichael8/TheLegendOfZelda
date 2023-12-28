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
    public class DownSwordBeam : SwordBeam
    {
        public DownSwordBeam(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 15, (int)link.Position.Y + 45);
            flip = SpriteEffects.FlipVertically;
            sourceRectangle = new Rectangle(1, 154, 7, 16);
            HitBoxWidth = 21;
            HitBoxHeight = 48;
        }
        public override void Update()
        {
            sprite.Update();
            currentFrame++;
            itemPosition.Y = itemPosition.Y + speed;
        }
    }
}