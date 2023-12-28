using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;
using System.Linq;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room14 : RoomSecondary
    {
        private static bool doorOpen;
        private static Aquamentus aquamentus;
        private static HeartContainer heartContainer;
        private static EastDoor diamondDoor;
        public Room14(Game1 game1) : base(game1, 13) 
        {
            roomLayout[7, 7] = this;
            doorOpen = false;
            foreach (IGameObject obj in gameObjectList)
            {
                if (obj is Aquamentus)
                {
                    aquamentus = (Aquamentus)obj;
                }
                else if (obj is HeartContainer)
                {
                    heartContainer = (HeartContainer)obj;
                }
                else if (obj is EastDoor)
                {
                    diamondDoor = (EastDoor)obj;
                }
            }
        }

        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void RoomConditionCheck()
        {
            if (!doorOpen && !aquamentus.exists)
            {
                diamondDoor.Open();
                heartContainer.Spawn();
                doorOpen = true;
            }
        }

    }
}
