using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class MovingRightDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingRightDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateDodongoSprite();
            sourceRectangle = Dodongo.Dodongos[2];
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 3);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    dodongo.State = new MovingLeftDodongoState(dodongo);
                    break;
                case 1:
                    dodongo.State = new MovingUpDodongoState(dodongo);
                    break;
                case 2:
                    dodongo.State = new MovingDownDodongoState(dodongo);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingRightAttackedDodongoState(dodongo);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Dodongo.Dodongos[Globals.FindIndex(currentFrame % (2 * dodongo.AnimateRate), dodongo.AnimateRate, 2) + 2];
            dodongo.X += 1;
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}
