using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    public class PauseScreenSprite : IScreenSprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public PauseScreenSprite(Texture2D texture, Texture2D selectorTexture)
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(638, 12, 300, 196);
            destinationRectangle = new Rectangle(0, 0, 1060, Globals.ScreenHeight);
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void MoveSelectorUp()
        {
            throw new NotImplementedException();
        }

        public void MoveSelectorDown()
        {
            throw new NotImplementedException();
        }

        public void MoveSelectorLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveSelectorRight()
        {
            throw new NotImplementedException();
        }
    }
}
