using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class TargetSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle destinationRectangle;
        private Rectangle sourceRectangle = new Rectangle(0, 0, 15, 15);
        public TargetSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle)
        {
            destinationRectangle = new Rectangle(x, y, 45, 45);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
