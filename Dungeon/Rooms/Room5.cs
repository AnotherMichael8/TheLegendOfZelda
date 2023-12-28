using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room5 : RoomSecondary
    {
        private static List<IEnemy> enemies;
        private static EastDoor diamondDoor;
        private static bool doorOpen;
        public Room5(Game1 game1) : base(game1, 4) 
        {
            roomLayout[4, 9] = this;
            doorOpen = false;
            enemies = new List<IEnemy>();
            foreach(IGameObject obj in gameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
                else if(obj is EastDoor)
                {
                    diamondDoor = (EastDoor)obj;
                }
            }
        }
        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            for (int i = 0; i < roomLayout[mapX, mapY].gameObjectList.Count; i++)
            {
                IGameObject obj = roomLayout[mapX, mapY].gameObjectList[i];
                if (obj is SouthDoor)
                {
                    if (((SouthDoor)obj).IsLocked)
                    {
                        ((SouthDoor)obj).Open();
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
        public override void RoomConditionCheck()
        {
            if(!doorOpen && allEnemiesKilledInRoom(enemies))
            {
                diamondDoor.Open();
                doorOpen = true; 
            }
        }

    }
}
