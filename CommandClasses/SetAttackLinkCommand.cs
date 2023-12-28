using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetAttackLinkCommand : ICommand
    {
        private Game1 game;
        public SetAttackLinkCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.link.Attack();
        }
    }
}
