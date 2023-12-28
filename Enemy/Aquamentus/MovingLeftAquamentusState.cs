using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;
using System.Threading;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class MovingLeftAquamentusState : IEnemyState
    {
        private Aquamentus Aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public static Rectangle[] rectangles  = new Rectangle[] { new Rectangle(51, 0, 24, 33), new Rectangle(76, 0, 24, 33) };

        private Random random;
        private int distance;
        private int direction;

        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingLeftAquamentusState(Aquamentus Aquamentus)
        {
            this.Aquamentus = Aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            sourceRectangle = rectangles[0];
            Aquamentus.Position = new Rectangle(Aquamentus.X, Aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
            distance = random.Next(50, 100);

        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 3);

            switch(direction)
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
            Aquamentus.State = new MovingAttackedLeftAquamentusState(Aquamentus);
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame < 30)
            {
                if (currentFrame < 15)
                {
                    sourceRectangle = rectangles[0];

                }
                else
                {
                    sourceRectangle = rectangles[1];

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
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Aquamentus.X, Aquamentus.Y, sourceRectangle);
        }
    }
}
