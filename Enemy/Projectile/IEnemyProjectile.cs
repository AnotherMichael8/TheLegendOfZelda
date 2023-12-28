using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Projectile
{
    public interface IEnemyProjectile : IGameObject, IProjectile
    {
        public Vector2 Position { get { return Position; } set { Position = value; } }
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
