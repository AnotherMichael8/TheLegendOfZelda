
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Dungeon;

namespace Sprint2_Attempt3.Collision
{
    internal class TripwireHandler
    {
        public TripwireHandler() { }
        public static void HandleTripwire(IGameObject enemy, ILink link)
        {
            Rectangle leftVerticalTripwire = new Rectangle(124, 0 + Globals.YOffset, 1, 500);
            Rectangle rightVerticalTripwire = new Rectangle(674, 0 + Globals.YOffset, 1, 500);
            Rectangle downHorizontalTripwire = new Rectangle(0, 599, 800, 1);
            Rectangle upHorizontalTripWire = new Rectangle(0, 299, 800, 1);
            Rectangle linkintersect = link.GetHitBox();

            if (linkintersect.Intersects(leftVerticalTripwire))
            {
                if (enemy is SpikeTrap)
                {
                    if (((SpikeTrap)enemy).X < 400 && ((SpikeTrap)enemy).Y < 375)
                    {
                        ((SpikeTrap)enemy).MoveDown();
                    }
                    else if (((SpikeTrap)enemy).X < 400 && ((SpikeTrap)enemy).Y >= 375)
                    {
                        ((SpikeTrap)enemy).MoveUp();
                    }
                }
                else if (enemy is HandCreator)
                {
                    ((HandCreator)enemy).CreateHandLeft(link.Position);
                }
            }
            else if (linkintersect.Intersects(rightVerticalTripwire))
            {
                if (enemy is SpikeTrap)
                {
                    if (((SpikeTrap)enemy).X >= 400 && ((SpikeTrap)enemy).Y < 375)
                    {
                        ((SpikeTrap)enemy).MoveDown();
                    }
                    else if (((SpikeTrap)enemy).X >= 400 && ((SpikeTrap)enemy).Y >= 375)
                    {
                        ((SpikeTrap)enemy).MoveUp();
                    }
                }
                else if (enemy is HandCreator)
                {
                    ((HandCreator)enemy).CreateHandRight(link.Position);
                }

            }
            else if (linkintersect.Intersects(upHorizontalTripWire))
            {
                if (enemy is SpikeTrap)
                {
                    if (((SpikeTrap)enemy).Y < 375 && ((SpikeTrap)enemy).X < 400)
                    {
                        ((SpikeTrap)enemy).MoveRight();
                    }
                    else if (((SpikeTrap)enemy).Y < 375 && ((SpikeTrap)enemy).X >= 400)
                    {
                        ((SpikeTrap)enemy).MoveLeft();
                    }
                }
                else if (enemy is HandCreator)
                {
                    ((HandCreator)enemy).CreateHandUp(link.Position);
                }
            }
            else if (linkintersect.Intersects(downHorizontalTripwire))
            {
                if (enemy is SpikeTrap)
                {
                    if (((SpikeTrap)enemy).Y >= 375 && ((SpikeTrap)enemy).X < 400)
                    {
                        ((SpikeTrap)enemy).MoveRight();
                    }
                    else if (((SpikeTrap)enemy).Y >= 375 && ((SpikeTrap)enemy).X >= 400)
                    {
                        ((SpikeTrap)enemy).MoveLeft();
                    }
                }
                else if (enemy is HandCreator)
                {
                    ((HandCreator)enemy).CreateHandDown(link.Position);
                }

            }
        }
    }
}
