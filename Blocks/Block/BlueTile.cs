using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class BlueTile : BlockSecondary
    {
        private static Rectangle src = new Rectangle(35, 18, 14, 14);
        public BlueTile(Rectangle Position)
        {
            position = Position;
            sourceRectangle = src;
            isWalkable = false;
        }
    }
}
