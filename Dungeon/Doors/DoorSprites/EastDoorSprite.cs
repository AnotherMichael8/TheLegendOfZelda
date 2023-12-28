using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    internal class EastDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        public static Rectangle EastDoorPosition { get { return new Rectangle(700, 227 + Globals.YOffset, 100, 94); } }
        public EastDoorSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                EastDoorPosition,
                sourceRectangle,
                color,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle(EastDoorPosition.X + (int)(change.X * 3.125), EastDoorPosition.Y + (int)(change.Y * 3.125), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change, Vector2 initialPos)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle((int)(EastDoorPosition.X + change.X * 3.125+initialPos.X), (int)(EastDoorPosition.Y + change.Y * 3.125+initialPos.Y), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

    
    }
}
