using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Collision.SideCollisionHandlers
{
    public class TopCollision : ICollision
    {
        public TopCollision() { }
        public void LinkEnemyKnockback(Link link)
        {
            link.State = new KnockbackDownLinkState(link);
        }
    }
}