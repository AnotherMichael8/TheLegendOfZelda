using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;

namespace Sprint2_Attempt3.Enemy.Rope
{
    internal class Rope : EnemyC
    {
        public static Rectangle[] Ropes { get; } = new Rectangle[] { new Rectangle(18, 18, 14, 15), new Rectangle(33, 18, 15, 15) };
        public Rope(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.health = 0.5f;
        }
        public override void Generate() {
            State = new MovingLeftRopeState(this);
        }
        public override void Stun()
        {
            State = new StunnedRopeState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpRopeState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownRopeState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftRopeState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightRopeState(this);
        }
    }
}
