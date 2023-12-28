using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sprint2_Attempt3.CommandClasses.LinkCommands
{
    public class MoveLinkDown : ICommand
    {
        private Game1 game;
        public MoveLinkDown(Game1 game)
        {
            this.game = game;
        }


        public void Execute()
        {
            game.link.MoveDown();
        }

    }
}