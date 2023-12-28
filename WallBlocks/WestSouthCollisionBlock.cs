using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    internal class WestSouthCollisionBlock : IWall
    {
        public bool EnemyWalkable { get; } = false;
        public bool projectilesThrowable { get; } = false;
        Rectangle wall;
        public WestSouthCollisionBlock()
        {
            wall = new Rectangle(0, 321 + Globals.YOffset, 100, 229);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
