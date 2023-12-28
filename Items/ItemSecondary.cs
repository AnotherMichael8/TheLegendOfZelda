using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items.ItemSprites;
using Sprint2_Attempt3.Sounds;
using System.Runtime.ConstrainedExecution;

namespace Sprint2_Attempt3.Items
{
    public abstract class ItemSecondary : IItem
    {
        protected IItemSprite sprite;
        protected Rectangle Position;
        protected Rectangle sourceRectangle;
        protected int count;
        protected const int AnimateRate = 5; 
        public bool spawned { get; 
            set; }
        public bool exists { get; set; }
        public Rectangle position { get { return Position; } }
        private readonly Rectangle noHitBox = new Rectangle(0, 0, 0, 0);

        public ItemSecondary() {
            count = 25;
        }
        public void Spawn() {
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            exists = true;
        }
        public void Spawn(Rectangle position)
        {
            Position.X = position.X;
            Position.Y = position.Y;
            sprite = ItemSpriteFactory.Instance.CreateSpawnItemSprite();
            exists = true;
        }
        public virtual void Collect() { 
            exists = false;
            CollisionManager.GameObjectList.Remove(this);
            InventoryController.IncrementCount(this.GetType().Name);
        }
        public void Despawn()
        {
            exists = false;
            CollisionManager.GameObjectList.Remove(this);
        }
        public abstract void Update();
        public virtual void Draw(SpriteBatch spriteBatch) {
            if (exists)
            {
                if (!spawned)
                {
                    ((IAnimatedItemSprite)sprite).Draw(spriteBatch, Position, sourceRectangle);
                    count--;
                }
                else {
                    sprite.Draw(spriteBatch, Position);
                }
            }
        }
        public Rectangle GetHitBox()
        {
            if (spawned)
            {
                return Position;
            }
            else
            {
                return noHitBox;
            }
        }

    }
}
