using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class DamagedAttackWithBoomerangLeftState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
        private Random random;
        private int direction;
        private int colorTimer;

        public DamagedAttackWithBoomerangLeftState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Goriya.RightGoryia[1];
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            boomerang = Goriya.Boomerang;
            colorTimer = 0;

        }
        public void ChangeDirection()
        {
                Goriya.State = new MovingAttackedUpGoriyaState(Goriya);
        }
        public void ChangeAttackedStatus() {
            if(currentFrame >= 60)
                Goriya.State = new MovingLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Goriya.RightGoryia[Globals.FindIndex(currentFrame % (4 * Goriya.DamageAnimateRate), Goriya.DamageAnimateRate, 4) + 1];
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            if (!((GoriyaBoomerang)Goriya.Boomerang).Throwing) { ChangeDirection(); }
            ChangeAttackedStatus();

        }        
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
