using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpUseItemState : LinkStateAbstract
    {
        private Link link;
        private int frameCounter;
        public UpUseItemState(Link link, ILinkProjectile item)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpItemLinkSprite();
            link.Items.Add(item);
            CollisionManager.GameObjectList.Add(item);
            frameCounter = 0;
        }
        public void Stop()
        {
            link.State = new UpIdleLinkState(link);
        }
        public override void Update()
        {
            frameCounter++;
            if (frameCounter >= 10)
            {
                Stop();
            }
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}
