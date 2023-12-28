using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class WestDoorCollisionBlock : IWall
    {
        public bool EnemyWalkable { get; } = false;
        public bool projectilesThrowable { get; } = false;
        Rectangle wall;
        public WestDoorCollisionBlock()
        {
            wall = new Rectangle(750, 0 + Globals.YOffset, 50, 550);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
