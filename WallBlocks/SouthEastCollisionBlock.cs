using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class SouthEastCollisionBlock : IWall
    {
        public bool EnemyWalkable { get; } = false;
        public bool projectilesThrowable { get; } = false;
        Rectangle wall;
        public SouthEastCollisionBlock()
        {
            wall = new Rectangle(0, 450 + Globals.YOffset, 348, 100);
           
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
