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
    internal class SwitchToSaveFilesCommand : ICommand
    {
        private Game1 game1;
        private IController selectorController;
        public SwitchToSaveFilesCommand(Game1 game)
        {
            game1 = game;
            selectorController = new SelectionScreenController(game1);
        }

        public void Execute()
        {
            game1.Controller = selectorController;
            SoundFactory.PauseMusic();
            SoundFactory.Instance.backgroundMusic.Resume();
            game1.gameState = Game1.GameState.chooseFile;
            game1.screen = new ChooseFileScreen(game1);
        }
    }
}
