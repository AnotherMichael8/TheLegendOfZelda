using Sprint2_Attempt3.Collision;
using System;
using Sprint2_Attempt3.Player.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces
{
    public interface IBomb : ILinkProjectile
    {
        public void RemoveBomb();
        public void Explode();
    }
}
