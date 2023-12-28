using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingAttackedLeftAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] attackedRectangles;
        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private int direction;
        private int distance;
        private Random random;
        public MovingAttackedLeftAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            attackedRectangles = new Rectangle[] { new Rectangle(140, 0, 24, 33), new Rectangle(171, 0, 24, 33), new Rectangle(202, 0, 24, 33) };
            sourceRectangle = attackedRectangles[0];
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            elaspedFrameCount = 0;
            endFrame = 100;
            random = new Random();
            distance = random.Next(50, 100);
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);

            switch (direction)
            {
                case 0:
                    Aquamentus.State = new MovingRightAquamentusState(Aquamentus);
                    break;
                case 1:
                    Aquamentus.FireballPosition = new Vector2(Aquamentus.X, Aquamentus.Y);
                    Aquamentus.Fireball = new AquamentusFireball(Aquamentus.FireballPosition);
                    Aquamentus.Fireball2 = new AquamentusFireball(Aquamentus.FireballPosition);
                    Aquamentus.Fireball3 = new AquamentusFireball(Aquamentus.FireballPosition);
                    ((AquamentusFireball)Aquamentus.Fireball).GenerateLeft();
                    ((AquamentusFireball)Aquamentus.Fireball2).GenerateTopLeft();
                    ((AquamentusFireball)Aquamentus.Fireball3).GenerateBottomLeft();
                    CollisionManager.GameObjectList.Add((IGameObject)Aquamentus.Fireball);
                    CollisionManager.GameObjectList.Add((IGameObject)Aquamentus.Fireball2);
                    CollisionManager.GameObjectList.Add((IGameObject)Aquamentus.Fireball3);
                    Aquamentus.State = new AttackWithFireballLeftState(Aquamentus);
                    break;
                case 2:
                    Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);
                    break;

            }
        }
        public void ChangeAttackedStatus() {
            Aquamentus.State = new MovingLeftAquamentusState(Aquamentus);
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
                if (Aquamentus.MaxLeft > 0)
                {
                    Aquamentus.X -= 1;
                    Aquamentus.MaxLeft--;
                }
                Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            }
            else
            {
                currentFrame = 0;
            }
            elaspedFrameCount++;
            if (elaspedFrameCount >= endFrame)
            {
                ChangeDirection();
            }

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
