using Sprint2_Attempt3.Player;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class CapturedLinkSprite : ILinkSprite
    {
        private Rectangle sourceRectangle;
        private Rectangle destinationRectangle;
        private int currentFrame;
        private Texture2D linkTexture;
        public CapturedLinkSprite()
        {
        }

        public void Update()
        {
        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)
        {
            
        }
    }
}
