using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using System.Threading;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class CollectBowState : LinkStateAbstract
    {

        private Link link;
        private int timer = 60;
        public CollectBowState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateBowLink();
        }
        public void FinishAnimation()
        {
            link.State = new DownIdleLinkState(link);
        }
        public override void Update()
        {
            if(timer > 0)
            {
                timer--;
            } else
            {
                FinishAnimation();
            }
        }
    }
}