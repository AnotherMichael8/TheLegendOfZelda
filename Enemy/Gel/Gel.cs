using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Gel
{
    internal class Gel : EnemyX
    {
        public static Rectangle[] Gels { get; } = new Rectangle[] { new Rectangle(0, 1, 9, 9), new Rectangle(10, 1, 8, 9) };
        public Gel(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 0.5f;
        }
        public override void Generate() {
            State = new MovingLeftGelState(this);
        }
        public override void Stun()
        {
            State = new DeathAnimationState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpGelState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownGelState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftGelState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightGelState(this);
        }
    }
}
