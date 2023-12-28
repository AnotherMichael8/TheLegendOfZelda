using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class Dodongo : EnemyD
    {
        public static Rectangle[] Dodongos { get; } = new Rectangle[] { new Rectangle(35, 35, 15, 16), new Rectangle(1, 35, 15, 16), new Rectangle(69, 35, 28, 18), new Rectangle(102, 35, 28, 18) };
        public static Rectangle[] AttackedDodongos { get; } = new Rectangle[] { new Rectangle(52, 35, 16, 16), new Rectangle(17, 35, 17, 16), new Rectangle(135, 35, 32, 16) };
        public Dodongo(int x, int y)
        {
            this.health = 4.0f;
            this.X = x;
            this.Y = y;
        }
        public override void Generate()
        {
            State = new MovingLeftDodongoState(this);
        }
        public override void Stun()
        {
            State = new StunnedDodongoState(this);
        }
        public override void MoveUp()
        {
            State = new MovingUpDodongoState(this);
        }
        public override void MoveDown()
        {
            State = new MovingDownDodongoState(this);
        }
        public override void MoveLeft()
        {
            State = new MovingLeftDodongoState(this);
        }
        public override void MoveRight()
        {
            State = new MovingRightDodongoState(this);
        }
    }
}
