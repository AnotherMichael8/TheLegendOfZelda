using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class MovingUpTargetState : IEnemyState
    {
        private Target target;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;

        public MovingUpTargetState(Target target)
        {
            this.target = target;
            sprite = EnemySpriteFactory.Instance.CreateTargetSprite();
            sourceRectangle = Target.TargetSprite;
            target.Position = new Rectangle(target.X, target.Y, 45, 45);
        }
        public void ChangeDirection()
        {
            target.State = new MovingLeftTargetState(target);
        }
        public void ChangeAttackedStatus()
        {

        }
        public void BecomeIdle()
        {
            target.State = new IdleState(target);
        }
        public void MoveRight()
        {
        }
        public void MoveLeft()
        {
            if (target.X > 371 && target.X < 379)
            {
                target.State = new MovingLeftTargetState(target);
                target.X = 371;
            }
        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, target.X, target.Y, sourceRectangle);
        }
    }
}
