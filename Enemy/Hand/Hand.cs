using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Hand;
using System;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Hand
{
    internal class Hand : EnemyC
    {
        internal int counter;
        public Hand(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 1.5f;
            counter = 0;
        }
        public static Rectangle[] Hands { get; } = new Rectangle[] { new Rectangle(50, 52, 17, 16), new Rectangle(68, 52, 16, 16), new Rectangle(50, 18, 17, 16), new Rectangle(68, 1, 16, 16), new Rectangle(50, 35, 17, 16) };
        public override void Generate() {
        }
        public void CaptureLeft()
        {
            State = new CaptureLeftHandState(this);
        }
        public void CaptureRight()
        {
            State = new CaptureRightHandState(this);
        }
        public void CaptureDown()
        {
            State = new CaptureDownHandState(this);
        }
        public void CaptureUp()
        {
            State = new CaptureUpHandState(this);
        }
        public override void Stun()
        {
            State = new StunnedHandState(this);
        }
        public void End()
        {
            this.death = true;
            CollisionManager.GameObjectList.Remove(this);
        }
        public override void MoveUp()
        {
        }
        public override void MoveDown()
        {
        }
        public override void MoveLeft()
        {
        }
        public override void MoveRight()
        {
        }
    }
}
