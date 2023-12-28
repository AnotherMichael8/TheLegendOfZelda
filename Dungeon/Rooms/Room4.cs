using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room4 : RoomSecondary
    {
        public Room4(Game1 game1) : base(game1, 3) 
        {
            roomLayout[5, 10] = this;
        }
        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
    }
}
