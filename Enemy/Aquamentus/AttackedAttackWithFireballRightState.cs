using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class AttackedAttackWithFireballRightState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] sourceRectangles;
        private Rectangle[] attackedRectangles;
        private int currentFrame;
        private int direction;
        private int currentFireballFrame;
        private IEnemyProjectile fireball;
        private IEnemyProjectile fireball2;
        private IEnemyProjectile fireball3;
        private int elapsedFrameCount;
        private int endFrame;
        public AttackedAttackWithFireballRightState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingRightAquamentusSprite();
            currentFrame = 0;
            currentFireballFrame = 0;
            sourceRectangles = new Rectangle[] { new Rectangle(0, 0, 24, 33), new Rectangle(26, 0, 24, 33) };
            sourceRectangle = sourceRectangles[0];
            attackedRectangles = new Rectangle[] { new Rectangle(140, 0, 24, 33), new Rectangle(171, 0, 24, 33), new Rectangle(202, 0, 24, 33) };
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            fireball = Aquamentus.Fireball;
            fireball2 = Aquamentus.Fireball2;
            fireball3 = Aquamentus.Fireball3;
            elapsedFrameCount = 0;
            endFrame = 20;

        }
        public void ChangeDirection()
        {


            Random random = new Random();
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
            Aquamentus.State = new MovingAttackedRightAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
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
                Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));

            }
            else
            {
                currentFrame = 0;
            }

            elapsedFrameCount++;
            if (elapsedFrameCount >= endFrame * 1.2)
            {
                ChangeDirection();
            }
            if (elapsedFrameCount >= endFrame)
            {
            ((AquamentusFireball)fireball).Fire = true;
            ((AquamentusFireball)fireball2).Fire = true;
            ((AquamentusFireball)fireball3).Fire = true;

            }


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
            
        }
    }
}
