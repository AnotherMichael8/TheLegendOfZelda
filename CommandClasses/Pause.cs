using Sprint2_Attempt3.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class Pause : ICommand
    {
        private Game1 game1;
        public Pause(Game1 game)
        {
            this.game1 = game;

        }

        public void Execute()
        {
            game1.gameState = Game1.GameState.pause;
            game1.screenSprite = ScreenSpriteFactory.Instance.CreatePauseScreen();
        }
    }
}
