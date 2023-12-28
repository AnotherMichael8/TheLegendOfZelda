using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class BlackFloorBig : BlockSecondary
    {
        private Rectangle BlackFloorScr = new Rectangle(1, 18, 14, 14);
        public BlackFloorBig(Rectangle Position)
        {
            position = new Rectangle(Position.X, Position.Y, 599, 352);
            sourceRectangle = BlackFloorScr;
            isWalkable = true;
        }
    }
}
