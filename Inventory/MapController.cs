using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    internal class MapController
    {
        private static int x = InventoryController.destRectangle.X;
        private static int y = InventoryController.destRectangle.Y;
        private static IItemSprite sprite = ItemSpriteFactory.Instance.CreateMapColorSprite();
        private static List<int> UnvisitedRooms = Enumerable.Range(1, 17).ToList();

        private static Dictionary<int, Rectangle> MapRoomDestRectangles = new Dictionary<int, Rectangle>() {
            { 0, new Rectangle(x + 477, y + 435, 25, 24) },
            { 1, new Rectangle(x + 452, y + 435, 25, 24) },
            { 2, new Rectangle(x + 502, y + 435, 25, 24) },
            { 3, new Rectangle(x + 477, y + 412, 25, 24) },
            { 4, new Rectangle(x + 452, y + 389, 25, 24) },
            { 5, new Rectangle(x + 477, y + 389, 25, 24) },
            { 6, new Rectangle(x + 502, y + 389, 25, 24) },
            { 7, new Rectangle(x + 428, y + 365, 25, 24) },
            { 8, new Rectangle(x + 452, y + 365, 25, 24) },
            { 9, new Rectangle(x + 477, y + 365, 25, 24) },
            { 10, new Rectangle(x + 502, y + 365, 25, 24) },
            { 11, new Rectangle(x + 527, y + 365, 25, 24) },
            { 12, new Rectangle(x + 477, y + 341, 25, 24) },
            { 13, new Rectangle(x + 527, y + 341, 25, 24) },
            { 14, new Rectangle(x + 552, y + 341, 25, 24) },
            { 15, new Rectangle(x + 452, y + 317, 25, 24) },
            { 16, new Rectangle(x + 452, y + 317, 25, 24) },
            { 17, new Rectangle(x + 477, y + 317, 25, 24) }
        };
        public MapController() { }
        public static void VisitRoom(int i) { UnvisitedRooms.Remove(i); }

        public static void DrawMap(SpriteBatch spriteBatch) {
            foreach(int room in UnvisitedRooms) {
                sprite.Draw(spriteBatch, MapRoomDestRectangles[room]);
            }
        }
        public static void ShiftUp() {
            for(int i = 0; i < MapRoomDestRectangles.Count; i++) {
                MapRoomDestRectangles[i] = new Rectangle(MapRoomDestRectangles[i].X, MapRoomDestRectangles[i].Y - InventoryController.AnimateRate, MapRoomDestRectangles[i].Width, MapRoomDestRectangles[i].Height);
            }
        }
        public static void ShiftDown() {
            for (int i = 0; i < MapRoomDestRectangles.Count; i++)
            {
                MapRoomDestRectangles[i] = new Rectangle(MapRoomDestRectangles[i].X, MapRoomDestRectangles[i].Y + InventoryController.AnimateRate, MapRoomDestRectangles[i].Width, MapRoomDestRectangles[i].Height);
            }
        }
    }
}
