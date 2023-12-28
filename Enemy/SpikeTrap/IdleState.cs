using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class IdleState : ISpikeTrapState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public IdleState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = SpikeTrap.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void ChangeDirection()
        {
        }
        public void BecomeIdle() { }
        public void MoveLeft()
        {
            spikeTrap.state = new MovingLeftSpikeTrapState(spikeTrap);
        }
        public void MoveRight()
        {
            spikeTrap.state = new MovingRightSpikeTrapState(spikeTrap);
        }
        public void MoveUp()
        {
            spikeTrap.state = new MovingUpSpikeTrapState(spikeTrap);
        }
        public void MoveDown()
        {
            spikeTrap.state = new MovingDownSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus() {

        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
