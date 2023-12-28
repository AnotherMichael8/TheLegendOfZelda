using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites
{
    public class AttackSwordSprite : ILinkProjectileSprite
    {
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D texture;
        public AttackSwordSprite(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Rectangle srcRec, SpriteEffects flip)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            spritebatch.Draw(texture, destinationRectangle, srcRec, Color.White, 0, new Vector2(0), flip, 0);
        }
    }
}
