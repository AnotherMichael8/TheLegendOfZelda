using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3.Enemy.Zol
{
    internal class Zol : EnemyC
    {
        public static Rectangle[] Zols { get; } = new Rectangle[] { new Rectangle(18, 1, 13, 16), new Rectangle(34, 1, 14, 16) };
        public Zol(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 1.0f;
        }
        public override void Generate() {
            State = new MovingLeftZolState(this);
        }
        public override void Stun()
        {
            State = new DeathAnimationState(this);
        }
        public override void MoveUp() {
            State = new MovingUpZolState(this);
        }
        public override void MoveDown() {
            State = new MovingDownZolState(this);
        }
        public override void MoveLeft() {
            State = new MovingLeftZolState(this);
        }
        public override void MoveRight() {
            State = new MovingRightZolState(this);
        }
    }
}
