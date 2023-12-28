using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System.Collections.Generic;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
namespace Sprint2_Attempt3.Player
{
    public class Link : ILink
    {
        private Vector2 position;
        public Vector2 Position { get { return position; } set { position = value; } } 
        public ILinkSprite Sprite { get; set; }
        public ILinkState State { get; set; }
        public List<ILinkProjectile> Items { get; set; }
        private Game1 game;
        private bool linkDead;
        public Link(Game1 game)
        {
            position.X = 375;
            position.Y = 300;
            this.game = game;
            State = new DownIdleLinkState(this);
            Items = new List<ILinkProjectile>();
            linkDead = false;
        }
        public void GetDamaged(ICollision side)
        {
            SetDamageLinkCommand damage = new SetDamageLinkCommand(this);
            damage.Execute(side);
        }
        public void Knockback(ICollision side)
        {
            if (side is BottomCollision)
                State = new KnockbackDownLinkState(this);
            else if (side is LeftCollision)
                State = new KnockbackLeftLinkState(this);
            else if (side is RightCollision)
                State = new KnockbackRightLinkState(this);
            else
                State = new KnockbackUpLinkState(this);
        }
        public void BecomeIdle()
        {
            State.BecomeIdle();
        }
        public void MoveRight()
        {
            State.MoveRight();
        }
        public void MoveLeft()
        {
            State.MoveLeft();
        }
        public void MoveUp()
        {
            State.MoveUp();
        }
        public void MoveDown()
        {
            State.MoveDown();
        }
        public void Attack()
        {
            State.Attack();
        }
        public void UseBomb()
        { 
            State.UseBomb();
        }
        public void UseArrow()
        {
            State.UseArrow();
        }
        public void UseBoomerang()
        {
            State.UseBoomerang();
        }
        public void UseBlueBoomerang()
        {
            State.UseBlueBoomerang();
        }
        public void UseBlueArrow()
        {
            State.UseBlueArrow();
        }
        public void UseFire()
        {
            State.UseFire();
        }
        public void CollectBow()
        {
            State.CollectBow();
        }
        public void CollectTriForce()
        {
            State.CollectTriForce();
        }
        public void Kill()
        {
            linkDead = true;
            SetDecorator(new DeadLink(this, game));
            RoomDecorator deadRoom = new RoomDecorator(game.room);
        }
        public void SetDecorator(ILink decoLink)
        {
            game.link = decoLink;
        }
        public void RemoveDecorator()
        {
            game.link = this;
        }
        public void Update()
        {
            State.Update();
            Sprite.Update();
            if (!linkDead)
            {
                for (int c = 0; c < Items.Count; c++)
                    Items[c].Update();
            }
        }
        public void Draw(SpriteBatch _spriteBatch, Color color)
        {
            Sprite.Draw(_spriteBatch, position, color);
            foreach (ILinkProjectile item in Items)
            {
                item.Draw(_spriteBatch);
            }
        }
        public Rectangle GetHitBox()
        {
            if(State is not Captured)
                return new Rectangle((int)position.X, (int)position.Y, 15 * 3, 15 * 3);
            else
                return new Rectangle(0, 0, 0, 0);          
        }
        public void FinishCapture()
        {
            position = new Vector2(375, 300);
            State = new DownIdleLinkState(this);
            ((Room12)game.room).firstTime = true;
            game.room.SwitchRoom(5, 11, FadingTransitionHandler.Instance);
        }
    }
}