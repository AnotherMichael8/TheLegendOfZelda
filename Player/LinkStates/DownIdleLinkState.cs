using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownIdleLinkState : LinkStateAbstract
    {

        private Link link;
        public DownIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownIdleLinkSprite();
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
            link.State = new DownAttackLinkState(link);
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