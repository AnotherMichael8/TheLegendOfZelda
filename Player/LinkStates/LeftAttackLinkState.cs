using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class LeftAttackLinkState : LinkStateAbstract
    {
        private Link link;
        private int count = 0;
        public LeftAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftAttackLinkSprite();
            LeftSword sword = new LeftSword(link);
            link.Items.Add(sword);
            CollisionManager.GameObjectList.Add(sword);
        }
        public void FinishAttack()
        {
            link.State = new LeftIdleLinkState(link);
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
                //if (noSwordBeam && InventoryController.GetCount("Heart") == 5)
                if (noSwordBeam && InventoryController.hearts == InventoryController.heartContainers)
                {
                    LeftSwordBeam swordBeam = new LeftSwordBeam(link);
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