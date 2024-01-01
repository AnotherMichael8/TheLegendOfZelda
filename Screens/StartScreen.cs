using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using System;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    internal class StartScreen : AbstractScreen
    {
        private Game1 game;
        public StartScreen(Game1 game)
        {
            this.game = game;
            screenSprite = ScreenSpriteFactory.Instance.CreateStartScreen();
        }
        public override void Update() { }
        public override void Draw(SpriteBatch spritebatch)
        {
            screenSprite.Draw(spritebatch, Rectangle.Empty);
        }
    }
}
