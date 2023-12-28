using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingRightAttackedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int killCounter;
        public MovingRightAttackedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateDodongoSprite();
            sourceRectangle = Dodongo.AttackedDodongos[2];
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            killCounter = 0;
        }
        public void ChangeDirection()
        {
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingRightDodongoState(dodongo);
        }
        public void Update()
        {
            killCounter++;
            if (killCounter == 100)
            {
                dodongo.State = new MovingRightDodongoState(dodongo);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
