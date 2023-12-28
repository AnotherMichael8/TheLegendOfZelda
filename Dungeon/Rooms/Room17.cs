using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Sounds;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room17 : RoomSecondary
    {
        public Room17(Game1 game1) : base(game1, 16) 
        {
            roomLayout[4, 6] = this;
        }

        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

        public override void SwitchToLowerRoom()
        {
            mapY += 1;
            SoundFactory.PlaySound(SoundFactory.Instance.stairs);
            SwitchRoom(mapX, mapY, FadingTransitionHandler.Instance);
        }
    }
}
