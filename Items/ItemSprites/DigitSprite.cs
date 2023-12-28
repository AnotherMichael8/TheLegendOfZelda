using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemSprites
{
    internal class DigitSprite : IAnimatedItemSprite
    {
        private Texture2D texture;
        public DigitSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle position, Rectangle sourceRectangle)
        {
            spriteBatch.Draw(
                    texture,
                    position,
                    sourceRectangle,
                    Color.White,
                    0f,
                    new Vector2(0, 0),
                    SpriteEffects.None,
                    0f
           );
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle position) { }
    }
}
