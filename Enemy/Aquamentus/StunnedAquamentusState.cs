using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using System.Runtime.CompilerServices;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class StunnedAquamentusState : IEnemyState
    {
        private Aquamentus aquamentus;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public static Rectangle[] rectangles = new Rectangle[] { new Rectangle(51, 0, 24, 33), new Rectangle(76, 0, 24, 33) };

        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private int stunTimer;

        public StunnedAquamentusState(Aquamentus aquamentus)
        {
            this.aquamentus = aquamentus;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            sourceRectangle = rectangles[0];
            this.aquamentus.Position = new Rectangle(this.aquamentus.X, this.aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            //implement
            elaspedFrameCount = 0;
            endFrame = 100;
            stunTimer = 0;
        }
        public void ChangeDirection()
        {
            aquamentus.FireballPosition = new Vector2(aquamentus.X, aquamentus.Y);
            aquamentus.Fireball = new AquamentusFireball(aquamentus.FireballPosition);
            ((AquamentusFireball)aquamentus.Fireball).GenerateLeft();
            aquamentus.State = new AttackWithFireballLeftState(aquamentus);
        }

        public void ChangeAttackedStatus()
        {
            if(stunTimer >= 100)
                aquamentus.State = new MovingAttackedLeftAquamentusState(aquamentus);
        }   
        public void Update()
        {
            stunTimer++;
            ChangeDirection();
            aquamentus.Position = new Rectangle(aquamentus.X, aquamentus.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, aquamentus.X, aquamentus.Y, sourceRectangle);
        }
    }
}

