using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingAttackedRightAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] attackedRectangles;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private Random random;
        private int direction;
        public MovingAttackedRightAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            attackedRectangles = new Rectangle[] { new Rectangle(140, 0, 24, 33), new Rectangle(171, 0, 24, 33), new Rectangle(202, 0, 24, 33) };
            sourceRectangle = attackedRectangles[0];
            currentFrame = 0;
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            direction = random.Next(0, 3);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);
            switch (direction)
            {
                case 0:
                    Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);
                    break;
                case 1:
                    Aquamentus.FireballPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
                    Aquamentus.Fireball = new AquamentusFireball(Aquamentus.FireballPosition);
                    Aquamentus.Fireball2 = new AquamentusFireball(Aquamentus.FireballPosition);
                    Aquamentus.Fireball3 = new AquamentusFireball(Aquamentus.FireballPosition);
                    ((AquamentusFireball)Aquamentus.Fireball).GenerateLeft();
                    ((AquamentusFireball)Aquamentus.Fireball2).GenerateTopLeft();
                    ((AquamentusFireball)Aquamentus.Fireball3).GenerateBottomLeft();
                    Aquamentus.State = new AttackWithFireballLeftState(Aquamentus);
                    break;
                case 2:
                    Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
                    break;

            }
     
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame <= 20)
            {
                if (currentFrame == 5)
                {
                    sourceRectangle = attackedRectangles[0];
                }
                else if (currentFrame == 10)
                {
                    sourceRectangle = attackedRectangles[1];
                }
                else if (currentFrame == 15)
                {
                    sourceRectangle = attackedRectangles[2];
                }
                if (Aquamentus.MaxLeft < 200)
                {
                    Aquamentus.X += 1;
                    Aquamentus.MaxLeft++;
                }
                Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
          
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
