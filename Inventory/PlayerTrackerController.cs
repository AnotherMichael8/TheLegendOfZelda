using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    internal class PlayerTrackerController
    {
        private static int x = InventoryController.destRectangle.X;
        private static int y = InventoryController.destRectangle.Y;
        private static IItemSprite sprite = ItemSpriteFactory.Instance.CreatePlayerMarkerSprite();
        private static Rectangle playerTracker = new Rectangle(132 + InventoryController.destRectangle.X, 670 + InventoryController.destRectangle.Y, 9, 9);
        public PlayerTrackerController() { }

        public static void UpdatePlayerTrackerPosition(int mapX, int mapY)
        {
            playerTracker.X = 2 + mapX * 26 + x;
            playerTracker.Y = 527 + mapY * 13 + y;
        }
        public static void DrawPlayerTracker(SpriteBatch spriteBatch) {
            sprite.Draw(spriteBatch, playerTracker);
        }
        public static void ShiftUp()
        {
            playerTracker.Y -= InventoryController.AnimateRate;
        }
        public static void ShiftDown() 
        {
            playerTracker.Y += InventoryController.AnimateRate;
        }
    }
}
