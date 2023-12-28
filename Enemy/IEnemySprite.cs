using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy
{
    internal interface IEnemySprite
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle);

    }
}
