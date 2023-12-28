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
    public class UpAttackLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public UpAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            currentFrame = 0;
            sourceRectangle = new Rectangle(1, 109, 15, 15);
        }
        public void Update()
        {
            currentFrame++;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            if (currentFrame >= 5 && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(18, 109, 15, 15);
            }
            else if (currentFrame >= 10 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(35, 109, 15, 15);
            }
            else if (currentFrame >= 15 && currentFrame < 20)
            {
                sourceRectangle = new Rectangle(52, 109, 15, 15);
            }
            else if (currentFrame >= 0 && currentFrame < 5)
            {
                sourceRectangle = new Rectangle(1, 109, 15, 15);
            }

            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);
        }
    }
}
