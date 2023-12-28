using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks.Block
{
    internal class FireBlock : BlockSecondary
    {
        private Rectangle src = new Rectangle(34,34,16,16);
        private int count;
        public FireBlock(Rectangle Position)
        {
            position = Position;
            sourceRectangle = src;
            isWalkable = false;
            count = 0;
        }

        public override void Draw(SpriteBatch spriteBatch, Color color)
        {
            count++;
            if (count < 5) {
                spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, position, sourceRectangle, color);
            }
            else if (count < 10) {
                spriteBatch.Draw(
                    BlockSpriteFactory.Instance.blocks,
                    position,
                    sourceRectangle,
                    color,
                    0f,
                    new Vector2(0, 0),
                    SpriteEffects.FlipHorizontally,
                    0f
                );
            }
            else {
                count = 0;
            }
        }
    }
}
