using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class StunnedHandState : IEnemyState
    {
        private Hand Hand;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        private int stunCounter;
        public StunnedHandState(Hand Hand)
        {
            this.Hand = Hand;
            sprite = EnemySpriteFactory.Instance.CreateHandSprite();
            sourceRectangle = Hand.Hands[0];
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 3);
            stunCounter = 0;
        }
        public void ChangeDirection()
        {
            /*direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Hand.State = new MovingLeftHandState(Hand);
                    break;
                case 1:
                    Hand.State = new MovingUpHandState(Hand);
                    break;
                case 2:
                    Hand.State = new MovingRightHandState(Hand);
                    break;
                case 3:
                    Hand.State = new MovingDownHandState(Hand);
                    break;
            }       */
        }
        public void ChangeAttackedStatus()
        {
            //Hand.State = new MovingAttackedDownHandState(Hand);
        }
        public void Update()
        {
            stunCounter++;
            if (stunCounter == 200)
            {
                ChangeDirection();
            }
            Hand.Position = new Rectangle(Hand.X, Hand.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Hand.X, Hand.Y, sourceRectangle);
        }
    }
}