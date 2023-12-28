using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class NorthWestCollisionBlock : IWall
    {
        public bool EnemyWalkable { get; } = false;
        public bool projectilesThrowable { get; } = false;
        Rectangle wall;
        public NorthWestCollisionBlock()
        {
            wall = new Rectangle(453, 0 + Globals.YOffset, 347, 75);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
