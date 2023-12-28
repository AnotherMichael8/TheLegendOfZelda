using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Items.ItemSprites
{
    public interface IItemSprite
    {
        void Draw(SpriteBatch spriteBatch, Rectangle position);
    }
}
