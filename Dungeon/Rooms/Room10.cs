using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room10 : RoomSecondary
    {
        public Room10(Game1 game1) : base(game1, 9) 
        {
            roomLayout[5, 8] = this;
        }

        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            for (int i = 0; i < roomLayout[mapX, mapY].gameObjectList.Count; i++)
            {
                IGameObject obj = roomLayout[mapX, mapY].gameObjectList[i];
                if (obj is NorthDoor)
                {
                    if (((NorthDoor)obj).IsBombWall)
                    {
                        ((NorthDoor)obj).Damage();
                    }
                    break;
                }
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
