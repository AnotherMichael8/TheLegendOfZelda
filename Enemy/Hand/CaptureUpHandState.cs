using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class CaptureUpHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        public CaptureUpHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Hand.Hands[0];
            Hand.Position = new Rectangle(Hand.X,Hand.Y + Globals.YOffset, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void ChangeDirection()
        {

        }
        public void ChangeAttackedStatus() {
            Hand.State = new MovingAttackedLeftHandState(Hand);
        }
        public void Update()
        {
            if (Hand.counter >= 0 && Hand.counter < 60)
            {
                Hand.Y++;
            } 
            else if(Hand.counter >= 60 && Hand.counter < 240) 
            {
                Hand.X--;
            }
            else if(Hand.counter >= 240 && Hand.counter < 300)
            {
                Hand.Y--;
            }
            else
            {
                Hand.End();
            }

            Hand.counter++;
            sourceRectangle = Hand.Hands[Globals.FindIndex(currentFrame % (2 * Hand.AnimateRate), Hand.AnimateRate, 2)];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
