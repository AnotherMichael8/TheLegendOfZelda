using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Microsoft.Xna.Framework;
namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownMovingLinkState : LinkStateAbstract
    {
        private Link link;
        public DownMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownMovingLinkSprite();
        }
        public override void BecomeIdle()
        {
            link.State = new DownIdleLinkState(link);
        }
        public override void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public override void MoveLeft()
        {
            link.State = new LeftMovingLinkState(link);
        }
        public override void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public override void CollectBow()
        {
            link.State = new CollectBowState(link);
        }
        public override void CollectTriForce()
        {
            link.State = new CollectTriForceState(link);
        }
        public override void Attack()
        {
            link.State = new DownAttackLinkState(link);
        }
        public override void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y + 4);
        }
        public override void UseBomb()
        {
            link.State = new DownUseItemState(link, new DownBomb(link));
        }
        public override void UseArrow()
        {
            link.State = new DownUseItemState(link, new DownArrow(link));
        }
        public override void UseBoomerang()
        {
            link.State = new DownUseItemState(link, new DownBoomerang(link));
        }
        public override void UseBlueBoomerang()
        {
            link.State = new DownUseItemState(link, new DownBlueBoomerang(link));
        }
        public override void UseBlueArrow()
        {
            link.State = new DownUseItemState(link, new DownBlueArrow(link));
        }
        public override void UseFire()
        {
            link.State = new DownUseItemState(link, new DownFire(link));
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}