using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Collision;
using System.Collections.Generic;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemySecondary : IEnemy
    {
        protected int count;
        protected bool death;
        protected int currentFrame;
        public int AnimateRate { get; } = 20;
        public int DamageAnimateRate { get; } = 5;
        private int distance;
        private Random random;
        protected float health;
        public bool exists { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IEnemyState State { get; set; }
        public Rectangle Position { get; set; }
        protected int invinciblityTimer = 0;
        public Vector2 SpawnPosition { get; set; }
        public int numWallCollisions { get; set; } = 0;
        
        public abstract void Generate();
        public abstract void Stun();
        public abstract void DropItem();
        public EnemySecondary()
        {
            random = new Random();
            distance = random.Next(50, 200);
            count = 0;
            currentFrame = 0;
            exists = true;
            invinciblityTimer = 0;
        }
        public virtual void Spawn()
        {
            State = new SpawnAnimationState(this);
        }
        public virtual void Kill()
        {
            //int[] list = RoomSecondary.EnemiesKilledList;
           // list[RoomSecondary.GetCurrentRoomNumber()]++;
            //RoomSecondary.EnemiesKilledList = list;
            death = true;
            State = new DeathAnimationState(this);
        }

        public virtual void GetDamaged(float damage)
        {
            if (invinciblityTimer == 0)
            {
                invinciblityTimer = 40;
                this.ChangeAttackedStatus();
                health -= damage;
                SoundFactory.PlaySound(SoundFactory.Instance.enemyHit);

                if (health <= 0)
                {
                    Kill();
                }
            }
        }
        
        public void ChangeDirection()
        {
            State.ChangeDirection();
        }
        public void ChangeAttackedStatus()
        {
            State.ChangeAttackedStatus();
        }
        public virtual void Update()
        {
            count++;
            if (count == distance)
            {
                State.ChangeDirection();
                distance = random.Next(100, 400);
                count = 0;
            }
            if(invinciblityTimer > 0)
            {
                invinciblityTimer--;
            }
            State.Update();
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (exists)
            {
                State.Draw(spriteBatch);
            }
        }
        public virtual Rectangle GetHitBox() {
            if(!death)
                return Position;
            return new Rectangle(0, 0, 0, 0);
        }

        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}
