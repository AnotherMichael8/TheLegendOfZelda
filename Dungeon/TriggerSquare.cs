using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class TriggerSquare : IGameObject
    {
        protected Rectangle position;
        private Rectangle sourceRectangle = new Rectangle(0, 0, 15, 15);
        private TriggerSquareSprite sprite;
        private bool trigger;
        public TriggerSquare(int x, int y)
        {
            position = new Rectangle(x, y, 45, 45);
            sprite = DungeonSpriteFactory.Instance.CreateTriggerSquareSprite();
        }

        public Rectangle GetHitBox()
        {
            return position;
        }

        public void Start() 
        {
            trigger = true;
        }
        public bool isTriggered()
        {
            return trigger;
        }

        public void End()
        {
            trigger = false;
        }
        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, position.X, position.Y, sourceRectangle);
        }
    }
}
