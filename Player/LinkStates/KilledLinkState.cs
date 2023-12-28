using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KilledLinkState : LinkStateAbstract
    {
        private Link link;
        public KilledLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDeadLink();
        }
    }
}
