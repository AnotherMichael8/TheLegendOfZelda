using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Stalfos;
using System;

namespace Sprint2_Attempt3.Enemy.Stalfos
{
    internal class Stalfos : EnemyC
    {
        public static Rectangle[] Stalfoses { get; } = new Rectangle[] { new Rectangle(1, 51, 15, 16), new Rectangle(17, 34, 15, 16), new Rectangle(1, 34, 15, 16), new Rectangle(17, 51, 15, 16) };
        public Stalfos(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 2;
            this.SpawnPosition = new Vector2(x, y);
        }
        public override void Generate() {
            State = new MovingLeftStalfosState(this);
        }
        public override void Stun()
        {
            State = new StunnedStalfosState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpStalfosState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownStalfosState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftStalfosState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightStalfosState(this);
        }
        public override void Spawn()
        {
            this.X = (int)this.SpawnPosition.X;
            this.Y = (int)this.SpawnPosition.Y;
            State = new SpawnAnimationState(this);
        }
    }
}
