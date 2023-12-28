using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Inventory;
using System.Runtime.CompilerServices;
using System.Threading;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class Fairy : ItemSecondary 
    {
        private static Rectangle[] fairies = new Rectangle[] { new Rectangle(40, 0, 8, 16), new Rectangle(48, 0, 8, 16) };
        private int changeMovementTimer;
        private int timer;
        private int randMovementX;
        private int randMovementY;
        public Fairy(Vector2 position, bool exists)
        {
            this.sourceRectangle = fairies[0];
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            changeMovementTimer = 40;
            timer = 0;
            randMovementX = 0;
            randMovementY = 0;
        }

        public override void Update()
        {
            if (this.count <= 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateFairySprite();
                spawned = true;
                count = 0;
            }
            if (spawned)
            {
                count++;
                sourceRectangle = fairies[Globals.FindIndex(count % (fairies.Length * AnimateRate), AnimateRate, fairies.Length)];
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
            base.Collect();
            InventoryController.UseItem("Fairy");
            if (changeMovementTimer <= 0)
            {
                randMovementX = new Random().Next(-1, 2) * 2;
                randMovementY = new Random().Next(-1, 2) * 2;
                changeMovementTimer = 40;
            }

            Position.X += randMovementX;
            Position.Y += randMovementY;

            changeMovementTimer--;
            timer++;

            if(timer >= 2000)
            {
                Despawn();
            }
        }
    }
}
