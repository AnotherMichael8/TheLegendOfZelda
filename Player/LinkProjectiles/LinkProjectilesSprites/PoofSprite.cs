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
    public class PoofSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        //public Rectangle ArrowCollisionRectangle { get; private set; }
        public PoofSprite(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
        }
        public void Update()
        {

            //System.Diagnostics.Debug.WriteLine("test");
            currentFrame++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            if (currentFrame < 4)
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
            spriteBatch.Draw(texture, destinationRectangle, srcRec, Color.White);
        }
    }
}