using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Sprint2_Attempt3.Screens
{
    public class PauseScreenSprite : IScreenSprite
    {
        private Texture2D screenTexture;
        private Texture2D selectorTexture;
        private Rectangle screenSourceRectangle;
        private Rectangle screenDestinationRectangle;
        private Rectangle selectorSourceRectangle;
        public PauseScreenSprite(Texture2D screenTexture, Texture2D selectorTexture)
        {
            this.screenTexture = screenTexture;
            this.selectorTexture = selectorTexture;
            screenSourceRectangle = new Rectangle(638, 12, 300, 196);
            screenDestinationRectangle = new Rectangle(0, 0, 1060, Globals.ScreenHeight);
            selectorSourceRectangle = new Rectangle(52, 230, 8, 8);
        }
        public void Update() { }
        public void Draw(SpriteBatch spriteBatch, Rectangle selectorDestinationRectangle)
        {
            spriteBatch.Draw(screenTexture, screenDestinationRectangle, screenSourceRectangle, Color.White);
            spriteBatch.Draw(selectorTexture, selectorDestinationRectangle, selectorSourceRectangle, Color.White);
        }
    }
}
