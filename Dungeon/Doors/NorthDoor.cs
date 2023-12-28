using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class NorthDoor : DoorSecondary
    {
        private static Rectangle OpenNorthDoor = new Rectangle(259, 1, 30, 32); 
        public NorthDoor(int state){
            Position = new Rectangle(348, 0 + Globals.YOffset, 105, 100); ;
            sourceRectangle = OpenNorthDoor;
            sprite = DungeonSpriteFactory.Instance.CreateNorthDoorSprite();
            actions[state].Invoke();
        }
        public override Rectangle GetHitBox()
        {
            if (IsWalkable)
            {
                return new Rectangle(Position.X, Position.Y, Position.Width, Position.Height - 50);
            }
            else
            {
                return new Rectangle(Position.X, Position.Y, Position.Width, Position.Height - 25);
            }
        }
    }
}
