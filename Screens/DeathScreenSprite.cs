using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sprint2_Attempt3.Screens
{
    public class DeathScreenSprite : IScreenSprite
    {
        private Texture2D texture;
        private Texture2D selectorTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private Rectangle selectorSourceRectangle;
        public DeathScreenSprite(Texture2D texture, Texture2D selectorTexture)
        {
            this.texture = texture;
            this.selectorTexture = selectorTexture;
            sourceRectangle = new Rectangle(280, 270, 300, 245);
            destinationRectangle = new Rectangle(0, 0, 800, 750);
            selectorSourceRectangle = new Rectangle(52, 230, 8, 8);
        }
        public void Update() { }

        public void Draw(SpriteBatch spriteBatch, Rectangle selectorDestinationRectangle)
        {
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.Draw(selectorTexture, selectorDestinationRectangle, selectorSourceRectangle, Color.White);
        }
    }
}
