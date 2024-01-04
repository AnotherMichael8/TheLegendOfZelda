using Sprint2_Attempt3.Controllers;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.ScreenCommands
{
    public class SwitchToGameCommand : ICommand
    {
        private Game1 game1;
        private IController gameplayController;
        public SwitchToGameCommand(Game1 game)
        {
            game1 = game;
            gameplayController = new GameplayController(game1);
        }

        public void Execute()
        {
            game1.Controller = gameplayController;
            SoundFactory.PauseMusic();
            SoundFactory.Instance.backgroundMusic.Resume();
            game1.gameState = Game1.GameState.start;
        }
    }
}
