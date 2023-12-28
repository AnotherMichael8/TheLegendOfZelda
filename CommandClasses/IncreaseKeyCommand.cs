using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class IncreaseKeyCommand : ICommand
    {
        private Game1 game;
        public IncreaseKeyCommand(Game1 game) 
        { 
            this.game = game;
        }

        public void Execute() {
            InventoryController.KeyCount++;
        }
    }
}
