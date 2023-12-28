using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingRightSpikeTrapState : ISpikeTrapState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;
        private int timer;
        public MovingRightSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = SpikeTrap.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            timer = 0;
        }
        public void ChangeDirection()
        {
            //spikeTrap.state = new MovingLeftSpikeTrapState(spikeTrap);
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
            if (spikeTrap.X > 371 && spikeTrap.X < 379)
            {
                spikeTrap.state = new MovingLeftSpikeTrapState(spikeTrap);
                spikeTrap.X = 371;
            }
        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
        }
        public void Update()
        {
            spikeTrap.X += 4;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            MoveLeft();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
