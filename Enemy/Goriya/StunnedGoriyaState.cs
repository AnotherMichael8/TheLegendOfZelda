using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class StunnedGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        public StunnedGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftGoriyaSprite();
            currentFrame = 0;
            sourceRectangle = Goriya.RightGoryia[2];
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.Goriya.Direction = Goriya.ProjectileDirection.Left;
            random = new Random();
            direction = random.Next(0, 3);
        }
        public void ChangeDirection()
        {
            if (currentFrame == 200)
            {
                direction = random.Next(0, 3);
                switch (direction)
                {
                    case 0:
                        Goriya.State = new MovingDownGoriyaState(Goriya);
                        break;
                    case 1:
                        Goriya.State = new MovingUpGoriyaState(Goriya);
                        break;
                    case 2:
                        Goriya.State = new MovingLeftGoriyaState(Goriya);
                        break;
                    case 3:
                        Goriya.State = new MovingRightGoriyaState(Goriya);
                        break;
                }
            }
        }
        public void ChangeAttackedStatus()
        {
            Goriya.State = new MovingAttackedLeftGoriyaState(Goriya);
        }
        public void Update()
        {
            currentFrame++;
            sourceRectangle = Goriya.RightGoryia[Globals.FindIndex(currentFrame % (2 * Goriya.AnimateRate), Goriya.AnimateRate, 2)];
            Goriya.Position = new Rectangle(Goriya.X, Goriya.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            ChangeDirection();
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
        }
    }
}
