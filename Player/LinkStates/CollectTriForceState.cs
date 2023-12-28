using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class CollectTriForceState : LinkStateAbstract
    {

        private Link link;
        private int timer = 440;
        public CollectTriForceState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateTriForceLink();
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