using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class MovingUpKeeseState : IEnemyState
    {
        private Keese keese;
        private IEnemySprite sprite;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;
        private int distance;
      
        public MovingUpKeeseState(Keese keese)
        {
            this.keese = keese;
            this.currentFrame = 0;
            this.sprite = EnemySpriteFactory.Instance.CreateKeeseSprite();
            this.sourceRectangle = Keese.Keeses[0];
            keese.Position = new Rectangle(keese.X, keese.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            random = new Random();
        }
        public void ChangeDirection()
        {
            direction = random.Next(0, 4);
            switch (direction)
            {
                case 0:
                    keese.State = new MovingLeftKeeseState(keese);
                    break;
                case 1:
                    keese.State = new MovingDownKeeseState(keese);
                    break;
                case 2:
                    keese.State = new MovingRightKeeseState(keese);
                    break;
                case 3:
                    keese.State = new MovingUpKeeseState(keese);
                    break;
            }
        }
        public void ChangeAttackedStatus()
        {
            keese.State = new DeathAnimationState(keese);
        }
        public void Update()
        {
            distance = random.Next(0, 5);
            currentFrame++;
            sourceRectangle = Keese.Keeses[Globals.FindIndex(currentFrame % (Keese.Keeses.Length * keese.AnimateRate), keese.AnimateRate, Keese.Keeses.Length)];
            keese.Y -= distance;
            keese.X += random.Next(0, 4) - 2;
            keese.Position = new Rectangle(keese.X, keese.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, keese.X, keese.Y, sourceRectangle);
        }
    }
}
