using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class Goriya : EnemyB
    {
        public int IdleX { get; set; }
        public Vector2 BoomerangPosition { get; set; }
        public ProjectileDirection Direction { get; set; }
        public IEnemyProjectile Boomerang { get; set; }
        public static Rectangle[] DownGoryia { get; } = new Rectangle[] { new Rectangle(84, 1, 14, 16), new Rectangle(84, 18, 14, 16), new Rectangle(84, 35, 14, 16), new Rectangle(84, 52, 14, 16) };
        public static Rectangle[] UpGoryia { get; } = new Rectangle[] { new Rectangle(101, 1, 14, 16), new Rectangle(101, 18, 14, 16), new Rectangle(101, 35, 14, 16), new Rectangle(101, 52, 14, 16) };
        public static Rectangle[] RightGoryia { get; } = new Rectangle[] { new Rectangle(135, 35, 15, 16), new Rectangle(117, 35, 14, 16), new Rectangle(135, 1, 15, 16), new Rectangle(117, 18, 14, 16), new Rectangle(135, 52, 15, 16) };

        public enum ProjectileDirection
        {
            Left, Top, Right, Bottom
        }
        private int distance;
        private Random random;

        public Goriya(int x, int y)
        {

            this.X = x;
            this.Y = y;
            this.health = 1.5f;
            this.SpawnPosition = new Vector2(x, y);
            BoomerangPosition = new Vector2(X, Y);
            Boomerang = new GoriyaBoomerang(BoomerangPosition);
            Direction = ProjectileDirection.Left;
            random = new Random();
            distance = random.Next(0, 70);
        }
        public override void Generate() {
            State = new MovingLeftGoriyaState(this);
        }
        public override void Stun()
        {
            State = new StunnedGoriyaState(this);
        }
        public override void Update()
        {
            
           
            if (((GoriyaBoomerang)Boomerang).Throwing)
            {
                Boomerang.Update();
                
            }
            count++;
            if (count >= distance && (!((GoriyaBoomerang)Boomerang).Throwing))
            {
                State.ChangeDirection();
                distance = random.Next(0, 70);
                count = 0;

            }
            if(invinciblityTimer > 0)
            {
                invinciblityTimer--;
            }
            State.Update();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
            if (((GoriyaBoomerang)Boomerang).Throwing)
            {
                Boomerang.Draw(spriteBatch);
            }
        }
        public override void MoveUp()
        {
            State = new MovingUpGoriyaState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownGoriyaState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftGoriyaState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightGoriyaState(this);
        }
        public override void Kill()
        {
            base.Kill();
            CollisionManager.GameObjectList.Remove(Boomerang);
        }
        public override void Spawn()
        {
            this.X = (int)this.SpawnPosition.X;
            this.Y = (int)this.SpawnPosition.Y;
            State = new SpawnAnimationState(this);
        }
    }
}
