using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class SouthDoor : DoorSecondary
    {
        private static Rectangle OpenSouthDoor = new Rectangle(259, 100, 30, 32); 
        public SouthDoor(int state){
            Position = new Rectangle(348, 450 + Globals.YOffset, 105, 100);
            sourceRectangle = OpenSouthDoor;
            sprite = DungeonSpriteFactory.Instance.CreateSouthDoorSprite();
            actions[state].Invoke();
        }
        public override Rectangle GetHitBox()
        {
            if (IsWalkable)
            {
                return new Rectangle(Position.X, Position.Y + 50, Position.Width, Position.Height - 50);
            }
            else {
                return Position;
            }
        }
    }
}
