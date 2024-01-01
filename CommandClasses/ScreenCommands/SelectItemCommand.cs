using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.ScreenCommands
{
    public class SelectItemCommand : ICommand
    {
        private Game1 game1;
        public SelectItemCommand(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            game1.screen.SelectInstance();
        }
    }
}
