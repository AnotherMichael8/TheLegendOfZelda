using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Target;

namespace Sprint2_Attempt3.Enemy
{
    internal class EnemySpriteFactory
    {
        private static Texture2D EnemyTexture;
        private static Texture2D BossEnemyTexture;
        private static Texture2D GenerationTexture;
        private static Texture2D CharacterTexture;
        private static Texture2D TargetTexture;

        private static EnemySpriteFactory instance = new EnemySpriteFactory();

        public static EnemySpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public EnemySpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            EnemyTexture = content.Load<Texture2D>("Enemies");
            BossEnemyTexture = content.Load<Texture2D>("Bosses");
            GenerationTexture = content.Load<Texture2D>("characterGenerationSprite");
            CharacterTexture = content.Load<Texture2D>("LinkPlayerSpriteSheetFinal");
            TargetTexture = content.Load<Texture2D>("targetSprite");

        }
        //Spawn and animation sprites
        public IEnemySprite CreateSpawnAnimationSprite()
        {
            return new SpawnAnimationSprite(GenerationTexture);
        }
        public IEnemySprite CreateDeathAnimationSprite()
        {
            return new DeathAnimationSprite(GenerationTexture);
        }
        //keese sprite
        public IEnemySprite CreateKeeseSprite()
        {
            return new KeeseSprite(EnemyTexture);
        }
        //rope sprites
        public IEnemySprite CreateRopeSprite()
        {
            return new RopeSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftRopeSprite()
        {
            return new MovingLeftRopeSprite(EnemyTexture);
        }
        //zol sprite
        public IEnemySprite CreateZolSprite()
        {
            return new ZolSprite(EnemyTexture);
        }
        //gel sprite
        public IEnemySprite CreateGelSprite()
        {
            return new GelSprite(EnemyTexture);
        }
        //spiketrap sprite
        public IEnemySprite CreateSpkieTrapSprite()
        {
            return new SpikeTrapSprite(EnemyTexture);
        }
        //hand sprites
        public IEnemySprite CreateHandSprite()
        {
            return new HandSprite(EnemyTexture);
        }
        public IEnemySprite CreateCapturedHandSprite()
        {
            return new CapturedHandSprite(EnemyTexture, CharacterTexture);
        }
        public IEnemySprite CreateMovingLeftHandSprite()
        {
            return new MovingLeftHandSprite(EnemyTexture);
        }
        //stalfos sprite
        public IEnemySprite CreateStalfosSprite()
        {
            return new StalfosSprite(EnemyTexture);
        }
        //dodongo sprite
        public IEnemySprite CreateDodongoSprite()
        {
            return new DodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingVerticallyDodongoSprite()
        {
            return new MovingVerticallyDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftDodongoSprite()
        {
            return new MovingLeftDodongoSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingLeftAttackedDodongoSprite()
        {
            return new MovingLeftAttackedDodongoSprite(BossEnemyTexture);
        }
        //Goriya sprite
        public IEnemySprite CreateMovingUpGoriyaSprite()
        {
            return new MovingUpGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingDownGoriyaSprite()
        {
            return new MovingDownGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingRightGoriyaSprite()
        {
            return new MovingRightGoriyaSprite(EnemyTexture);
        }
        public IEnemySprite CreateMovingLeftGoriyaSprite()
        {
            return new MovingLeftGoriyaSprite(EnemyTexture);
        }

        public IEnemySprite CreateMovingLeftAquamentusSprite()
        {
            return new MovingLeftAquamentusSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateMovingRightAquamentusSprite()
        {
            return new MovingRightAquamentusSprite(BossEnemyTexture);
        }
        public IEnemySprite CreateTargetSprite()
        {
            return new TargetSprite(TargetTexture);
        }
    }
}
