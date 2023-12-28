using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;
using System.Threading;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingDownSpikeTrapState : ISpikeTrapState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int timer;
        public MovingDownSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = SpikeTrap.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            timer = 0;
        }
        
        public void ChangeDirection()
        {
            //spikeTrap.state = new MovingUpSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus() {

        }
        public void BecomeIdle()
        {
            spikeTrap.state = new IdleState(spikeTrap);
        }
        public void MoveRight()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveUp()
        {
            if(spikeTrap.Y > 421 && spikeTrap.Y < 429)
            {
                spikeTrap.state = new MovingUpSpikeTrapState(spikeTrap);
                //Made the position 419 to make sure the position went back to the starting position. 
                spikeTrap.Y = 419;
            }
        }
        public void MoveDown()
        {
        }

        public void Update()
        {
            spikeTrap.Y += 4;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            MoveUp();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
