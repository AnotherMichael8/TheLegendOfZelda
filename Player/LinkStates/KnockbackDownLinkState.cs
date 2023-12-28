using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackDownLinkState : LinkStateAbstract
    {
        int currentframe = 0;
        private Link link;
        public KnockbackDownLinkState(Link link)
        {
            SoundFactory.PlaySound(SoundFactory.Instance.linkHit);
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new DownIdleLinkState(link);
        }
        public override void Update()
        {
            if (currentframe < 10)
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y + 10);
                //link.Position.Y += 10;
            } 
            else
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