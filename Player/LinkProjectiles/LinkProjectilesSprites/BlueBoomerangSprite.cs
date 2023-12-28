using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sprint2_Attempt3.Player.Link;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class BlueBoomerangSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public BlueBoomerangSprite(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            if (currentFrame % 40 >= 0 && currentFrame % 40 < 5)
            {
                srcRec = new Rectangle(91, 189, 7, 7);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 5 && currentFrame % 40 < 10)
            {
                srcRec = new Rectangle(100, 189, 7, 7);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 10 && currentFrame % 40 < 15)
            {
                srcRec = new Rectangle(109, 189, 7, 7);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 15 && currentFrame % 40 < 20)
            {
                srcRec = new Rectangle(100, 189, 7, 7);
                flip = SpriteEffects.FlipHorizontally;
            }
            else if (currentFrame % 40 >= 20 && currentFrame % 40 < 25)
            {
                srcRec = new Rectangle(91, 189, 7, 7);
                flip = SpriteEffects.FlipHorizontally;
            }
            else if (currentFrame % 40 >= 25 && currentFrame % 40 < 30)
            {
                srcRec = new Rectangle(154, 210, 7, 7);
                flip = SpriteEffects.None;
            }
            else if (currentFrame % 40 >= 30 && currentFrame % 40 < 35)
            {
                srcRec = new Rectangle(109, 189, 7, 7);
                flip = SpriteEffects.FlipVertically;
            }
            else if (currentFrame % 40 >= 35 && currentFrame % 40 < 40)
            {
                srcRec = new Rectangle(100, 189, 7, 7);
                flip = SpriteEffects.FlipVertically;
            }
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            spriteBatch.Draw(texture, destinationRectangle, srcRec, Color.White, 0, new Vector2(0), flip, 0);
        }
    }
}
