using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Bow : ItemSecondary 
    {
        private static Rectangle src = new Rectangle(144, 0, 8, 16);
        public Bow(Vector2 position, bool exists)
        {
            this.sourceRectangle = src;
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }
        public override void Update()
        {
            if (count <= 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateBowSprite();
                spawned = true;
            }
        }

        public override void Collect()
        {
            InventoryController.HasBow = true;
            exists = false;
            SoundFactory.PlaySound(SoundFactory.Instance.getItem);
            CollisionManager.GameObjectList.Remove(this);
        }
    }
}
