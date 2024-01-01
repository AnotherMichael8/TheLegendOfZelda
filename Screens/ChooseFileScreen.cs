using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.Screens
{
    public class ChooseFileScreen : AbstractScreen
    {
        private Game1 game;
        public ChooseFileScreen(Game1 game)
        {
            this.game = game;
            Create1DSelector(new Rectangle[] { new Rectangle(135, 600, 24, 24), new Rectangle(395, 600, 24, 24), new Rectangle(655, 600, 24, 24) }, SelectorDirection.Horizontal);
            screenSprite = ScreenSpriteFactory.Instance.CreateChooseFileScreen();
        }     
        public override void Update() { }
        public override void SelectInstance()
        {
            LoadSaveFileCommand loadSave = new LoadSaveFileCommand(game);
            loadSave.Execute(GetSelectorsPosition(SelectorDirection.Horizontal));
        }
    }
}
