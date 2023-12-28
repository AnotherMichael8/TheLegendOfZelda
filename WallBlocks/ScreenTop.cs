using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class ScreenTop : IWall
    {
        public bool EnemyWalkable { get; } = false;
        public bool projectilesThrowable { get; } = false;
        Rectangle wall;
        public ScreenTop()
        {
            wall = new Rectangle(0, Globals.YOffset - 50, Globals.ScreenWidth, 50);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
