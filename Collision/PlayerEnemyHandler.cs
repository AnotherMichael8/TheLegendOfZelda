using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy.SpikeTrap;

namespace Sprint2_Attempt3.Collision
{
    internal class PlayerEnemyHandler
    {
        public static void HandlePlayerEnemyCollision(ILink link, IEnemy enemy, ICollision side)
        {
            if(enemy is Hand)
            {
                /*find closest point to the wall*/
                Link newlink = (Link)link;
                newlink.State = new Player.LinkStates.Captured(newlink);
                enemy.X = (int)link.Position.X;
                enemy.Y = (int)link.Position.Y;
                Hand hand2 = (Hand)enemy;
                hand2.State = new CapturedState(hand2, link.Position);
            }
            else {
                link.GetDamaged(side);
            }
        }
    }
}
