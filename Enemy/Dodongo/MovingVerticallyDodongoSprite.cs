using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingVerticallyDodongoSprite : IEnemySprite
    {
        private Texture2D texture;
        private Rectangle sourceRectangle;
        private SpriteEffects spriteEffect;
        private int currentFrame;
        public MovingVerticallyDodongoSprite(Texture2D texture)
        {
            this.texture = texture;
            sourceRectangle = Dodongo.Dodongos[1];
            spriteEffect = SpriteEffects.None;
            currentFrame = 0;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    spriteEffect = SpriteEffects.None;

                }
                else
                {
                    spriteEffect = SpriteEffects.FlipHorizontally;

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
                spriteEffect,
                0.1f
            );
        }
    }
}
