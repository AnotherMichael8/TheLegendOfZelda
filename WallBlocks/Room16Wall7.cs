using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall7 : IWall
    {
        Rectangle wall;
        public bool EnemyWalkable { get; } = true;
        public bool projectilesThrowable { get; } = true;
        public Room16Wall7()
        {
            wall = new Rectangle(0, 0 + Globals.YOffset, 100, 550);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
