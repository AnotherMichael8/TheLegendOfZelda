using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackRightLinkState : LinkStateAbstract
    {
        int currentframe = 0;
        private Link link;
        public KnockbackRightLinkState(Link link)
        {
            SoundFactory.PlaySound(SoundFactory.Instance.linkHit);
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new LeftIdleLinkState(link);
        }
        public override void Update()
        {
            if (currentframe < 10)
            {
                link.Position = new Vector2(link.Position.X + 10, link.Position.Y);
                //link.Position.X += 10;
            } else
            {
                FinishAnimation();
            }
            currentframe++;
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}