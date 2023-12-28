using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class LeftIdleLinkState : LinkStateAbstract
    {
        private Link link;
        public LeftIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftIdleLinkSprite();
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
            link.State = new LeftAttackLinkState(link);
        }
        public override void UseBomb()
        {
            link.State = new LeftUseItemState(link, new LeftBomb(link));
        }
        public override void UseArrow()
        {
            link.State = new LeftUseItemState(link, new LeftArrow(link));
        }
        public override void UseBoomerang()
        {
            link.State = new LeftUseItemState(link, new LeftBoomerang(link));
        }
        public override void UseBlueBoomerang()
        {
            link.State = new LeftUseItemState(link, new LeftBlueBoomerang(link));
        }
        public override void UseBlueArrow()
        {
            link.State = new LeftUseItemState(link, new LeftBlueArrow(link));
        }
        public override void UseFire()
        {
            link.State = new LeftUseItemState(link, new LeftFire(link));
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}