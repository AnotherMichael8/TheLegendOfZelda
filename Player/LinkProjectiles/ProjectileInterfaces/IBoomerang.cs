using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces
{
    public interface IBoomerang : ILinkProjectile
    {
        public Vector2 BoomerangPositionUpdater(Vector2 itemPosition, Vector2 linkPosition, int speed);
        public void ReverseDirection();
    }
}
