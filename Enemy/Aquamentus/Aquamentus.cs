using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class Aquamentus : EnemyD
    {

        private int maxLeft = 100;

        public int MaxLeft { get { return maxLeft; } set { maxLeft = value; } }
        public IEnemyProjectile Fireball { get; set; }
        public IEnemyProjectile Fireball2 { get; set; }
        public IEnemyProjectile Fireball3 { get; set; }
        public Vector2 FireballPosition { get; set; }
        private int distance;
        private Random random;

        public Aquamentus(int x, int y)
        {
         
            this.X = x;
            this.Y = y;
            FireballPosition = new Vector2(x, y);
            Fireball = new AquamentusFireball(FireballPosition);
            Fireball2 = new AquamentusFireball(FireballPosition);
            Fireball3 = new AquamentusFireball(FireballPosition);
            random = new Random();
            distance = random.Next(0, 70);
            this.health = 3;

        }

        public override void Generate() {
            SoundFactory.PlaySound(SoundFactory.Instance.bossScream);
            State = new MovingLeftAquamentusState(this);
        }
        public override void Stun()
        {
            SoundFactory.PlaySound(SoundFactory.Instance.bossHurt);
            State = new StunnedAquamentusState(this);
        }

        public override void Update()
        {
    
            if (((AquamentusFireball)Fireball).Fire)
            {
                Fireball.Update();
                Fireball2.Update();
                Fireball3.Update();
            }
            count++;
            if (count >= distance&&(!(((AquamentusFireball)Fireball).Fire)&& !(((AquamentusFireball)Fireball2).Fire)&& !(((AquamentusFireball)Fireball3).Fire)))
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
            if (((AquamentusFireball)Fireball).Fire)
            {
            Fireball.Draw(spriteBatch);
            Fireball2.Draw(spriteBatch);
            Fireball3.Draw(spriteBatch);
            }
        }

        public override void MoveUp() { }
        public override void MoveDown() { }
        public override void MoveLeft()
        {
            State = new MovingLeftAquamentusState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightAquamentusState(this);
        }
    }
}
