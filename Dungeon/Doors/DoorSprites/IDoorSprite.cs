using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    public interface IDoorSprite
    {
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color);
       // public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle);
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change);
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change, Vector2 initialPos);
    }
}
