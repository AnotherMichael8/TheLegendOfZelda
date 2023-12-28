using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.WallBlocks;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room16 : RoomSecondary
    {
        public Room16(Game1 game1) : base(game1, 15) 
        {
            roomLayout[4, 7] = this;
            room = new WhiteStairRoom();
            foreach (IWall wall in IWall.Room16WallBlocks) {
                gameObjectList.Add(wall);
            }
        }

        public override void SwitchToUpperRoom()
        {
            mapY -= 1;
            SwitchRoom(mapX, mapY, FadingTransitionHandler.Instance);
        }

    }
}
