using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Projectile;

namespace Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles
{
    internal class GoriyaBoomerangSprite : IEnemyProjectileSprite
    {
        private Texture2D texture;



        public GoriyaBoomerangSprite(Texture2D texture)
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
               GoriyaBoomerang.GoriyaBoomerangLeftEffects[GoriyaBoomerang.currentIndex],
                0f
            );
        }


    }
}
