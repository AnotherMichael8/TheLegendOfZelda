using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class MovingUpRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingUpRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateRopeSprite();
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
                    rope.State = new MovingLeftRopeState(rope);
                    break;
                case 1:
                    rope.State = new MovingDownRopeState(rope);
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
            rope.Y -= 1;
            rope.Position = new Rectangle(rope.X, rope.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, rope.X, rope.Y, sourceRectangle);
        }
    }
}
