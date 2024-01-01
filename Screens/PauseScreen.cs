using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.CommandClasses.ScreenCommands;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.Screens
{
    public class PauseScreen : AbstractScreen
    {
        private Game1 game;
        private ICommand[] commandArray;
        public PauseScreen(Game1 game)
        {
            this.game = game;
            Create1DSelector(new Rectangle[] { new Rectangle(268, 260, 24, 24), new Rectangle(268, 340, 24, 24), new Rectangle(268, 424, 24, 24), new Rectangle(268, 524, 24, 24) }, SelectorDirection.Vertical);
            screenSprite = ScreenSpriteFactory.Instance.CreatePauseScreen();
            commandArray = new ICommand[] { new SwitchToGameCommand(game), new SaveFileCommand(), new Reset(game), new Quit(game) };
        }
        public override void Update() { }
        public override void SelectInstance()
        {
            commandArray[GetSelectorsPosition(SelectorDirection.Vertical)].Execute();
        }
    }
}
