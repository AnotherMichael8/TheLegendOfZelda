using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Items.ItemSprites;

namespace Sprint2_Attempt3.Items
{
    public class ItemSpriteFactory
    {
        private static Texture2D itemTexture;
        private static Texture2D inventoryTexture;
        private static ItemSpriteFactory instance = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private ItemSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            itemTexture = content.Load<Texture2D>("Items");
            inventoryTexture = content.Load<Texture2D>("Inventory");
        }

        public IItemSprite CreateSpawnItemSprite()
        {
            return new SpawnItemSprite(itemTexture);
        }
        public IItemSprite CreateArrowSprite()
        {
            return new ArrowSprite(itemTexture);
        }
        public IItemSprite CreateBlueArrowSprite()
        {
            return new BlueArrowSprite(itemTexture);
        }
        public IItemSprite CreateBlueCandleSprite()
        {
            return new BlueCandleSprite(itemTexture);
        }
        public IItemSprite CreateBluePotionSprite()
        {
            return new BluePotionSprite(itemTexture);
        }
        public IItemSprite CreateBombSprite()
        {
            return new BombSprite(itemTexture);
        }
        public IItemSprite CreateBoomerangSprite()
        {
            return new BoomerangSprite(itemTexture);
        }
        public IItemSprite CreateBlueBoomerangSprite()
        {
            return new BlueBoomerangSprite(itemTexture);
        }
        public IItemSprite CreateBowSprite()
        {
            return new BowSprite(itemTexture);
        }
        public IItemSprite CreateClockSprite()
        {
            return new ClockSprite(itemTexture);
        }
        public IItemSprite CreateCompassSprite()
        {
            return new CompassSprite(itemTexture);
        }
        public IItemSprite CreateFairySprite()
        {
            return new FairySprite(itemTexture);
        }
        public IItemSprite CreateHeartSprite()
        {
            return new HeartSprite(itemTexture);
        }
        public IItemSprite CreateHeartContainerSprite()
        {
            return new HeartContainerSprite(itemTexture);
        }
        public IItemSprite CreateKeySprite()
        {
            return new KeySprite(itemTexture);
        }
        public IItemSprite CreateMapSprite()
        {
            return new MapSprite(itemTexture);
        }
        public IItemSprite CreateRupeeSprite()
        {
            return new RupeeSprite(itemTexture);
        }
        public IItemSprite CreateTriforceSprite()
        {
            return new TriforceSprite(itemTexture);
        }

        public IItemSprite CreateGreenTriforceMarkerSprite() {
            return new GreenTriforceMarkerSprite(inventoryTexture);
        }
        public IItemSprite CreateRedTriforceMarkerSprite()
        {
            return new RedTriforceMarkerSprite(inventoryTexture);
        }
        public IItemSprite CreatePlayerMarkerSprite()
        {
            return new PlayerMarkerSprite(inventoryTexture);
        }
        public IItemSprite CreateMenuCursorSprite()
        {
            return new MenuCursorSprite(inventoryTexture);
        }
        public IItemSprite CreateMapLayoutSprite()
        {
            return new MapLayoutSprite(inventoryTexture);
        }
        public IItemSprite CreateEmptyHeartSprite()
        {
            return new EmptyHeartSprite(inventoryTexture);
        }
        public IItemSprite CreateHalfHeartSprite()
        {
            return new HalfHeartSprite(inventoryTexture);
        }
        public IItemSprite CreateFullHeartSprite()
        {
            return new FullHeartSprite(inventoryTexture);
        }
        public IItemSprite CreateMapColorSprite()
        {
            return new MapColorSprite(inventoryTexture);
        }
        public IItemSprite CreateDigitSprite()
        {
            return new DigitSprite(inventoryTexture);
        }
        public IItemSprite CreateInventoryMenuSprite()
        {
            return new InventoryMenuSprite(inventoryTexture);
        }
    }
}
