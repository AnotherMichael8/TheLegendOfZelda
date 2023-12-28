using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Items.ItemSprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    internal class HealthController
    {
        private static int MaxHeartContainers = 18;
        private static IItemSprite[] heartSprites = new IItemSprite[] { ItemSpriteFactory.Instance.CreateEmptyHeartSprite(), ItemSpriteFactory.Instance.CreateHalfHeartSprite(), ItemSpriteFactory.Instance.CreateFullHeartSprite() };
        public HealthController() { }
        private static Rectangle GetDestinationBox(int i)
        {
            int y = InventoryController.destRectangle.Y + 630;
            if (i > 8) { y += 25;  }
            return new Rectangle(InventoryController.destRectangle.X + (552 + ((i % 9) * 26)), y, 26, 25);
        }
        private static int GetSpriteIndex(float hearts, float containers) {
            int index = 0;
            if (hearts >= 1) { index = 2; }
            else if (hearts > 0) { index = 1; }
            return index; 
        }
        public static void DrawHearts(SpriteBatch spriteBatch) {
            float hearts = InventoryController.hearts;
            float containers = InventoryController.heartContainers;
            for (int i = 0; i < containers; i++)
            {
                int index = GetSpriteIndex(hearts, containers);
                heartSprites[index].Draw(spriteBatch, GetDestinationBox(i));
                hearts -= (float)(index / 2.0);
            }
        }
    }
}
