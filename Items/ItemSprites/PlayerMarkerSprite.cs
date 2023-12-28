using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemSprites
{
    internal class PlayerMarkerSprite : IItemSprite
    {
        private Texture2D texture;
        public PlayerMarkerSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle position) {
            spriteBatch.Draw(
                texture,
                position,
                new Rectangle(266, 140, 3, 3),
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
           );
        }

    }
}
