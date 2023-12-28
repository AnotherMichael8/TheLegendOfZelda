using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Zol;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingAttackedDownGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int endFrame;
        public MovingAttackedDownGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            sourceRectangle = Goriya.DownGoryia[0];
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            endFrame = 100;
        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateDown();
            CollisionManager.GameObjectList.Add(Goriya.Boomerang);
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new DamagedAttackWithBoomerangDownState(Goriya);
        }
        public void ChangeAttackedStatus() {
            if(currentFrame >= 60)
                Goriya.State = new MovingDownGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Goriya.DownGoryia[Globals.FindIndex(currentFrame % (4 * Goriya.DamageAnimateRate), Goriya.DamageAnimateRate, 4)];
            Goriya.Y += 1;
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
            if (currentFrame >= endFrame) { ChangeDirection(); }
            ChangeAttackedStatus();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle) ;
        }
    }
}
