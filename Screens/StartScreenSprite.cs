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
    public class StartScreenSprite : ISprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        public StartScreenSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = new Rectangle(1, 11, 255, 223);
            destinationRectangle = new Rectangle(0, 0, 800, 750);
        }
        public void Update() { }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

    }
}
