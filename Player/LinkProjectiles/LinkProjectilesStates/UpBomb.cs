using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using static Sprint2_Attempt3.Player.Link;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class UpBomb : Bomb
    {
        public UpBomb(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 11, (int)link.Position.Y - 45);
        }
    }
}
