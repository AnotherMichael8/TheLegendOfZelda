using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;
using System;
using Sprint2_Attempt3.Enemy.Keese;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class Keese : EnemyX
    {
        public static Rectangle[] Keeses { get; } = new Rectangle[] { new Rectangle(33, 34, 16, 8), new Rectangle(34, 43, 16, 11) };
        public Keese(int x, int y)
        {
            X = x;
            Y = y;
            this.health = 0.5f;
        }
        public override void Generate()
        {
            State = new MovingLeftKeeseState(this);
        }
        public override void Stun()
        {
            State = new DeathAnimationState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpKeeseState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownKeeseState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftKeeseState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightKeeseState(this);
        }

    }
}
