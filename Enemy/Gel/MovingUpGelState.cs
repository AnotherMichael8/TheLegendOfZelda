using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class MovingUpGelState : IEnemyState
    {
        private Gel gel;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public MovingUpGelState(Gel gel)
        {
            this.gel = gel;
            sprite = EnemySpriteFactory.Instance.CreateGelSprite();
            sourceRectangle = Gel.Gels[0];
            gel.Position = new Rectangle(gel.X, gel.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
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
                    gel.State = new MovingLeftGelState(gel);
                    break;
                case 1:
                    gel.State = new MovingDownGelState(gel);
                    break;
                case 2:
                    gel.State = new MovingRightGelState(gel);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            gel.State = new DeathAnimationState(gel);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Gel.Gels[Globals.FindIndex(currentFrame % (Gel.Gels.Length * gel.AnimateRate), gel.AnimateRate, Gel.Gels.Length)];
            gel.Y -= 1;
            gel.Position = new Rectangle(gel.X, gel.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, gel.X, gel.Y, sourceRectangle);
        }
    }
}
