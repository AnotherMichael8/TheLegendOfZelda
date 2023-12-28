using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class WhiteStairRoom : IDungeonRoom
    {
        private DungeonRoomSprite sprite;
        private static Rectangle WhiteRoomScrRectangle = new Rectangle(1, 1, 255, 159);

        public WhiteStairRoom() { 
            sprite = DungeonSpriteFactory.Instance.CreateWhiteStairRoomSprite();
    }

        public void Draw(SpriteBatch spriteBatch, Color color) {
            sprite.Draw(spriteBatch, WhiteRoomScrRectangle, color);
        }
    }
}
