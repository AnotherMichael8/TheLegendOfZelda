using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class StunnedRopeState : IEnemyState
    {
        private Rope rope;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        private int stunCounter;
        public StunnedRopeState(Rope rope)
        {
            this.rope = rope;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftRopeSprite();
            sourceRectangle = Rope.Ropes[0];
            rope.Position = new Rectangle(rope.X, rope.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 3);
            stunCounter = 0;
        }
        public void ChangeDirection()
        {
            if (stunCounter == 200)
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
                    case 3:
                        rope.State = new MovingLeftRopeState(rope);
                        break;
                }
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
            rope.Position = new Rectangle(rope.X, rope.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            stunCounter++;
            ChangeDirection();
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, rope.X, rope.Y, sourceRectangle);
        }
    }
}