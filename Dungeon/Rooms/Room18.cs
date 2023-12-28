using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room18 : RoomSecondary
    {
        private static bool keySpawned;
        private static List<IEnemy> enemies;
        private static Key key;
        public Room18(Game1 game1) : base(game1, 17) 
        {
            roomLayout[5, 6] = this;
            keySpawned = false;
            enemies = new List<IEnemy>();
            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemies.Add((IEnemy)obj);
                }
                else if (obj is Key)
                {
                    key = (Key)obj;
                }
            }
        }

        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void RoomConditionCheck()
        {
            if (!keySpawned && allEnemiesKilledInRoom(enemies))
            {
                key.Spawn();
                keySpawned = true;
            }
        }

    }
}
