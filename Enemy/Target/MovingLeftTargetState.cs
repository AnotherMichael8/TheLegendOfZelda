using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class MovingLeftTargetState : IEnemyState
    {
        private Target target;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;

        public MovingLeftTargetState(Target target)
        {
            this.target = target;
            sprite = EnemySpriteFactory.Instance.CreateTargetSprite();
            sourceRectangle = Target.TargetSprite;
            target.Position = new Rectangle(target.X, target.Y, 45, 45);
        }
        public void ChangeDirection()
        {
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
            if (target.X > 371 && target.X < 379)
            {
                target.State = new MovingRightTargetState(target);
                target.X = 379;
            }
        }
        public void MoveLeft()
        {

        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
        }
        public void Update()
        {
            target.X -= 2;
            target.Position = new Rectangle(target.X, target.Y, 45, 45);
            if(target.X < 110)
            {
                target.X = 650;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, target.X, target.Y, sourceRectangle);
        }
    }
}
