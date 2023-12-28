using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room11 : RoomSecondary
    {
        private static bool boomerangSpawned;
        private static List<IEnemy> enemies;
        private static Boomerang boomerang;
        public Room11(Game1 game1) : base(game1, 10) 
        {
            roomLayout[6, 8] = this;
            boomerangSpawned = false;
            enemies = new List<IEnemy>();
            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
                else if (obj is Boomerang)
                {
                    boomerang = (Boomerang)obj;
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
        public override void RoomConditionCheck()
        {
            if (!boomerangSpawned && allEnemiesKilledInRoom(enemies))
            {
                boomerang.Spawn();
                boomerangSpawned = true;
            }
        }

    }
}
