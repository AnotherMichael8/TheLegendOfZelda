using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class RightAttackLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public RightAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 77, 15, 15);
            currentFrame = 0;

        }
        public void Update()
        {
            currentFrame++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 48);

            if (currentFrame >= 5 && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(18, 77, 15, 16);
            }
            else if (currentFrame >= 10 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(46, 77, 15, 16);
            }
            else if (currentFrame >= 15 && currentFrame < 20)
            {
                sourceRectangle = new Rectangle(70, 77, 15, 16);
            }
            else if (currentFrame >= 0 && currentFrame < 5)
            {
                sourceRectangle = new Rectangle(1, 77, 15, 16);
            }

            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);
        }
    }
}
