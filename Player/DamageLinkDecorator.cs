using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Player
{
    public class DamageLinkDecorator : ILink
    {
        private ILink decoratedLink;
        private static int timer;
        public List<ILinkProjectile> Items { get; set; }
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; } }
        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }
        private const int invincabilityTimer = 60;
        public DamageLinkDecorator(ILink decoratedLink)
        {
            this.decoratedLink = decoratedLink;
            Items = decoratedLink.Items;
            position = decoratedLink.Position;
            SetDecorator(this);
        }
        public void GetDamaged(ICollision side)
        {
            if (timer < 10)
            {
                if(InventoryController.hearts != 0.5f)
                    Knockback(side);

                timer = invincabilityTimer;
                InventoryController.hearts -= .5f;
                if (InventoryController.hearts <= 0)
                {
                    if (InventoryController.UsingFairy)
                    {
                        InventoryController.hearts++;
                        InventoryController.UsingFairy = false;
                    }
                    else 
                    { 
                        Kill();
                        SoundFactory.PlaySound(SoundFactory.Instance.linkDie);
                        timer = 0;
                    }
                }
                else if (InventoryController.hearts <= 1)
                    SoundFactory.PlaySound(SoundFactory.Instance.lowHealth);
            }
        }
        public void Knockback(ICollision side) 
        {
            decoratedLink.Knockback(side);
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
            decoratedLink.Attack();
        }
        public void UseBomb()
        {
            decoratedLink.UseBomb();
        }
        public void UseArrow()
        {
            decoratedLink.UseArrow();
        }
        public void UseBoomerang()
        {
            decoratedLink.UseBoomerang();
        }
        public void UseBlueBoomerang()
        {
            decoratedLink.UseBlueBoomerang();
        }
        public void UseBlueArrow()
        {
            decoratedLink.UseBlueArrow();
        }
        public void UseFire()
        {
            decoratedLink.UseFire();
        }
        public void SetDecorator(ILink link)
        {
            decoratedLink.SetDecorator(this);
        }
        public void Kill()
        {
            decoratedLink.Kill();
        }
        public void Update()
        {
            timer--;
            if (timer == 0)
                RemoveDecorator();

            decoratedLink.Update();
        }
        public void RemoveDecorator()
        {
            decoratedLink.RemoveDecorator();
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (timer % 8 < 4)
                decoratedLink.Draw(spriteBatch, Color.OrangeRed);
            
            else
                decoratedLink.Draw(spriteBatch, Color.SandyBrown);
        }
        public Rectangle GetHitBox()
        {
            return decoratedLink.GetHitBox();
        }
        public void CollectBow()
        {
            decoratedLink.CollectBow();
        }
        public void CollectTriForce()
        {
            decoratedLink.CollectTriForce();
        }
    }
}