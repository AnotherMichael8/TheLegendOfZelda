using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Zol;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class SpawnAnimationState : IEnemyState
    {
        private IEnemy enemy;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private static EnemySpriteFactory enemySpriteFactory;
        public SpawnAnimationState(IEnemy enemy)
        {
            this.enemy = enemy;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateSpawnAnimationSprite();
            sourceRectangle = new Rectangle(1, 1, 16, 16);
            currentFrame = 0;
        }
        public void ChangeDirection()
        {            
        }
        public void ChangeAttackedStatus() {

        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == 10)
            {
                sourceRectangle.X = 18;
            }
            else if (currentFrame == 20)
            {
                sourceRectangle.X = 35;
            }
            else if (currentFrame == 30)
            {
                enemy.Generate();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, enemy.X, enemy.Y, sourceRectangle);
        }
    }
}
