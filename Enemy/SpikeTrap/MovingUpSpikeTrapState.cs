using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingUpSpikeTrapState : ISpikeTrapState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;
        private int timer;
        public MovingUpSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = SpikeTrap.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            timer = 0;
        }
        public void ChangeDirection()
        {
           // spikeTrap.state = new MovingDownSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus()
        {

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
        }
        public void MoveDown()
        {
            if (spikeTrap.Y > 421 && spikeTrap.Y < 429)
            {
                spikeTrap.state = new MovingDownSpikeTrapState(spikeTrap);
                spikeTrap.Y = 429;  
            }
        }
        public void Update()
        {
            spikeTrap.Y -= 4;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            MoveDown();

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
