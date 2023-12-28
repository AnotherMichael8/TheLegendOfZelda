using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall1 : IWall
    {
        public bool EnemyWalkable { get; } = true;

        public bool projectilesThrowable { get; } = true;

        Rectangle wall;
        public Room16Wall1()
        {
            wall = new Rectangle(605, 254 + Globals.YOffset+15, 97, 125);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
