using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingDownGoriyaSprite : IEnemySprite
    {
        private Texture2D texture;
        private SpriteEffects spriteEffects;
        private int currentFrame;
        public MovingDownGoriyaSprite(Texture2D texture)
        {
            this.texture = texture;
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    spriteEffects = SpriteEffects.None;

                }
                else
                {
                    spriteEffects = SpriteEffects.FlipHorizontally;

                }
            }
            else
            {
                currentFrame = 0;
            }
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
                spriteEffects,
                0.1f
            );
        }
    }
}
