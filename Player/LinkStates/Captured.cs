using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;
using System.Threading;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class Captured : LinkStateAbstract
    {
        private Link link;
        private int count = 60;

        public Captured(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateCapturedLinkSprite(); 
        }
        public override void Update()
        {
            link.Position = new Vector2(link.Position.X, link.Position.Y - 1);
            count--;
            if(count < 0)
            {
                this.link.FinishCapture();
            }
            //link.Position -= 1;
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}
