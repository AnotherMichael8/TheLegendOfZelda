using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.Block;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Portal;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sprint2_Attempt3.WallBlocks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class RoomGenerator
    {

        private static RoomGenerator instance = new RoomGenerator();
        private static List<String> fileNames = new List<String>(Globals.NumberOfRooms);
        private static Dictionary<String, Func<int, int, IEnemy>> AddEnemyFunctions = new Dictionary<string, Func<int, int, IEnemy>> {
        };

        public static RoomGenerator Instance
        {
            get
            {
                return instance;
            }
        }
        public RoomGenerator()
        {
        }
        public void LoadAllFiles() {
            for (int i = 0; i < Globals.NumberOfRooms; i++)
            {
                fileNames.Add("Dungeon/RoomFiles/Room" + (i + 1) + ".csv");
            }
        }
        public void LoadNewFile(String newFile)
        {
            fileNames.Add(newFile);
        }

        public List<IGameObject> LoadFile(int fileNumber) {
            List<IGameObject> objectList = new List<IGameObject>();
            List<IGameObject> enemyList = new List<IGameObject>();

            StreamReader sr = new StreamReader(fileNames[fileNumber]);
            while (!sr.EndOfStream) {
                var line = sr.ReadLine();
                if (line != null)
                {
                    var words = line.Split(",");
                    if (words[0].Equals("Enemy")) {
                        //enemyList.Add(GetEnemy(words[1], int.Parse(words[2]), int.Parse(words[3]) + Globals.YOffset));
                        if (words[3].Length > 0)
                        {

                        objectList.Add(GetEnemy(words[1], int.Parse(words[2]), int.Parse(words[3]) + Globals.YOffset));
                        }
                        else
                        {
                        objectList.Add(GetEnemy(words[1], int.Parse(words[2])));

                        }
                    }
                    else if (words[0].Equals("Block"))
                    {
                        objectList.Add(GetBlock(words[1], int.Parse(words[2])));
                    }
                    else if (words[0].Equals("Item"))
                    {
                        if (words[3].Length > 0)
                            objectList.Add(GetItem(words[1], new Vector2(int.Parse(words[2]), int.Parse(words[3]) + Globals.YOffset), bool.Parse(words[4])));
                        else
                            objectList.Add(GetItem(words[1], int.Parse(words[2]), bool.Parse(words[4])));

                    }
                    else if (words[0].Equals("Door"))
                    {
                        objectList.Add(GetDoor(words[1], int.Parse(words[2])));
                    }
                    else if (words[0].Equals("Portal"))
                    {
                        IGameObject[] portals = GetPortal(int.Parse(words[1]), int.Parse(words[2]));
                        objectList.Add(portals[0]);
                        objectList.Add(portals[1]);
                    }

                }
            }
            List<List<IGameObject>> lists = new List<List<IGameObject>>();
            lists.Add(objectList);
            lists.Add(enemyList);
            return objectList;
           // return lists;
        }
        private IEnemy GetEnemy(String Enemy, int position)
        {
            int x = Globals.FloorGrid[position].X;
            int y = Globals.FloorGrid[position].Y;
            return GetEnemy(Enemy, x, y);
        }
        private IEnemy GetEnemy(String Enemy, int x, int y)
        {
            IEnemy enemy = null;
            if (Enemy.Equals("Aquamentus"))
            {
                enemy = new Aquamentus(x, y);
            }
            else if (Enemy.Equals("Dodongo"))
            {
                enemy = new Dodongo(x, y);
            }
            else if (Enemy.Equals("Gel"))
            {
                enemy = new Gel(x, y);
            }
            else if (Enemy.Equals("Goriya"))
            {
                enemy = new Goriya(x, y);
            }
            else if (Enemy.Equals("Hand"))
            {
                enemy = new Hand(x, y);
            }
            else if (Enemy.Equals("Keese"))
            {
                enemy = new Keese(x, y);
            }
            else if (Enemy.Equals("Rope"))
            {
                enemy = new Rope(x, y);
            }
            else if (Enemy.Equals("SpikeTrap"))
            {
                enemy = new SpikeTrap(x, y);
            }
            else if (Enemy.Equals("Stalfos"))
            {
                enemy = new Stalfos(x, y);
            }
            else if (Enemy.Equals("Zol"))
            {
                enemy = new Zol(x, y);
            }
            return enemy;
        }
        private static IBlock GetBlock(String Block, int position)
        {
            IBlock block = null;
            if (Block.Equals("BlackBlock"))
            {
                block = new BlackBlock(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("BlueTile"))
            {
                block = new BlueTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("DotTile"))
            {
                block = new DotTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("PlainTile"))
            {
                block = new PlainTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("SideChunk"))
            {
                block = new SideChunk(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("UpChunk"))
            {
                block = new UpChunk(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("WhiteBrick"))
            {
                block = new WhiteBrick(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("WhiteStaircase"))
            {
                block = new WhiteStair(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("DiamondTile"))
            {
                block = new DiamondTile(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("FireBlock"))
            {
                block = new FireBlock(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("BlackFloor"))
            {
                block = new BlackFloor(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("OldMan"))
            {
                block = new OldMan(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("MovingBlock"))
            {
                block = new MovingBlock(Globals.FloorGrid[position]);
            }
            else if (Block.Equals("Room9MovingBlock"))
            {
                block = new Room9MovingBlock(Globals.FloorGrid[position]);
            }
            return block;
        }

        private IItem GetItem(String Item, Vector2 position, bool spawned)
        {
            IItem item = null;
            if (Item.Equals("Arrow"))
            {
                item = new Arrow(position, spawned);
            }
            else if (Item.Equals("BlueCandle"))
            {
                item = new BlueCandle(position, spawned);
            }
            else if (Item.Equals("BluePotion"))
            {
                item = new BluePotion(position, spawned);
            }
            else if (Item.Equals("Bomb"))
            {
                item = new Bomb(position, spawned);
            }
            else if (Item.Equals("Boomerang"))
            {
                item = new Boomerang(position, spawned);
            }
            else if (Item.Equals("Bow"))
            {
                item = new Bow(position, spawned);
            }
            else if (Item.Equals("Clock"))
            {
                item = new Clock(position, spawned);
            }
            else if (Item.Equals("Compass"))
            {
                item = new Compass(position, spawned);
            }
            else if (Item.Equals("Fairy"))
            {
                item = new Fairy(position, spawned);
            }
            else if (Item.Equals("HeartContainer"))
            {
                item = new HeartContainer(position, spawned);
            }
            else if (Item.Equals("Heart"))
            {
                item = new Heart(position, spawned);
            }
            else if (Item.Equals("Key"))
            {
                item = new Key(position, spawned);
            }
            else if (Item.Equals("Map"))
            {
                item = new Map(position, spawned);
            }
            else if (Item.Equals("Rupee"))
            {
                item = new Rupee(position, spawned);
            }
            else if (Item.Equals("Triforce"))
            {
                item = new TriforcePiece(position, spawned);
            }
            return item;
        }
        private IItem GetItem(String item, int position, bool spawned)
        {
            int x = Globals.FloorGrid[position].X + 12;
            int y = Globals.FloorGrid[position].Y;
            return GetItem(item, new Vector2(x,y), spawned);
        }
        private IDoor GetDoor(String Door, int state) {
            IDoor door = null;
            if (Door.Equals("North"))
            {
                door = new NorthDoor(state);
            }
            else if (Door.Equals("South"))
            {
                door = new SouthDoor(state);
            }
            else if (Door.Equals("East"))
            {
                door = new EastDoor(state);
            }
            else if (Door.Equals("West"))
            {
                door = new WestDoor(state);
            }
            else if (Door.Equals("StairExit"))
            {
                door = new StairExit(state);
            }
            else if (Door.Equals("StairEntrance"))
            {
                door = new StairEntrance(state);
            }
            return door;
        }

        private static Portal.Portal[] GetPortal(int positionPortal1, int positionPortal2)
        {
            Portal.Portal portal1 = new Portal.Portal(Globals.FloorGrid[positionPortal1], null);
            Portal.Portal portal2 = new Portal.Portal(Globals.FloorGrid[positionPortal2], portal1);
            portal1.LinkedPortal = portal2;
            return new Portal.Portal[] { portal1, portal2 };
        }
    }
}
