using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Player.LinkStates;
using Sprint2_Attempt3.Screens;

namespace Sprint2_Attempt3.Player
{
    public class DeadLink : ILink
    {
        //private Game1 game;
        private ILink decoratedLink;
        private int timer;
        public List<ILinkProjectile> Items { get; set; }
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; } }

        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }

        private Game1 game;
        public DeadLink(ILink decoratedLink, Game1 game)
        {
            this.decoratedLink = decoratedLink;
            //this.game = game;
            Items = decoratedLink.Items;
            position = decoratedLink.Position;
            //SetDecorator(this);
            timer = 0;
            this.game = game;
        }

        public void GetDamaged(ICollision side)
        {
        }
        public void Knockback(ICollision side)
        {
        }
        public void MoveLeft()
        {
            decoratedLink.MoveLeft();
        }
        public void MoveRight()
        {
            decoratedLink.MoveRight();
        }
        public void MoveUp()
        {
            decoratedLink.MoveUp();
        }
        public void MoveDown()
        {
            decoratedLink.MoveDown();
        }
        public void BecomeIdle()
        {
            decoratedLink.BecomeIdle();
        }
        public void Attack()
        {
        }
        public void UseBomb()
        {
        }
        public void UseArrow()
        {
        }
        public void UseBoomerang()
        {
        }
        public void UseBlueBoomerang()
        {
        }
        public void UseBlueArrow()
        {
        }
        public void UseFire()
        {
        }
        public void SetDecorator(ILink link)
        {
            decoratedLink.SetDecorator(this);
        }
        public void Kill()
        {
        }

        public void Update()
        {
            timer++;
            if (timer <= 80)
            {
                if(timer == 1)
                {
                    game.deathAnimationActive = true;
                }
                if (timer % 20 < 5)
                {
                    decoratedLink.MoveDown();
                }
                else if (timer % 20 < 10)
                {
                    decoratedLink.MoveRight();
                }
                else if (timer % 20 < 15)
                {
                    decoratedLink.MoveUp();
                }
                else if (timer % 20 < 20)
                {
                    decoratedLink.MoveLeft();
                }
                decoratedLink.BecomeIdle();
            }
            else if (timer == 110)
            {
                decoratedLink.State = new KilledLinkState((Link)decoratedLink);
            }
            else if (timer == 160)
            {
                game.gameState = Game1.GameState.linkDead;
                game.screenSprite = ScreenSpriteFactory.Instance.CreateDeathScreen();
            }
            decoratedLink.Update();
        }

        public void RemoveDecorator()
        {
            decoratedLink.RemoveDecorator();
        }
        public void CollectBow()
        {

        }
        public void CollectTriForce()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (timer <= 80)
            {
                decoratedLink.Draw(spriteBatch, Color.White);
            }
            else
            {
                decoratedLink.Draw(spriteBatch, Color.DarkGray);
            }
        }
        public Rectangle GetHitBox()
        {
            return decoratedLink.GetHitBox();
        }
    }
}
