using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Projectile
{
    internal class EnemyProjectileSpriteFactory
    {
        private static Texture2D EnemyTexture;
        private static Texture2D BossEnemyTexture;
        private static Texture2D GenerationTexture;

        private static EnemyProjectileSpriteFactory instance = new EnemyProjectileSpriteFactory();

        public static EnemyProjectileSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public EnemyProjectileSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            EnemyTexture = content.Load<Texture2D>("Enemies");
            BossEnemyTexture = content.Load<Texture2D>("Bosses");
            GenerationTexture = content.Load<Texture2D>("characterGenerationSprite");
        }

        public IEnemyProjectileSprite MovingBoomerang()
        {
            return new GoriyaBoomerangSprite(EnemyTexture);
        }
        public IEnemyProjectileSprite MovingFireball()
        {
            return new AquamentusFireballSprite(BossEnemyTexture);
        }


    }
}
