using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class DeadLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public DeadLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(39, 19, 15, 16);
            currentFrame = 0;
        }
        public void Update()
        {
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 15 * 3, 16 * 3);
            if (currentFrame == 6)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 12)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 18)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 24)
            {
                currentFrame = 24;
                sourceRectangle = new Rectangle(0, 0, 0, 0);
            }
            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
