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
    public class BombExplosionSprite : ILinkProjectileSprite
    {
        private Texture2D texture;
        private int currentFrame;
        private Rectangle desRecTopLeft;
        private Rectangle desRecTopRight;
        private Rectangle desRecMiddleLeft;
        private Rectangle desRecMiddleRight;
        private Rectangle desRecBottomLeft;
        private Rectangle desRecBottomRight;
        private Rectangle desRecCenter;
        public BombExplosionSprite(Texture2D texture)
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
            desRecTopLeft = new Rectangle((int)location.X - 12 * 3, (int)location.Y - 15 * 3, 45, 45);
            desRecTopRight = new Rectangle((int)location.X + 3 * 3, (int)location.Y - 15 * 3, 45, 45);
            desRecMiddleLeft = new Rectangle((int)location.X - 19 * 3, (int)location.Y, 45, 45);
            desRecMiddleRight = new Rectangle((int)location.X + 9 * 3, (int)location.Y, 45, 45);
            desRecBottomLeft = new Rectangle((int)location.X - 12 * 3, (int)location.Y + 15 * 3, 45, 45);
            desRecBottomRight = new Rectangle((int)location.X + 3 * 3, (int)location.Y + 15 * 3, 45, 45);
            desRecCenter = new Rectangle((int)location.X - 4 * 3, (int)location.Y, 45, 45);
            if (currentFrame >= 0 && currentFrame < 4)
            {
                srcRec = new Rectangle(138, 185, 15, 15);
            }
            else if (currentFrame >= 4 && currentFrame < 7)
            {
                srcRec = new Rectangle(155, 185, 15, 15);
            }
            else
            {
                srcRec = new Rectangle(172, 185, 15, 15);
            }
            spriteBatch.Draw(texture, desRecTopLeft, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecTopRight, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecMiddleLeft, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecMiddleRight, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecBottomLeft, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecBottomRight, srcRec, Color.White);
            spriteBatch.Draw(texture, desRecCenter, srcRec, Color.White);
        }
    }
}
