using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    internal class SpikeTrapHandler
    {
        public SpikeTrapHandler() { }
        public static void HandleSpikeTrap(SpikeTrap spiketrap, ILink link)
        {
            Rectangle up = new Rectangle(spiketrap.X+20, spiketrap.Y - 500, 1, 500);
            Rectangle down = new Rectangle(spiketrap.X + 20, spiketrap.Y, 1, 500);
            Rectangle left = new Rectangle(spiketrap.X - 800, spiketrap.Y + 20, 800, 1);
            Rectangle right = new Rectangle(spiketrap.X, spiketrap.Y + 20, 500, 1);
            Rectangle linkintersect = link.GetHitBox();
            if (linkintersect.Intersects(up))
            {
                spiketrap.MoveUp();
            } 
            else if(linkintersect.Intersects(down))
            {
                spiketrap.MoveDown();
            }
            else if (linkintersect.Intersects(left))
            {
                spiketrap.MoveLeft();
            }
            else if (linkintersect.Intersects(right))
            {
                spiketrap.MoveRight();
            }

        }
    }
}
