using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class MovingDownStalfosState : IEnemyState
    {
        private Stalfos Stalfos;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingDownStalfosState(Stalfos Stalfos)
        {
            this.Stalfos = Stalfos;
            sprite = EnemySpriteFactory.Instance.CreateStalfosSprite();
            sourceRectangle = Stalfos.Stalfoses[0];
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
                    Stalfos.State = new MovingLeftStalfosState(Stalfos);
                    break;
                case 1:
                    Stalfos.State = new MovingUpStalfosState(Stalfos);
                    break;
                case 2:
                    Stalfos.State = new MovingRightStalfosState(Stalfos);
                    break;
            }
        }
        public void ChangeAttackedStatus() {
            Stalfos.State = new MovingAttackedDownStalfosState(Stalfos);
        }
        public void Update()
        {
            Stalfos.Y += 1;
            Stalfos.Position = new Rectangle(Stalfos.X, Stalfos.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Stalfos.X, Stalfos.Y, sourceRectangle) ;
        }
    }
}
