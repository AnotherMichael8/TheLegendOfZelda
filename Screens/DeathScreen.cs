using Sprint2_Attempt3.CommandClasses;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    public class DeathScreen : AbstractScreen
    {
        private Game1 game;
        private ICommand[] commandArray;
        public DeathScreen(Game1 game)
        {
            this.game = game;
            Create1DSelector(new Rectangle[] { new Rectangle(324, 368, 24, 24), new Rectangle(324, 448, 24, 24)}, SelectorDirection.Vertical);
            commandArray = new ICommand[] { new Reset(game), new Quit(game) };
            screenSprite = ScreenSpriteFactory.Instance.CreateDeathScreen();

        }
        public override void Update() { }
        public override void SelectInstance()
        {
            commandArray[GetSelectorsPosition(SelectorDirection.Vertical)].Execute();
        }
    }
}
