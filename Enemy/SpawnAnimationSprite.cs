using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy
{
    internal class SpawnAnimationSprite : IEnemySprite
    {
        private Texture2D texture;
        public SpawnAnimationSprite(Texture2D texture) {
            this.texture = texture;
        }
        public void Update() {
            
        }
        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle) {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.None,
                0f
            );
        }
    }
}
