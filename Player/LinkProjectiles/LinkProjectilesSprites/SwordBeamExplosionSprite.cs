using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using System.Runtime.CompilerServices;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class SwordBeamExplosionSprite : ILinkProjectileSprite
    {
        private int currentFrame;
        private Texture2D texture;
        public Rectangle ArrowCollisionRectangle { get; private set; }
        public SwordBeamExplosionSprite(Texture2D texture)
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
            Rectangle sourceRectangle = srcRec;
            if (currentFrame % 8 < 2)
            {
                sourceRectangle = new Rectangle(srcRec.X, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if (currentFrame % 8 < 4)
            {
                sourceRectangle = new Rectangle(srcRec.X + 35, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if (currentFrame % 8 < 6)
            {
                sourceRectangle = new Rectangle(srcRec.X + 35 * 2, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            else if (currentFrame % 8 < 8)
            {
                sourceRectangle = new Rectangle(srcRec.X + 35 * 3, srcRec.Y, srcRec.Width, srcRec.Height);
            }
            Rectangle destinationRectangleTopLeft = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            Rectangle destinationRectangleTopRight = new Rectangle((int)location.X + (currentFrame * 4)*2 + 15, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            Rectangle destinationRectangleBottomLeft = new Rectangle((int)location.X, (int)location.Y + (currentFrame * 4) * 2 + 15, srcRec.Width * 3, srcRec.Height * 3);
            Rectangle destinationRectangleBottomRight = new Rectangle((int)location.X + (currentFrame * 4) * 2 + 15, (int)location.Y + (currentFrame * 4) * 2 + 15, srcRec.Width * 3, srcRec.Height * 3);

            spriteBatch.Draw(texture, destinationRectangleTopLeft, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.None, 0);
            spriteBatch.Draw(texture, destinationRectangleTopRight, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipHorizontally, 0);
            spriteBatch.Draw(texture, destinationRectangleBottomLeft, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipVertically, 0);
            spriteBatch.Draw(texture, destinationRectangleBottomRight, sourceRectangle, Color.White, 0, new Vector2(0), SpriteEffects.FlipVertically | SpriteEffects.FlipHorizontally, 0);
        }
    }
}
