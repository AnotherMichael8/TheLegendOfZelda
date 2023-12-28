using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class EastDoor : DoorSecondary
    {
        private static Rectangle OpenEastDoor = new Rectangle(259, 68, 31, 30); 
        public EastDoor(int state){
            Position = new Rectangle(700, 227 + Globals.YOffset, 100, 94); 
            sourceRectangle = OpenEastDoor;
            sprite = DungeonSpriteFactory.Instance.CreateEastDoorSprite();
            actions[state].Invoke();
        }
        public override Rectangle GetHitBox()
        {
            if (IsWalkable)
            {
                return new Rectangle(Position.X + 50, Position.Y, Position.Width - 50, Position.Height);
            }
            else
            {
                return Position;
            }
        }
    }
}
