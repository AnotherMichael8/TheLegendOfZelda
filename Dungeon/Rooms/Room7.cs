using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room7 : RoomSecondary
    {
        public Room7(Game1 game1) : base(game1, 6) 
        {
            roomLayout[6, 9] = this;
        }
        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            for (int i = 0; i < roomLayout[mapX, mapY].gameObjectList.Count; i++)
            {
                IGameObject obj = roomLayout[mapX, mapY].gameObjectList[i];
                if (obj is SouthDoor)
                {
                    if (((SouthDoor)obj).IsBombWall)
                    {
                        ((SouthDoor)obj).Damage();
                    }
                    break;
                }
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
