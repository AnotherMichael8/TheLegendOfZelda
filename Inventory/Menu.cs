using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemSprites;
using System;


namespace Sprint2_Attempt3.Inventory
{
    internal class Menu
    {
        private static String[] ItemMenuStrings = { "Boomerang", "Bomb", "Arrow", "BlueCandle", "BlueBoomerang", "BlueArrow", "BluePotion", "Fairy" };
        private static int ItemAIndex = 1;
        private static int ItemBIndex = 0;
        private static int ItemSelectedIndex = 0;

        private static IItemSprite cursor = ItemSpriteFactory.Instance.CreateMenuCursorSprite();
        private static IItemSprite ItemA = ItemSpriteFactory.Instance.CreateBombSprite();
        private static IItemSprite ItemB = ItemSpriteFactory.Instance.CreateBoomerangSprite();
        private static IItemSprite ItemSelected = ItemSpriteFactory.Instance.CreateBoomerangSprite();

        private static Rectangle ItemBDestRectangle = new Rectangle(InventoryController.destRectangle.X + 401, InventoryController.destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemADestRectangle = new Rectangle(InventoryController.destRectangle.X + 477, InventoryController.destRectangle.Y + 606, 26, 49);
        private static Rectangle ItemSelectedDestRectangle = new Rectangle(InventoryController.destRectangle.X + 212, InventoryController.destRectangle.Y + 145, 26, 49);
        private static Rectangle CursorDestRectangle = new Rectangle(InventoryController.destRectangle.X + 402, InventoryController.destRectangle.Y + 145, 49, 49);
        public Menu() { }

        public static void Draw(SpriteBatch spriteBatch) {
            if (InventoryController.GetCount(ItemMenuStrings[ItemAIndex]) > 0)
                ItemA.Draw(spriteBatch, ItemADestRectangle);
            if (InventoryController.GetCount(ItemMenuStrings[ItemBIndex]) > 0)
                ItemB.Draw(spriteBatch, ItemBDestRectangle);
            if (InventoryController.GetCount(ItemMenuStrings[ItemSelectedIndex]) > 0)
                ItemSelected.Draw(spriteBatch, ItemSelectedDestRectangle);
            cursor.Draw(spriteBatch, CursorDestRectangle);
        }

        public static void ShiftCursorRight()
        {
            if (CursorDestRectangle.X < 627 && ItemSelectedIndex <= 6)
            {
                CursorDestRectangle.X += 75;
                ItemSelectedIndex++;
                ItemSelected = InventoryController.GetSprite(ItemMenuStrings[ItemSelectedIndex]);
            }
        }
        public static void ShiftCursorLeft()
        {
            if (CursorDestRectangle.X > 402 && ItemSelectedIndex >= 1)
            {
                CursorDestRectangle.X -= 75;
                ItemSelectedIndex--;
                ItemSelected = InventoryController.GetSprite(ItemMenuStrings[ItemSelectedIndex]);
            }
        }
        public static void ShiftCursorUp()
        {
            if (CursorDestRectangle.Y > 145 && ItemSelectedIndex >= 4)
            {
                CursorDestRectangle.Y -= 50;
                ItemSelectedIndex -= 4;
                ItemSelected = InventoryController.GetSprite(ItemMenuStrings[ItemSelectedIndex]);
            }
        }
        public static void ShiftCursorDown()
        {
            if (CursorDestRectangle.Y < 195 && ItemSelectedIndex <= 3)
            {
                CursorDestRectangle.Y += 50;
                ItemSelectedIndex += 4;
                ItemSelected = InventoryController.GetSprite(ItemMenuStrings[ItemSelectedIndex]);
            }
        }

        public static void SetItemA()
        {
            if (ItemSelectedIndex != ItemBIndex)
            {
                ItemAIndex = ItemSelectedIndex;
                ItemA = InventoryController.GetSprite(ItemMenuStrings[ItemAIndex]);
            }
        }
        public static void SetItemB()
        {
            if (ItemSelectedIndex != ItemAIndex)
            {
                ItemBIndex = ItemSelectedIndex;
                ItemB = InventoryController.GetSprite(ItemMenuStrings[ItemBIndex]);
            }
        }

        public static void UseAItem() { InventoryController.UseItem(ItemMenuStrings[ItemAIndex]); }
        public static void UseBItem() { InventoryController.UseItem(ItemMenuStrings[ItemBIndex]); }
        public static void ShiftUp() {
            ItemBDestRectangle.Y -= InventoryController.AnimateRate;
            ItemADestRectangle.Y -= InventoryController.AnimateRate;
            ItemSelectedDestRectangle.Y -= InventoryController.AnimateRate;
            CursorDestRectangle.Y -= InventoryController.AnimateRate;
        }
        public static void ShiftDown() {
            ItemBDestRectangle.Y += InventoryController.AnimateRate;
            ItemADestRectangle.Y += InventoryController.AnimateRate;
            ItemSelectedDestRectangle.Y += InventoryController.AnimateRate;
            CursorDestRectangle.Y += InventoryController.AnimateRate;
        }
    }
}
