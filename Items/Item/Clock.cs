using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Clock : ItemSecondary
    {
        private static Rectangle src = new Rectangle(57, 0, 13, 17);
        public Clock(Vector2 position, bool exists)
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
                sprite = ItemSpriteFactory.Instance.CreateClockSprite();
                spawned = true;
            }
        }
        public override void Collect()
        {
            exists = false;
            CollisionManager.GameObjectList.Remove(this);
            SoundFactory.PlaySound(SoundFactory.Instance.getItem);
            RoomSecondary.ClockUsed = true;
        }
    }
}
