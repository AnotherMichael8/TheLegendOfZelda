using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Dungeon.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public class RandomRoomSpriteCreator
    {
        private readonly string[] specialPreset1 = { "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,15", "Block,BlueTile,16", "Block,BlueTile,17", "Block,BlueTile,29", "Block,BlueTile,30", "Block,BlueTile,42", "Block,BlueTile,43", "Block,BlueTile,55", "Block,BlueTile,56", "Block,BlueTile,68", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly string[] normalPreset1 = { "Block,DiamondTile,14", "Block,DiamondTile,62", "Block,DiamondTile,23", "Block,DiamondTile,71" };
        private readonly string[] normalPreset8 = { "Block,DiamondTile,27", "Block,DiamondTile,34", "Block,DiamondTile,51", "Block,DiamondTile,58" };
        private readonly string[] specialPreset2 = { "Block,MovingBlock,45", "Block,DiamondTile,19", "Block,DiamondTile,32", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,54", "Block,DiamondTile,41", "Block,DiamondTile,30", "Item,Rupee,43" };
        private readonly string[] normalPreset2 = { "Block,DiamondTile,30", "Block,DiamondTile,31", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,54", "Block,DiamondTile,55", };
        private readonly string[] specialPreset3 = { "Block,DiamondTile,3", "Block,DiamondTile,14", "Block,DiamondTile,18", "Block,DiamondTile,29", "Block,DiamondTile,40", "Block,DiamondTile,51", "Block,DiamondTile,62", "Block,DiamondTile,73", "Block,DiamondTile,12", "Block,DiamondTile,23", "Block,DiamondTile,34", "Block,DiamondTile,45", "Block,DiamondTile,56", "Block,DiamondTile,67", "Block,DiamondTile,82", "Block,DiamondTile,71" };
        private readonly string[] specialPreset4 = { "Item,Rupee,18", "Item,Rupee,19", "Item,Rupee,29", "Item,Rupee,40", "Item,Rupee,53", "Item,Rupee,66", "Item,Rupee,67", "Item,Rupee,56", "Item,Rupee,45", "Item,Rupee,32", "Item,Rupee,30", "Item,Rupee,31", "Item,Rupee,41", "Item,Rupee,42", "Item,Rupee,43", "Item,Rupee,44", "Item,Rupee,54", "Item,Rupee,55" };
        private readonly string[] normalPreset3 = { "Block,DiamondTile,17", "Block,DiamondTile,20", "Block,DiamondTile,46", "Block,DiamondTile,68", "Block,DiamondTile,65", "Block,DiamondTile,39" };
        private readonly string[] normalPreset4 = { "Block,DiamondTile,14", "Block,DiamondTile,15", "Block,DiamondTile,22", "Block,DiamondTile,23", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,62", "Block,DiamondTile,63", "Block,DiamondTile,70", "Block,DiamondTile,71" };
        private readonly string[] sepcialPreset5 = { "Portal,25,60", "Block,BlueTile,1", "Block,BlueTile,2", "Block,BlueTile,3", "Block,BlueTile,13", "Block,BlueTile,14", "Block,BlueTile,26", "Block,BlueTile,38", "Block,BlueTile,50", "Block,BlueTile,61", "Block,BlueTile,62", "Block,BlueTile,73", "Block,BlueTile,74", "Block,BlueTile,63", "Block,BlueTile,64", "Block,BlueTile,75", "Block,BlueTile,76", "Block,BlueTile,17", "Block,BlueTile,28", "Block,BlueTile,29", "Block,BlueTile,40", "Block,BlueTile,41", "Block,BlueTile,20", "Block,BlueTile,32", "Block,BlueTile,33", "Block,BlueTile,44", "Block,BlueTile,45", "Block,BlueTile,54", "Block,BlueTile,55", "Block,BlueTile,10", "Block,BlueTile,11", "Block,BlueTile,12", "Block,BlueTile,23", "Block,BlueTile,24", "Block,BlueTile,35", "Block,BlueTile,47", "Block,BlueTile,59", "Block,BlueTile,69", "Block,BlueTile,70", "Block,BlueTile,71", "Block,BlueTile,72", "Block,BlueTile,81", "Block,BlueTile,82", "Block,BlueTile,83", "Block,BlueTile,84" };
        private readonly string[] normalPreset5 = { "Block,DiamondTile,41", "Block,DiamondTile,44" };
        private readonly string[] normalPreset6 = { "Block,MovingBlock,38", "Block,MovingBlock,47", "Block,DiamondTile,64", "Block,DiamondTile,69" };
        private readonly string[] normalPreset7 = { "Block,DiamondTile,27", "Block,MovingBlock,38", "Block,DiamondTile,51", "Block,DiamondTile,34", "Block,MovingBlock,47", "Block,DiamondTile,58" };
        private readonly string[] normalPreset9 = { "Block,DiamondTile,3", "Block,DiamondTile,15", "Block,DiamondTile,10", "Block,DiamondTile,22", "Block,DiamondTile,63", "Block,DiamondTile,75", "Block,DiamondTile,70", "Block,DiamondTile,82", "Portal,1,84" };
        private readonly string[] specialPreset6 = { "Block,DiamondTile,1", "Block,DiamondTile,2", "Block,DiamondTile,3", "Block,DiamondTile,4", "Block,DiamondTile,5", "Block,DiamondTile,8", "Block,DiamondTile,9", "Block,DiamondTile,10", "Block,DiamondTile,11", "Block,DiamondTile,12", "Block,DiamondTile,13", "Block,DiamondTile,14", "Block,DiamondTile,15", "Block,DiamondTile,16", "Block,DiamondTile,17", "Block,DiamondTile,20", "Block,DiamondTile,21", "Block,DiamondTile,22", "Block,DiamondTile,23", "Block,DiamondTile,24", "Block,DiamondTile,25", "Block,DiamondTile,26", "Block,DiamondTile,27", "Block,DiamondTile,34", "Block,DiamondTile,35", "Block,DiamondTile,36", "Block,DiamondTile,49", "Block,DiamondTile,50", "Block,DiamondTile,51", "Block,DiamondTile,58", "Block,DiamondTile,59", "Block,DiamondTile,60", "Block,DiamondTile,61", "Block,DiamondTile,62", "Block,DiamondTile,63", "Block,DiamondTile,64", "Block,DiamondTile,65", "Block,DiamondTile,68", "Block,DiamondTile,69", "Block,DiamondTile,70", "Block,DiamondTile,71", "Block,DiamondTile,72", "Block,DiamondTile,73", "Block,DiamondTile,74", "Block,DiamondTile,75", "Block,DiamondTile,76", "Block,DiamondTile,77", "Block,DiamondTile,80", "Block,DiamondTile,81", "Block,DiamondTile,82", "Block,DiamondTile,83", "Block,DiamondTile,84" };
        private readonly string[] normalPreset10 = { "Block,DiamondTile,15", "Block,DiamondTile,16", "Block,DiamondTile,27", "Block,DiamondTile,28", "Block,DiamondTile,57", "Block,DiamondTile,58", "Block,DiamondTile,69", "Block,DiamondTile,70" };
        private readonly string[] specialPreset7 = { "Block,DiamondTile,4", "Block,DiamondTile,16", "Block,DiamondTile,9", "Block,DiamondTile,21", "Block,DiamondTile,25", "Block,DiamondTile,26", "Block,DiamondTile,27", "Block,DiamondTile,28", "Block,DiamondTile,33", "Block,DiamondTile,34", "Block,DiamondTile,35", "Block,DiamondTile,36", "Block,DiamondTile,40", "Block,DiamondTile,41", "Block,DiamondTile,42", "Block,DiamondTile,43", "Block,DiamondTile,44", "Block,DiamondTile,45", "Block,DiamondTile,49", "Block,DiamondTile,50", "Block,DiamondTile,51", "Block,DiamondTile,52", "Block,DiamondTile,57", "Block,DiamondTile,58", "Block,DiamondTile,59", "Block,DiamondTile,60", "Block,DiamondTile,64", "Block,DiamondTile,69", "Block,DiamondTile,76", "Block,DiamondTile,81", "Portal,39,12", "Portal,10,53", "Portal,56,61", "Portal,63,29", "Portal,32,70", "Portal,72,13", "Portal,15,46" };
        private readonly string[][] normalRoomPresetList;
        private readonly string[][] specialRoomPresetList;
        private readonly string[] enemies = { "Enemy,Zol,", "Enemy,Keese,", "Enemy,Gel,", "Enemy,Rope,", "Enemy,Goriya,", "Enemy,Stalfos,", "Enemy,Dodongo," };
        private readonly int[] noSpawnAreas = { 6, 7, 25, 36, 37, 38, 47, 48, 49, 60, 78, 79 };
        public RandomRoomSpriteCreator() 
        {
            normalRoomPresetList =  new string[][]{normalPreset1, normalPreset2, normalPreset3, normalPreset4, normalPreset5, normalPreset6, normalPreset7, normalPreset8, normalPreset9, normalPreset10, new string[] { } };
            specialRoomPresetList = new string[][] { specialPreset1, specialPreset2, specialPreset3, specialPreset4, sepcialPreset5, specialPreset6, specialPreset7 };

        }

        public string[] CreateRandomRoomPreset()
        {
            string[] objectPlacement = new string[84];

            int randDiffAmountBlock = new Random().Next(2, 4);
            bool spawnSpecialRoom = new Random().Next(0, 6) == 4;

            string[] roomPreset;

            if(spawnSpecialRoom)
            {
                int randBlockPresets = new Random().Next(0, specialRoomPresetList.Length);
                roomPreset = specialRoomPresetList[randBlockPresets];
                randDiffAmountBlock = 1;
            }
            else
            {
                int randBlockPresets = new Random().Next(0, normalRoomPresetList.Length);
                roomPreset = normalRoomPresetList[randBlockPresets];
            }
            for (int i = 0; i < randDiffAmountBlock; i++)
            {
                for (int c = 0; c < roomPreset.Length; c++)
                {
                    //Gets to integer position stated in the string and turns it into a integer
                    int value = roomPreset[c].LastIndexOf(',') + 1;
                    int blockPosition = int.Parse(roomPreset[c].Substring(roomPreset[c].LastIndexOf(',') + 1)) - 1;
                    objectPlacement[blockPosition] = roomPreset[c] + ",,";
                    if (roomPreset[c].Substring(0, roomPreset[c].IndexOf(",")).Equals("Item"))
                        objectPlacement[blockPosition] += "TRUE";
                }
                int randBlockPresets = new Random().Next(0, normalRoomPresetList.Length);
                roomPreset = normalRoomPresetList[randBlockPresets];
            }
            return objectPlacement;
        }

        public string[] CreateRandomEnemies(string[] objectPlacement)
        {
            int randDiffAmountEnemies = new Random().Next(2, 4);
            string enemyCSV = "";

            for (int i = 0; i < randDiffAmountEnemies; i++)
            {
                int randEnemies = new Random().Next(0, 7);
                int randAmountEnemies = new Random().Next(1, 4);
                enemyCSV = enemies[randEnemies];
                //Spawns one dodongo
                 if (randEnemies == 6)
                    randAmountEnemies = 1;

                for (int c = 0; c < randAmountEnemies; c++)
                {
                    int randPositionEnemy;
                    do
                    {
                        randPositionEnemy = new Random().Next(0, 84);
                    }
                    while (noSpawnAreas.Contains(randPositionEnemy + 1) || objectPlacement[randPositionEnemy] != null);

                    objectPlacement[randPositionEnemy] = enemyCSV + (randPositionEnemy + 1) + ",,";
                }
            }

            return objectPlacement;
        }

        public string CheckIfDoorExist(Type typeDoor, IRoom room)
        {
            string doorCSV = "";
            if (typeDoor.IsAssignableFrom(typeof(WestDoor)))
                doorCSV = "Door,East,4";
            else if (typeDoor.IsAssignableFrom(typeof(EastDoor)))
                doorCSV = "Door,West,4";
            else if (typeDoor.IsAssignableFrom(typeof(SouthDoor)))
                doorCSV = "Door,North,4";
            else
                doorCSV = "Door,South,4";

            if (room != null)
            {
                foreach (IGameObject obj in room.gameObjectList)
                {
                    if (obj.GetType().Equals(typeDoor) && ((IDoor)obj).DoorExists)
                    {
                        doorCSV = doorCSV.Substring(0, doorCSV.Length - 1) + "0";
                    }
                }
            }
            else
            {
                int randNum = new Random().Next(0, 1);
                if (randNum == 0)
                    doorCSV = doorCSV.Substring(0, doorCSV.Length - 1) + "0";
            }
            return doorCSV + "\n";

        }
    }
}
