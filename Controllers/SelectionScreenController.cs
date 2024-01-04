using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.CommandClasses.ScreenCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Controllers
{
    public class SelectionScreenController : KeyboardController
    {
        public SelectionScreenController(Game1 game) : base(game) { }
        public override void RegisterCommands()
        {
            commandMapping.Add(Keys.W, new MoveSelectorUpCommand(game));
            commandMapping.Add(Keys.A, new MoveSelectorLeftCommand(game));
            commandMapping.Add(Keys.S, new MoveSelectorDownCommand(game));
            commandMapping.Add(Keys.D, new MoveSelectorRightCommand(game));
            commandMapping.Add(Keys.Up, new MoveSelectorUpCommand(game));
            commandMapping.Add(Keys.Left, new MoveSelectorLeftCommand(game));
            commandMapping.Add(Keys.Down, new MoveSelectorDownCommand(game));
            commandMapping.Add(Keys.Right, new MoveSelectorRightCommand(game));
            commandMapping.Add(Keys.Enter, new SelectItemCommand(game));
            base.RegisterCommands();
        }
    }
}
