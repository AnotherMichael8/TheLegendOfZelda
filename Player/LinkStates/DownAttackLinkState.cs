using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownAttackLinkState : LinkStateAbstract
    {
        private Link link;
        private int count = 0;
        public DownAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownAttackLinkSprite();
            DownSword sword = new DownSword(link);
            link.Items.Add(sword);
            CollisionManager.GameObjectList.Add(sword);
        }
        public void FinishAttack()
        {
            link.State = new DownIdleLinkState(link);
        }
        public override void Update()
        {
            count++;
            if (count > 20)
            {
                FinishAttack();
            }
            else if(count == 10)
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
                    DownSwordBeam swordBeam = new DownSwordBeam(link);
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