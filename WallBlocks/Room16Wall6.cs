using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall6 : IWall
    {
        Rectangle wall;
        public bool EnemyWalkable { get; } = true;
        //don't think you can have it go through the ground in the game but may be wrong
        public bool projectilesThrowable { get; } = false;
        public Room16Wall6()
        {
            //wall = new Rectangle(0, 443 + Globals.YOffset, 800, 150);
            wall = new Rectangle(0, 404 + Globals.YOffset+40, 800, 150);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
