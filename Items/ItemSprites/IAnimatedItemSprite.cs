using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items.ItemSprites;

namespace Sprint2_Attempt3.Items
{
    public interface IAnimatedItemSprite : IItemSprite
    {
        void Draw(SpriteBatch spriteBatch, Rectangle position, Rectangle sourceRectangle);
    }
}
