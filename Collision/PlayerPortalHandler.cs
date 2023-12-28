using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Portal;


namespace Sprint2_Attempt3.Collision
{
    public class PlayerPortalHandler
    {
        private static TimeSpan timeBuffer;
        private static DateTime lastTeleportTime { get; set; }
        public static void HandlePlayerPortalCollision(ILink link, Portal.Portal portal, Game1 game)
        {
            timeBuffer = DateTime.Now - lastTeleportTime;
            TimeSpan coolDown = TimeSpan.FromSeconds(1);
            if (timeBuffer >= coolDown)
            {
                link.Position = portal.Teleport();
                /*
                if (portal is FirstPortal)
                {
                    foreach(IGameObject obj in game.room.gameObjectList)
                    {
                        if (obj is SecondPortal secondaPortal)
                            link.Position = ((IPortal)portal).Teleport(secondaPortal);
                    }
                }
                else if (portal is SecondPortal)
                {
                    foreach (IGameObject obj in game.room.gameObjectList)
                    {
                        if (obj is FirstPortal firstPortal)
                            link.Position = ((IPortal)portal).Teleport(firstPortal);
                    }
                }
                */
            }
                
            lastTeleportTime = DateTime.Now;

        }
    }
}
