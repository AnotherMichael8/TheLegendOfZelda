using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision.SideCollisionHandlers
{
    internal class PlayerItemCollisionHandler
    {
        public PlayerItemCollisionHandler() { }

        public static void HandlePlayerItemCollision(IItem item, ILink link)
        {
            if(item is Bow)
            {
                link.CollectBow();
            } 
            else if(item is TriforcePiece)
            {
                link.CollectTriForce();
                InventoryController.hearts = InventoryController.heartContainers;
            }
         item.Collect();
        }
    }
}
