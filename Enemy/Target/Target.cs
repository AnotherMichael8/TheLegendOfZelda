using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Enemy.Target
{
    internal class Target : EnemyX
    {
        public static Rectangle TargetSprite { get; } = new Rectangle(93, 76, 173, 159);
        protected Vector2 spawnPoint;
        protected bool direction;
        public Target(int x, int y, bool direction)
        {
            this.X = x;
            this.Y = y;
            this.health = 0.5f;
            this.SpawnPosition = new Vector2(x, y);
            this.direction = direction;
            spawnPoint = new Vector2(x, y);
            if (direction)
            {
                State = new MovingRightTargetState(this);
            }
            else
            {
                State = new MovingLeftTargetState(this);
            }
        }
        public override void Update() {
            if (invinciblityTimer > 0)
            {
                invinciblityTimer--;
            }
            State.Update();
        }
        public override void Generate() {
            if (direction)
            {
                State = new MovingRightTargetState(this);
            }
            else
            {
                State = new MovingLeftTargetState(this);
            }
        }
        public override void MoveUp()
        {
            //may use this
        }
        public override void MoveDown()
        {
            //may use this
        }
        public override void Stun()
        {
            //will never use this
        }
        public override void MoveLeft()
        {
            //State.MoveLeft();
        }
        public override void MoveRight()
        {
            //State.MoveRight();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }
    }
}

