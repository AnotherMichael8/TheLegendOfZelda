using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemy : IGameObject
    {
        public Rectangle Position { get; set; }
        public IEnemyState State { get; set; }

        public int numWallCollisions { get; set; }
        public bool exists { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Generate();
        public void Stun();
        public void GetDamaged(float damage);
        public void Spawn();
        public void ChangeDirection();
        public void MoveUp();
        public void MoveDown();
        public void MoveLeft();
        public void MoveRight();
        public void ChangeAttackedStatus();
        public void Kill();
        public void DropItem();
        public void Draw(SpriteBatch spriteBatch);
    }
}
