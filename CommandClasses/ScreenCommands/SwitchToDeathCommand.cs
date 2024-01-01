using Sprint2_Attempt3.Controllers;
using Sprint2_Attempt3.Screens;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.ScreenCommands
{
    internal class SwitchToDeathCommand : ICommand
    {
        private Game1 game1;
        private IController gameplayController;
        public SwitchToDeathCommand(Game1 game)
        {
            game1 = game;
            gameplayController = new SelectionScreenController(game1);
        }

        public void Execute()
        {
            game1.Controller = gameplayController;
            game1.gameState = Game1.GameState.linkDead;
            game1.screen = new DeathScreen(game1);
        }
    }
}
