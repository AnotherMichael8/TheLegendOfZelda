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
    public class LeftAttackLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        public LeftAttackLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            currentFrame = 0;
            //Need to figure out how to make link face left
            sourceRectangle = new Rectangle(1, 76, 15, 15);
        }
        public void Update()
        {
            currentFrame++;
        }

        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)

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

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color, 0, new Vector2(0), SpriteEffects.FlipHorizontally, 0);
        }
    }
}
