using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class EastNorthCollisionBlock : IWall
    {
        public bool projectilesThrowable { get; } = false;
        public bool EnemyWalkable { get; } = false;
        Rectangle wall;
        public EastNorthCollisionBlock()
        {
            wall = new Rectangle(700, 0 + Globals.YOffset, 100, 227);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
