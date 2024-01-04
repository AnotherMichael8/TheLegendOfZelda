using Sprint2_Attempt3.Controllers;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class LoadSaveFileCommand : ICommand
    {
        private Game1 game1;
        private IController controller;
        public LoadSaveFileCommand(Game1 game)
        {
            this.game1 = game;
            controller = new GameplayController(game1);
        }

        public void Execute()
        {
            SaveFileLoader.Instance.SetFileNum(1);
            InventoryController.LoadFile(1);
            game1.gameState = Game1.GameState.start;
        }
        public void Execute(int saveFileNum)
        {
            SaveFileLoader.Instance.SetFileNum(saveFileNum);
            InventoryController.LoadFile(saveFileNum);
            game1.gameState = Game1.GameState.start;
            game1.Controller = controller;
        }
    }
}
