using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class ToggleItemMenu : ICommand
    {
        public Game1 game1;

        public ToggleItemMenu(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            if (InventoryController.itemMenuState == InventoryController.ItemMenuState.collapsed) {
                InventoryController.itemMenuState = InventoryController.ItemMenuState.movingDown;
            } else if (InventoryController.itemMenuState == InventoryController.ItemMenuState.fullView) {
                InventoryController.itemMenuState = InventoryController.ItemMenuState.movingUp;
            }
            game1.gameState = Game1.GameState.itemMenu;
        }
    }
}
