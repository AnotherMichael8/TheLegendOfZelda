using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class SwordBeamSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private Texture2D texture;
        private int currentFrame;
        public SwordBeamSprite(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            Rectangle sourceRectangle = srcRec;
            if (currentFrame % 8 < 2)
            {
                sourceRectangle = new Rectangle(srcRec.X, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if(currentFrame % 8 < 4) 
            {
                sourceRectangle = new Rectangle(srcRec.X + 35, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if(currentFrame % 8 < 6)
            {
                sourceRectangle = new Rectangle(srcRec.X + 35*2, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if(currentFrame % 8 < 8)
            {
                sourceRectangle = new Rectangle(srcRec.X + 35*3, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            spritebatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White, 0, new Vector2(0), flip, 0);
        }
    }
}
