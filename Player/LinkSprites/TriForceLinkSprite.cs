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
    public class TriForceLinkSprite : ILinkSprite
    {
        private Rectangle linkSourceRectangle;
        private Rectangle itemSourceRectangle;
        private Rectangle linkDestinationRectangle;
        private Rectangle itemDestinationRectangle;
        private Texture2D linkTexture;
        private Texture2D itemTexture;
        public TriForceLinkSprite(Texture2D linkTexture, Texture2D itemTexture)
        {
            linkSourceRectangle = new Rectangle(231, 11, 13, 15);
            itemSourceRectangle = new Rectangle(275, 3, 10, 10);
            this.linkTexture = linkTexture;
            this.itemTexture = itemTexture;
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color)
        {
            linkDestinationRectangle = new Rectangle((int)location.X, (int)location.Y, 45, 45);
            itemDestinationRectangle = new Rectangle((int)location.X + 8, (int)location.Y - 34, 30, 30);
            spriteBatch.Draw(linkTexture, linkDestinationRectangle, linkSourceRectangle, color);
            spriteBatch.Draw(itemTexture, itemDestinationRectangle, itemSourceRectangle, color);
        }
    }
}
