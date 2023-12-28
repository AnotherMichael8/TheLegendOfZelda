using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetUseFireCommand : ICommand
    {
        private Game1 game;
        public SetUseFireCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            SoundFactory.PlaySound(SoundFactory.Instance.arrowBoomerang);
            game.link.UseFire();
        }
    }
}
