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
    public class UpAttackLinkSwordSprite : ILinkProjectileSprite
    {
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public UpAttackLinkSwordSprite(Texture2D linkTexture)
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
            //+5 x, -12 y
            destinationRectangle = new Rectangle((int)location.X + 7, (int)location.Y - 15, 15, 15);

            if (currentFrame >= 7 && currentFrame < 15)
            {
                destinationRectangle = new Rectangle((int)location.X + 17, (int)location.Y - 33, 9, 33);
                sourceRectangle = new Rectangle(23, 97, 3, 11);
            }
            else if (currentFrame >= 15 && currentFrame < 22)
            {
                destinationRectangle = new Rectangle((int)location.X + 17, (int)location.Y - 21, 9, 21);
                sourceRectangle = new Rectangle(40, 98, 3, 7);
            }
            else if (currentFrame >= 22 && currentFrame < 30)
            {
                destinationRectangle = new Rectangle((int)location.X + 17, (int)location.Y - 9, 9, 9);
                sourceRectangle = new Rectangle(57, 106, 3, 3);
            }
            else if (currentFrame >= 0 && currentFrame < 7)
            {
                destinationRectangle = new Rectangle((int)location.X + 17, (int)location.Y, 0, 0);
                sourceRectangle = new Rectangle(1, 63, 0, 0);
            }

            spritebatch.Draw(linkTexture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
