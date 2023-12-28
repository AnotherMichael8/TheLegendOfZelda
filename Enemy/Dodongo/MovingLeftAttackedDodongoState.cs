using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingLeftAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int killCounter;
        public MovingLeftAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAttackedDodongoSprite();
            sourceRectangle = Dodongo.AttackedDodongos[2];
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            killCounter = 0;
        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingLeftDodongoState(dodongo);
        }
        public void Update()
        {
            killCounter++;
            if (killCounter == 100)
            {
                ChangeAttackedStatus();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
