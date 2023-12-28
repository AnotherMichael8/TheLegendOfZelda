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
    public class BlueArrowSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public Rectangle ArrowCollisionRectangle { get; private set; }
        public BlueArrowSprite(Texture2D texture)
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

            if (currentFrame < 55)
            {
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            else
            {
                srcRec = new Rectangle(53, 185, 7, 15);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            spriteBatch.Draw(texture, destinationRectangle, srcRec, Color.White, 0, new Vector2(0), flip, 0);
        }
    }
}

