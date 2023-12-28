using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    internal class DungeonRoomSprite
    {
        Texture2D texture;
        public DungeonRoomSprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle, Color color)
        {
            spriteBatch.Draw(
                texture,
                new Rectangle(0, 175, Globals.ScreenWidth, 550),
                sourceRectangle,
                color,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }
        public void Draw(SpriteBatch spriteBatch, Rectangle sourceRectangle,Vector2 change)
        {
            //Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height - (int)change.Y);
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height - (int)change.Y);
            Rectangle destinationRectangle = new Rectangle(0 + (int)(change.X * 3.125), 175 + (int)(change.Y * 3.125), Globals.ScreenWidth - (int)(3.125 * change.X), 550 - (int)(3.125 * change.Y));

            //System.Diagnostics.Debug.WriteLine("x:" + (int)change.X);
            //System.Diagnostics.Debug.WriteLine("width:" + (Globals.ScreenWidth - (int)change.X));
            spriteBatch.Draw(
                texture,
               destinationRectangle,
                newSourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }

        public void DrawCurrentRoom(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            //Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height - (int)change.Y);
            // Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height);
            Rectangle newSourceRectangle = sourceRectangle;
           // Rectangle destinationRectangle = new Rectangle(0 + (int)(change.X * 3.125), 175 + (int)(change.Y * 3.125), Globals.ScreenWidth - (int)(3.125 * change.X), 550 - (int)(3.125 * change.Y));
            Rectangle destinationRectangle = new Rectangle(0 + (int)(change.X * 3.125), 175 + (int)(change.Y * 3.125), Globals.ScreenWidth, 550 );

            spriteBatch.Draw(
                texture,
               destinationRectangle,
                newSourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                SpriteEffects.None,
                0f
            );
        }

        public void DrawNextRoom(SpriteBatch spriteBatch, Rectangle sourceRectangle, Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle();
            Rectangle newDestinationRectangle = new Rectangle();
            if (change.Y == 0&&change.X>0)
            {
                //newSourceRectangle = new Rectangle(sourceRectangle.X + sourceRectangle.Width - (int)change.X, sourceRectangle.Y, (int)change.X, sourceRectangle.Height);
                newSourceRectangle = sourceRectangle;
                //newDestinationRectangle = new Rectangle(0, 175, (int)(change.X * 3.125), 550);
                newDestinationRectangle = new Rectangle(-Globals.ScreenWidth+ (int)(change.X * 3.125), 175, Globals.ScreenWidth, 550);
            }
            else if((change.Y == 0 && change.X < 0))
            {
                newSourceRectangle = sourceRectangle;
                newDestinationRectangle = new Rectangle(Globals.ScreenWidth+ (int)(change.X * 3.125), 175, Globals.ScreenWidth, 550);
            }
            else if (change.Y>0)
            {
                newSourceRectangle = sourceRectangle;
                newDestinationRectangle = new Rectangle(0, 175-Globals.ScreenHeight+Globals.YOffset+(int)(change.Y*3.125), Globals.ScreenWidth, 550);
            }
            else
            {
                newSourceRectangle = sourceRectangle;
                newDestinationRectangle = new Rectangle(0, 175 + Globals.ScreenHeight - Globals.YOffset + (int)(change.Y * 3.125), Globals.ScreenWidth, 550);
            }


            spriteBatch.Draw(
            texture,
            newDestinationRectangle,
            newSourceRectangle,
            Color.White,
            0f,
            new Vector2(0, 0),
            SpriteEffects.None,
            0f
        ); ;
        }
    }
}
