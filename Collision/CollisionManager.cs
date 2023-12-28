using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System.Security.Cryptography.X509Certificates;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Collision
{
    public class CollisionManager
    {
        public Vector2 LinkPosition { get; private set; }
        private static List<IGameObject> gameObjectList = new List<IGameObject>();
        public ILink linkObj;
        public static List<IGameObject> GameObjectList
        {
            get { return gameObjectList; }
            set { gameObjectList = value; }
        }
        private static int spawnItemCount;
        public static int SpawnItem
        {
            get { return spawnItemCount; }
            set { spawnItemCount = value; }
        }
        private static int spawnItemCountTrigger = 1;
        public static int SpawnItemTrigger { get { return spawnItemCountTrigger; } }
       

        private Game1 game;
        public CollisionManager(Game1 game, ILink link)
        {
            spawnItemCount = 0;
            this.game = game;
            this.linkObj = link;
        }
        public void ManagePlayerCollision()
        {
            for (int c = 0; c < gameObjectList.Count; c++)
            {
                bool ChangedRooms = false;
                IGameObject obj = gameObjectList[c];
                ChangedRooms = CollisionDetector.CheckPlayerCollision(linkObj, obj, game);
                if (ChangedRooms)
                {
                    break;
                }
            }
        }

        public void ManageEnemyCollision()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i] is IEnemy)
                {
                    IEnemy enemy = (IEnemy)gameObjectList[i];
                    for (int c = 0; c < gameObjectList.Count; c++)
                    {
                        IGameObject obj = gameObjectList[c];
                        CollisionDetector.CheckEnemyCollision(enemy, obj, gameObjectList);
                    }
                }
            }
        }

        public void ManageEnemyWallCollision()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i] is IEnemy)
                {
                    foreach (IWall wall in IWall.WallBlocks)
                    {
                        CollisionDetector.CheckEnemyWallCollision(wall, (IEnemy)gameObjectList[i]);
                    }
                }
            }
        }

        public void ManageProjectileCollision()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                IGameObject projectile = gameObjectList[i];
                if (projectile is ILinkProjectile)
                {
                    for (int c = 0; c < gameObjectList.Count; c++)
                    {
                        IGameObject obj = gameObjectList[c];
                        CollisionDetector.CheckLinkProjectileCollision(projectile, obj);
                    }
                }
                else if (projectile is IEnemyProjectile)
                {
                    for (int c = 0; c < gameObjectList.Count; c++)
                    {
                        IGameObject obj = gameObjectList[c];
                        CollisionDetector.CheckEnemyProjectileCollision(projectile, obj);
                    }
                }
            }
        }
        public void AddWallBlocks()
        {
            foreach (IWall wall in IWall.WallBlocks)
                gameObjectList.Add(wall);
        }
        public void Update()
        {
            ManagePlayerCollision();
            ManageEnemyCollision();
            ManageEnemyWallCollision();
            ManageProjectileCollision();
        }
    }

}
