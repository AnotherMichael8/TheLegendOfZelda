using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Zol;

using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class DeathAnimationState : IEnemyState
    {
        private IEnemy enemy;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private static EnemySpriteFactory enemySpriteFactory;
        public DeathAnimationState(IEnemy enemy)
        {
            this.enemy = enemy;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateDeathAnimationSprite();
            sourceRectangle = new Rectangle(39, 19, 15, 16);
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            
        }
        public void ChangeAttackedStatus() {
            enemy.Spawn();
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == 6)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 12)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 18)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 24)
            {
                enemy.exists = false;

                CollisionManager.GameObjectList.Remove(enemy);
                enemy.DropItem();              
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (enemy.exists)
            {
                sprite.Draw(spriteBatch, enemy.X, enemy.Y, sourceRectangle);
            }
        }
    }
}
