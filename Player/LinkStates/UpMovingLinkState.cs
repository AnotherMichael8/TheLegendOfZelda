using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Microsoft.Xna.Framework;
namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpMovingLinkState : LinkStateAbstract
    {
        private Link link;

        public UpMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpMovingLinkSprite();
        }
        public override void BecomeIdle()
        {
            link.State = new UpIdleLinkState(link);
        }
        public override void MoveDown()
        {
            link.State = new DownMovingLinkState(link);
        }
        public override void MoveLeft()
        {
            link.State = new LeftMovingLinkState(link);
        }
        public override void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public override void Attack()
        {
            link.State = new UpAttackLinkState(link);
        }
        public override void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - 4);
        }
        public override void UseBomb()
        {
            link.State = new UpUseItemState(link, new UpBomb(link));
        }
        public override void UseArrow()
        {
            link.State = new UpUseItemState(link, new UpArrow(link));
        }
        public override void UseBoomerang()
        {
            link.State = new UpUseItemState(link, new UpBoomerang(link));
        }
        public override void UseBlueBoomerang()
        {
            link.State = new UpUseItemState(link, new UpBlueBoomerang(link));
        }
        public override void UseBlueArrow()
        {
            link.State = new UpUseItemState(link, new UpBlueArrow(link));
        }
        public override void UseFire()
        {
            link.State = new UpUseItemState(link, new UpFire(link));
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
        public override void CollectBow()
        {
            link.State = new CollectBowState(link);
        }
        public override void CollectTriForce()
        {
            link.State = new CollectTriForceState(link);
        }
    }
}
