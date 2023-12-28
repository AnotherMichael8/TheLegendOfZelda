using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room15 : RoomSecondary
    {
        private TriforcePiece triforce;
        private SouthDoor diamondDoor;
        private bool doorsOpened;
        public Room15(Game1 game1) : base(game1, 14) 
        {
            doorsOpened = false;
            roomLayout[8, 7] = this;
            foreach(IGameObject obj in gameObjectList)
            {
                if(obj is TriforcePiece triforce)
                    this.triforce = triforce;
                else if(obj is SouthDoor diamondDoor)
                    this.diamondDoor = diamondDoor;
            }
        }

        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void RoomConditionCheck()
        {
            if(!doorsOpened && !triforce.exists)
            {
                diamondDoor.Open();
                foreach(IGameObject obj in roomLayout[5,10].gameObjectList)
                {
                    if(obj is EastDoor diffDiamondDoor)
                        diffDiamondDoor.Open();
                }

            }
        }

    }
}
