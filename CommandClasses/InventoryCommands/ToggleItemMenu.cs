using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Controllers;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses.InventoryCommands
{
    internal class ToggleItemMenu : ICommand
    {
        public Game1 game1;

        public ToggleItemMenu(Game1 game)
        {
            game1 = game;
        }

        public void Execute()
        {
            if (InventoryController.itemMenuState == InventoryController.ItemMenuState.collapsed)
            {
                InventoryController.itemMenuState = InventoryController.ItemMenuState.movingDown;
                game1.Controller = new InventoryOpenController(game1);
            }
            else if (InventoryController.itemMenuState == InventoryController.ItemMenuState.fullView)
            {
                InventoryController.itemMenuState = InventoryController.ItemMenuState.movingUp;
                game1.Controller = new GameplayController(game1);
            }
            game1.gameState = Game1.GameState.itemMenu;
        }
    }
}
