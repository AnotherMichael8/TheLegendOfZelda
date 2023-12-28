using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightAttackLinkState : LinkStateAbstract
    {
        private Link link;
        private int count = 0;
        public RightAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightAttackLinkSprite();
            RightSword sword = new RightSword(link);
            link.Items.Add(sword);
            CollisionManager.GameObjectList.Add(sword);
        }
        public void FinishAttack()
        {
            link.State = new RightIdleLinkState(link);
        }
        public override void Update()
        {
            count++;
            if (count > 20)
            {
                FinishAttack();
            }
            else if (count == 10)
            {
                bool noSwordBeam = true;
                //Checks to see if a sword beam currently exist and if so doesn't spawn another one
                foreach (ILinkProjectile obj in link.Items)
                {
                    if (obj is ISwordBeam)
                    {
                        noSwordBeam = false;
                    }
                }
                if (noSwordBeam && InventoryController.hearts == InventoryController.heartContainers)
                {
                    RightSwordBeam swordBeam = new RightSwordBeam(link);
                    link.Items.Add(swordBeam);
                    CollisionManager.GameObjectList.Add(swordBeam);
                }
            }
        }
        public override void Killed()
        {
            link.State = new KilledLinkState(link);
        }
    }
}