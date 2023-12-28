using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class BombSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public BombSprite(Texture2D texture)
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

            if (currentFrame >= 0 && currentFrame < 50)
            {
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            else if (currentFrame >= 50 && currentFrame < 54)
            {
                srcRec = new Rectangle(138, 185, 15, 15);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            else if (currentFrame >= 54 && currentFrame < 57)
            {
                srcRec = new Rectangle(155, 185, 15, 15);
            }
            else
            {
                srcRec = new Rectangle(172, 185, 15, 15);
            }
            spriteBatch.Draw(texture, destinationRectangle, srcRec, Color.White);
        }
    }
}
