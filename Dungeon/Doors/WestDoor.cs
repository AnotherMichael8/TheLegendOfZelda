using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class WestDoor : DoorSecondary
    {
        public static Rectangle OpenWestDoor = new Rectangle(259, 35, 31, 30); 
        public WestDoor(int state){
            Position = new Rectangle(0, 227 + Globals.YOffset, 100, 94);
            sourceRectangle = OpenWestDoor;
            sprite = DungeonSpriteFactory.Instance.CreateWestDoorSprite();
            actions[state].Invoke();
        }

        public override Rectangle GetHitBox()
        {
            if (IsWalkable)
            {
                return new Rectangle(Position.X, Position.Y, Position.Width - 50, Position.Height);
            }
            else
            {
                return Position;
            }
        }
    }
}
