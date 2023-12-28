using Sprint2_Attempt3.Dungeon.Doors;
using System;
using System.IO;

namespace Sprint2_Attempt3.Dungeon
{
    public class RandomRoomCreator
    {
        private static RandomRoomCreator instance = new RandomRoomCreator();
        private static int currentRoomNumber;
        private RandomRoomSpriteCreator randRoomSpriteCreator = new RandomRoomSpriteCreator();

        public static RandomRoomCreator Instance
        {
            get
            {
                return instance;
            }
        }
        public RandomRoomCreator() 
        {
            currentRoomNumber = 0;
        }

        public int CreateRandomRoom(IRoom[,] map, int currentX, int currentY)
        {
            currentRoomNumber++;
            String fileName = "Dungeon/RoomFiles/RandomRoom" + currentRoomNumber + ".csv";
            File.WriteAllText(fileName, "");
            String[] objectPlacements = CreateObjectsInRoom();

            for(int i = 0; i < objectPlacements.Length; i++)
            {
                if (objectPlacements[i] != null)
                {
                    File.AppendAllText(fileName, objectPlacements[i] + "\n");
                }
            }

            if (currentX != map.GetLength(0) - 1)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(WestDoor), map[currentX + 1, currentY]));
            else
                File.AppendAllText(fileName, "Door,East,4\n");
            if(currentX != 0)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(EastDoor), map[currentX - 1, currentY]));
            else
                File.AppendAllText(fileName, "Door,West,4\n");
            if(currentY != 0)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(SouthDoor), map[currentX, currentY - 1]));
            else
                File.AppendAllText(fileName, "Door,North,4\n");
            if (currentY != map.GetLength(1) - 1)
                File.AppendAllText(fileName, randRoomSpriteCreator.CheckIfDoorExist(typeof(NorthDoor), map[currentX, currentY + 1]));
            else
                File.AppendAllText(fileName, "Door,South,4\n");

            RoomGenerator.Instance.LoadNewFile(fileName);

            return currentRoomNumber + Globals.NumberOfRooms - 1;
        }

        public String[] CreateObjectsInRoom()
        {
            String[] objectPlacement = randRoomSpriteCreator.CreateRandomRoomPreset();
            objectPlacement = randRoomSpriteCreator.CreateRandomEnemies(objectPlacement);
            
            return objectPlacement;
        }
    }
}
