using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Rupee : ItemSecondary 
    {
        private static Rectangle[] rupees = new Rectangle[] { new Rectangle(72, 0, 8, 16), new Rectangle(72, 16, 8, 16) };
        public Rupee(Vector2 position, bool exists)
        {
            this.sourceRectangle = rupees[0];
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }

        public override void Update()
        {
            if (this.count <= 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateRupeeSprite();
                count = 0;
                spawned = true;
            }
            if (spawned)
            {
                count++;
                sourceRectangle = rupees[Globals.FindIndex(count % (rupees.Length * AnimateRate), AnimateRate, rupees.Length)];
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
            SoundFactory.PlaySound(SoundFactory.Instance.getRupee);
            CollisionManager.GameObjectList.Remove(this);
            if (InventoryController.RupeeCount < 99)
                InventoryController.RupeeCount++;
        }
    }
}
