using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class RightUseItemLinkSprite : ILinkSprite
    {
        private Texture2D linkTexture;
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;

        public RightUseItemLinkSprite(Texture2D linkTexture)
        {
            this.linkTexture = linkTexture;
            sourceRectangle = new Rectangle(124, 11, 15, 15);
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);

            spriteBatch.Draw(linkTexture, destinationRectangle, sourceRectangle, color);
        }
    }
}
