using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownUseItemState : LinkStateAbstract
    {
        private Link link;
        private int frameCounter;
        public DownUseItemState(Link link, ILinkProjectile item)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownItemLinkSprite();
            link.Items.Add(item);
            CollisionManager.GameObjectList.Add(item);
            frameCounter = 0;
        }
        public void Stop()
        {
            link.State = new DownIdleLinkState(link);
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
