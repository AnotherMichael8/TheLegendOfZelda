using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room1 : RoomSecondary
    {
        public Room1(Game1 game1): base(game1, 0) 
        {
            roomLayout[5, 11] = this;
        }

        public override void SwitchToNorthRoom() {
            mapY -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToEastRoom() {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToWestRoom() {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
