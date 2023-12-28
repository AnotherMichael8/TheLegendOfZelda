using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room2 : RoomSecondary
    {
        private static bool keySpawned;
        private static List<IEnemy> enemies;
        private static Key key;
        public Room2(Game1 game1) : base(game1, 1) 
        {
            roomLayout[4, 11] = this;
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
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

        public override void SwitchToNorthRoom()
        {
            mapY--;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
            SoundFactory.Instance.backgroundMusic.Pause();
            SoundFactory.Instance.undertaleMusic.Play();
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
