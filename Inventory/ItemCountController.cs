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
    internal class ItemCountController
    {
        private static IAnimatedItemSprite sprite = (IAnimatedItemSprite)ItemSpriteFactory.Instance.CreateDigitSprite();
        private static String ItemsCount = "";
        private ItemCountController() { }
        private static Rectangle GetDigit(char i)
        {
            Rectangle rectangle = new Rectangle(271 + ((i - 48) * 9), 131, 8, 8);
            if (i == ' ') { rectangle = new Rectangle(); }
            return rectangle;
        }
        private static void UpdateItemCounts()
        {
            ItemsCount = InventoryController.RupeeCount.ToString();
            if (ItemsCount.Length % 2 != 0)
            {
                ItemsCount += ' ';
            }

            String RupeeCount = InventoryController.KeyCount.ToString();
            if (RupeeCount.Length % 2 != 0)
            {
                RupeeCount += ' ';
            }
            ItemsCount += RupeeCount;

            String BombCount = InventoryController.GetCount("Bomb").ToString();
            if (BombCount.Length % 2 != 0)
            {
                BombCount += ' ';
            }
            ItemsCount += BombCount;
        }

        public static void DrawCounts(SpriteBatch spriteBatch) {
            UpdateItemCounts();
            int i = 0;
            for (int y = 581; y <= 655; y = y == 581 ? y + 48 : y + 26)
            {
                for (int x = 326; x <= 352; x += 26)
                {
                    sprite.Draw(spriteBatch, new Rectangle(InventoryController.destRectangle.X + x, InventoryController.destRectangle.Y + y, 26, 26), GetDigit(ItemsCount.ElementAt(i)));
                    i++;
                }
            }
        }
    }
}
