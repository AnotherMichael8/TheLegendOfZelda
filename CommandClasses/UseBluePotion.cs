using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class UseBluePotion : ICommand
    {
        public UseBluePotion()
        {
        }

        public void Execute()
        {
            float difference = InventoryController.heartContainers - InventoryController.hearts;
            InventoryController.DecrementCount("BluePotion");
            InventoryController.hearts += difference;
        }
    }
}
