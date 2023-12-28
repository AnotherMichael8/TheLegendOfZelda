using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetIdleLinkCommand : ICommand
    {
        private Game1 game;
        public SetIdleLinkCommand(Game1 game) 
        { 
            this.game = game;
        }
        public void Execute()
        {
            game.link.BecomeIdle();
        }

    }
}
