using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall5 : IWall
    {
        public bool EnemyWalkable { get; } = true;
        public bool projectilesThrowable { get; } = true;
        Rectangle wall;
        public Room16Wall5()
        {
            wall = new Rectangle(705, 0 + Globals.YOffset, 100, 550);
           // wall = new Rectangle(700, 0 + Globals.YOffset, 100, 550);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
