using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall8 : IWall
    {
        Rectangle wall;
        public bool EnemyWalkable { get; } = true;
        public bool projectilesThrowable { get; } = true;
        public Room16Wall8()
        {
           // wall = new Rectangle(0, 0 + Globals.YOffset, 150, 330);
           // wall = new Rectangle(0, 0 + Globals.YOffset, 150, 298);
            wall = new Rectangle(0, 0 + Globals.YOffset, 140, 399);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
