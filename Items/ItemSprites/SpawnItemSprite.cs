using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemSprites
{
    public class SpawnItemSprite : IAnimatedItemSprite
    {
        private Texture2D texture;
        private static int count;
        public SpawnItemSprite(Texture2D texture)
        {
            this.texture = texture;
            count = 25;
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle position, Rectangle sourceRectangle)
        {
            if (count % 5 == 0)
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
            count--;
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle position) { }
    }
}