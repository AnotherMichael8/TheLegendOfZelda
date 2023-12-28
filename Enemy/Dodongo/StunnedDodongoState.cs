using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy.Dodongo
{
    internal class StunnedDodongoState : IEnemyState
    {
        private Dodongo dodongo;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private Random random;
        private int direction;
        private int stunCounter;

        public StunnedDodongoState(Dodongo dodongo)
        {
            this.dodongo = dodongo;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftDodongoSprite();
            sourceRectangle = Dodongo.Dodongos[2];
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            currentFrame = 0;
            random = new Random();
            direction = random.Next(0, 3);
            stunCounter = 0;
        }
        public void ChangeDirection()
        {
            if (stunCounter == 100) { 
                direction = random.Next(0, 3);
                switch (direction)
                {
                    case 0:
                        dodongo.State = new MovingDownDodongoState(dodongo);
                        break;
                    case 1:
                        dodongo.State = new MovingUpDodongoState(dodongo);
                        break;
                    case 2:
                        dodongo.State = new MovingRightDodongoState(dodongo);
                        break;
                    case 3:
                        dodongo.State = new MovingLeftDodongoState(dodongo);
                        break;
                }
            }
        }
        public void ChangeAttackedStatus()
        {
            dodongo.State = new MovingLeftAttackedDodongoState(dodongo);
        }
        public void Update()
        {
            stunCounter++;
            ChangeDirection();
            dodongo.Position = new Rectangle(dodongo.X, dodongo.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, dodongo.X, dodongo.Y, sourceRectangle);
        }
    }
}