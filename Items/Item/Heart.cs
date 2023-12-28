using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Heart : ItemSecondary 
    {
        private static Rectangle[] hearts = new Rectangle[] { new Rectangle(0, 0, 7, 8), new Rectangle(0, 8, 7, 8) };
        public Heart(Vector2 position, bool exists)
        {
            this.sourceRectangle = hearts[0];
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }

        public override void Update()
        {
            if (this.count <= 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateHeartSprite();
                spawned = true;
                count = 0;
            }

            if (spawned)
            {
                count++;
                sourceRectangle = hearts[Globals.FindIndex(count % (hearts.Length * AnimateRate), AnimateRate, hearts.Length)];
                Position.Width = (int)(sourceRectangle.Width * Globals.scale);
                Position.Height = (int)(sourceRectangle.Height * Globals.scale);
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (exists)
            {
                ((IAnimatedItemSprite)sprite).Draw(spriteBatch, Position, sourceRectangle);
                if (!spawned)
                {
                    count--;
                }
            }
        }

        public override void Collect()
        {
            exists = false;
            CollisionManager.GameObjectList.Remove(this);
            SoundFactory.PlaySound(SoundFactory.Instance.getHeart);
            if (InventoryController.heartContainers - InventoryController.hearts > 0) {
                if (InventoryController.heartContainers - InventoryController.hearts > .5)
                {
                    InventoryController.hearts++;
                }
                else
                {
                    InventoryController.hearts += .5f;
                }
            }
        }
    }
}
