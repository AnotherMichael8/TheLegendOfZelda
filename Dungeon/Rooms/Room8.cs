using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room8 : RoomSecondary
    {
        public Room8(Game1 game1) : base(game1, 7) 
        {
            roomLayout[3, 8] = this;
        }
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
