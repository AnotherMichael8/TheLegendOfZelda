using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class LeftAttackLinkSwordSprite : ILinkProjectileSprite
    {
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public LeftAttackLinkSwordSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(1, 47, 15, 15);
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame >= 30)
            {
                currentFrame = 0;
            }
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            //+16 x, +8 y
            destinationRectangle = new Rectangle((int)location.X + -15, (int)location.Y + 24, 15, 15);

            if (currentFrame >= 7 && currentFrame < 15)
            {
                destinationRectangle = new Rectangle((int)location.X - 33, (int)location.Y + 24, 36, 9);
                sourceRectangle = new Rectangle(34, 85, 12, 3);
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                destinationRectangle = new Rectangle((int)location.X - 21, (int)location.Y + 24, 27, 9);
                sourceRectangle = new Rectangle(60, 85, 9, 3);
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                destinationRectangle = new Rectangle((int)location.X - 9, (int)location.Y + 24, 12, 9);
                sourceRectangle = new Rectangle(85, 85, 4, 3);
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y + 24, 0, 0);
                sourceRectangle = new Rectangle(1, 47, 0, 0);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipHorizontally, 0);
        }
    }
}
