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
    public class BowLinkSprite : ILinkSprite
    {
        private Rectangle linkSourceRectangle;
        private Rectangle itemDestinationRectangle;
        private Rectangle itemSourceRectangle;
        private Rectangle destinationRectangle;
        private Texture2D linkTexture;
        private Texture2D itemTexture;
        public BowLinkSprite(Texture2D linkTexture, Texture2D itemTexture)
        {
            linkSourceRectangle = new Rectangle(214, 11, 12, 15);
            itemSourceRectangle = new Rectangle(144, 0, 8, 16);
            this.linkTexture = linkTexture;
            this.itemTexture = itemTexture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);
            itemDestinationRectangle = new Rectangle((int)location.X + 10, (int)location.Y - 30, 12, 24);
            spriteBatch.Draw(linkTexture, destinationRectangle, linkSourceRectangle, color);
            spriteBatch.Draw(itemTexture, itemDestinationRectangle, itemSourceRectangle, color);
        }
    }
}
