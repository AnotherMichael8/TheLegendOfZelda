using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftAttackedDodongoSprite : IEnemySprite
    {
        private Texture2D texture;
        public MovingLeftAttackedDodongoSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.FlipHorizontally,
                0.1f
            );
        }
    }
}
