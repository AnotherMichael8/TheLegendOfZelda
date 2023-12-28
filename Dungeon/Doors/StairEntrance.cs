using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    internal class StairEntrance : DoorSecondary
    {
        public StairEntrance(int state){
            Position = Globals.FloorGrid[43];
            sourceRectangle = new Rectangle(51, 17, 16, 16);
            sprite = DungeonSpriteFactory.Instance.CreateStairEntranceSprite();
            actions[state].Invoke();
        }

        public override Rectangle GetHitBox()
        {
            Rectangle hitBox = new Rectangle(Position.X + (Position.Width * 3 / 4), Position.Y, Position.Width / 4, Position.Height);
            return hitBox;
        }
    }
}
