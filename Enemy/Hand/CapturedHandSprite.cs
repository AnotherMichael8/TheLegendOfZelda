using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class CapturedHandSprite : IEnemySprite
    {
        private Texture2D enemies;
        private Texture2D character;
        private SpriteEffects spriteEffects;
        public CapturedHandSprite(Texture2D texture, Texture2D character)
        {
            this.enemies = texture;
            this.character = character;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle)
        {
            Rectangle sourceRectangle2 = new Rectangle(1, 11, 15, 15);
            spriteBatch.Draw(character, new Vector2(x, y), sourceRectangle2, Color.White, 0f, new Vector2(0, 0), Globals.scale, spriteEffects, 0f);

            sourceRectangle = new Rectangle(68, 53, 13, 14);
            spriteBatch.Draw(
                enemies,
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
