using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingAttackedLeftHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedLeftHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftHandSprite();
            currentFrame = 0;
            sourceRectangle = Hand.Hands[1];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void ChangeDirection()
        {

        }
        public void ChangeAttackedStatus() {
            if(currentFrame >= 60)
                Hand.State = new CaptureLeftHandState(Hand);
        }
        public void Update()
        {
            currentFrame++;
            if (Hand.counter > 0 && Hand.counter < 60)
            {
                Hand.X++;
            }
            else if (Hand.counter > 60 && Hand.counter < 240)
            {
                Hand.Y--;
            }
            else if (Hand.counter > 240 && Hand.counter < 300)
            {
                Hand.X--;
            }

            Hand.counter++;
            sourceRectangle = Hand.Hands[Globals.FindIndex(currentFrame % (4 * Hand.DamageAnimateRate), Hand.DamageAnimateRate, 4) + 1];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, sourceRectangle.Width, sourceRectangle.Height);
            ChangeAttackedStatus();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
