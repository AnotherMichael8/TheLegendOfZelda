using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingLeftRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingLeftRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftRopeSprite();
            sourceRectangle = Rope.Ropes[0];
            rope.Position = new Rectangle(rope.X, rope.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 3);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    rope.State = new MovingDownRopeState(rope);
                    break;
                case 1:
                    rope.State = new MovingUpRopeState(rope);
                    break;
                case 2:
                    rope.State = new MovingRightRopeState(rope);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            rope.State = new DeathAnimationState(rope);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Rope.Ropes[Globals.FindIndex(currentFrame % (Rope.Ropes.Length * rope.AnimateRate), rope.AnimateRate, Rope.Ropes.Length)];
            rope.X -= 1;
            rope.Position = new Rectangle(rope.X, rope.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, rope.X, rope.Y, sourceRectangle);
        }
    }
}
