using Sprint2_Attempt3.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.ScreenCommands
{
    public class MoveSelectorLeftCommand : ICommand
    {
        private Game1 game;
        public MoveSelectorLeftCommand(Game1 game) 
        {
            this.game = game;
        }
        public void Execute()
        {
            game.screenSprite.MoveSelectorLeft();
        }
    }
}
