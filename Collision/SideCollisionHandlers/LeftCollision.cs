using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.LinkStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision.SideCollisionHandlers
{
    public class LeftCollision : ICollision
    {
        public LeftCollision() { }

        public void LinkEnemyKnockback(Link link)
        {
            link.State = new KnockbackRightLinkState(link);
        }
    }
}
