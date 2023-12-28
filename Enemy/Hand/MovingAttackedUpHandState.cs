using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class MovingAttackedUpHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        public MovingAttackedUpHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Hand.Hands[1];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
        }
        public void ChangeDirection()
        {
            /*direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Hand.State = new MovingAttackedLeftHandState(Hand);
                    break;
                case 1:
                    Hand.State = new MovingAttackedDownHandState(Hand);
                    break;
                case 2:
                    Hand.State = new MovingAttackedRightHandState(Hand);
                    break;
            }*/
        }
        public void ChangeAttackedStatus() {
            if(currentFrame >= 60)
                Hand.State = new CaptureUpHandState(Hand);
        }
        public void Update()
        {
            currentFrame++;
            if (Hand.counter > 0 && Hand.counter < 60)
            {
                Hand.Y++;
            }
            else if (Hand.counter > 60 && Hand.counter < 240)
            {
                Hand.X--;
            }
            else if (Hand.counter > 240 && Hand.counter < 300)
            {
                Hand.Y--;
            }
            Hand.counter++;
            sourceRectangle = Hand.Hands[Globals.FindIndex(currentFrame % (4 * Hand.DamageAnimateRate), Hand.DamageAnimateRate, 4) + 1];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
            ChangeAttackedStatus();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}
