using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class TriforcePiece : ItemSecondary 
    {
        private static Rectangle[] triforces = new Rectangle[] { new Rectangle(275, 3, 10, 10), new Rectangle(275, 19, 10, 10) };
        public TriforcePiece(Vector2 position, bool exists)
        {
            this.sourceRectangle = triforces[0];
            this.Position = new Rectangle((int)position.X, (int)position.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            this.exists = exists;
            this.spawned = false;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
        }

        public override void Update()
        {
            if (this.count <= 0)
            {
                sprite = ItemSpriteFactory.Instance.CreateTriforceSprite();
                spawned = true;
                count = 0;
            }
            if (spawned)
            {
                count++;
                sourceRectangle = triforces[Globals.FindIndex(count % (triforces.Length * AnimateRate), AnimateRate, triforces.Length)];
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
            SoundFactory.PlaySound(SoundFactory.Instance.triforce);
        }
    }
}
