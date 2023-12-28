using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Dungeon.Doors.DoorSprites
{
    internal class NorthDoorSprite : IDoorSprite
    {
        private Texture2D texture;
        private static Rectangle NorthDoorPosition = new Rectangle(348, 0 + Globals.YOffset, 105, 100); 
        public NorthDoorSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                NorthDoorPosition,
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
            Rectangle destinationRectangle = new Rectangle(NorthDoorPosition.X + (int)(change.X * 3.125), NorthDoorPosition.Y + (int)(change.Y * 3.125), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change, Vector2 initialPos)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle((int)(NorthDoorPosition.X + initialPos.X+change.X * 3.125), (int)(NorthDoorPosition.Y + initialPos.Y+change.Y * 3.125), 100, 94);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
