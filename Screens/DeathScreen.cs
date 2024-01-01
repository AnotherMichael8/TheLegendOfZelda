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
        public DeathScreen(Game1 game)
        {
            this.game = game;
            selectorDestinationRectangles1D = new Rectangle[] { new Rectangle(280, 370, 24, 24), new Rectangle(280, 450, 24, 24)};
            selectorPositionX = 0;
            screenSprite = ScreenSpriteFactory.Instance.CreateDeathScreen();
        }
        public override void Update() { }
        public override void SelectInstance()
        {
            if(sele)
        }
    }
}
