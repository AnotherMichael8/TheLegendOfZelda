using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces
{
    public interface IArrow : ILinkProjectile
    {
        public void DestroyArrow() { }
    }
}
