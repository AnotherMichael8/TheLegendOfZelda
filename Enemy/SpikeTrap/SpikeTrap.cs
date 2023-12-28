using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Player.LinkStates;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class SpikeTrap : EnemyX
    {
        public static Rectangle SpikeTrapSprite { get; } = new Rectangle(1, 11, 16, 16);
        protected Vector2 spawnPoint;
        public ISpikeTrapState state { get; set; }
        public SpikeTrap(int x, int y)
        {
            this.X = x;
            this.Y = y;
            spawnPoint = new Vector2(x, y);
            state = new IdleState(this);
        }
        public override void Update() {
            state.Update();            
        }
        public override void Generate() {
            state = new IdleState(this);
        }
        public override void Stun()
        {
            //Isn't affected
        }
        public void BecomeIdle()
        {
            state.BecomeIdle();
        }
        public override void MoveUp()
        {
            state.MoveUp();
        }
        public override void MoveDown()
        {
            state.MoveDown();
            
        }
        public override void MoveLeft()
        {
            state.MoveLeft();
            
        }
        public override void MoveRight()
        {
            state.MoveRight();
            
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
    }
}
