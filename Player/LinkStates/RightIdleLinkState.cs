using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightIdleLinkState : LinkStateAbstract
    {
        private Link link;
        public RightIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightIdleLinkSprite();
        }
        public override void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
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
            link.State = new RightAttackLinkState(link);
        }
        public override void UseBomb()
        {
            link.State = new RightUseItemState(link, new RightBomb(link));
        }
        public override void UseArrow()
        {
            link.State = new RightUseItemState(link, new RightArrow(link));
        }
        public override void UseBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBoomerang(link));
        }
        public override void UseBlueBoomerang()
        {
            link.State = new RightUseItemState(link, new RightBlueBoomerang(link));
        }
        public override void UseBlueArrow()
        {
            link.State = new RightUseItemState(link, new RightBlueArrow(link));
        }
        public override void UseFire()
        {
            link.State = new RightUseItemState(link, new RightFire(link));
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}