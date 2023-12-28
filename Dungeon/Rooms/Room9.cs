using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room9 : RoomSecondary
    {
        private static bool doorOpen;
        private static IMovingBlock movingBlock;
        private static WestDoor diamondDoor;
        public Room9(Game1 game1) : base(game1, 8)
        {
            roomLayout[4, 8] = this;
            doorOpen = false;
            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is IMovingBlock)
                {
                    movingBlock = (IMovingBlock)obj;
                }
                else if (obj is WestDoor)
                {
                    diamondDoor = (WestDoor)obj;
                }
            }
        }


        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            for (int i = 0; i < roomLayout[mapX, mapY].gameObjectList.Count; i++)
            {
                IGameObject obj = roomLayout[mapX, mapY].gameObjectList[i];
                if (obj is NorthDoor)
                {
                    if (((NorthDoor)obj).IsLocked)
                    {
                        ((NorthDoor)obj).Open();
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
        public override void RoomConditionCheck()
        {
            if (!doorOpen && movingBlock.Moved)
            {
                diamondDoor.Open();
                doorOpen = true;
            }
        }
    }
}
