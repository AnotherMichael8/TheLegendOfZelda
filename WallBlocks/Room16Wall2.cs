using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall2 : IWall
    {
        public bool EnemyWalkable { get; } = true;
        public bool projectilesThrowable { get; } = true;
        Rectangle wall;
        public Room16Wall2()
        {
            //wall = new Rectangle(200, 277 + Globals.YOffset, 352, 53);
            wall = new Rectangle(215, Globals.YOffset, 498, 225);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
