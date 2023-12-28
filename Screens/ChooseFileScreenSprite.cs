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
    public class ChooseFileScreenSprite : IScreenSprite
    {
        private Texture2D screenTexture;
        private Texture2D selectorTexture;
        private Rectangle screenSourceRectangle;
        private Rectangle screenDestinationRectangle;
        private Rectangle selectorSourceRectangle;
        private Rectangle[] selectorDestinationRectangles;
        private int selectorPosition;
        public ChooseFileScreenSprite(Texture2D screenTexture, Texture2D selectorTexture)
        {
            this.screenTexture = screenTexture;
            this.selectorTexture = selectorTexture;
            screenSourceRectangle = new Rectangle(638, 220, 300, 173);
            screenDestinationRectangle = new Rectangle(0, 0, 1060, 750);
            selectorSourceRectangle = new Rectangle(52, 230, 8, 8);
            selectorDestinationRectangles = new Rectangle[] { new Rectangle(135, 600, 24, 24), new Rectangle(395, 600, 24, 24), new Rectangle(655, 600, 24, 24) };
        }
        public void Update() { }
        public void MoveSelectorUp() { }
        public void MoveSelectorDown() { }
        public void MoveSelectorLeft() 
        {
            if (selectorPosition != 0)
                selectorPosition--;
            else
                selectorPosition = selectorDestinationRectangles.Length - 1;
        }
        public void MoveSelectorRight()
        {
            if (selectorPosition != selectorDestinationRectangles.Length - 1)
                selectorPosition++;
            else
                selectorPosition = 0;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(screenTexture, screenDestinationRectangle, screenSourceRectangle, Color.White);
            spriteBatch.Draw(selectorTexture, selectorDestinationRectangles[selectorPosition], selectorSourceRectangle, Color.White);
        }

    }
}
