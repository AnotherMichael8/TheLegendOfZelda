using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class RandomRooms : RoomSecondary
    {
        //public static Rectangle locationMapTrackerRec;
        public RandomRooms(Game1 game, int roomNum) : base(game, roomNum)
        {
        }
        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            if (roomLayout[mapX,mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
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
        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
    }
}
