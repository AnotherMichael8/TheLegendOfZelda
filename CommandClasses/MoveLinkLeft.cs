using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class MoveLinkLeft : ICommand
    {
        private Game1 game;
        public MoveLinkLeft(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveLeft();
        }
    }
}
