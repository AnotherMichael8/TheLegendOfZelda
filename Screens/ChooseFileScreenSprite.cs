using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.Screens
{
    public class ChooseFileScreenSprite : IScreenSprite
    {
        private Texture2D screenTexture;
        private Texture2D selectorTexture;      
        private Rectangle screenSourceRectangle;
        private Rectangle screenDestinationRectangle;
        private Rectangle selectorSourceRectangle;
        
        public ChooseFileScreenSprite(Texture2D screenTexture, Texture2D selectorTexture)
        {
            this.screenTexture = screenTexture;
            this.selectorTexture = selectorTexture; 
            screenSourceRectangle = new Rectangle(638, 220, 300, 173);
            screenDestinationRectangle = new Rectangle(0, 0, 1060, 750);
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
