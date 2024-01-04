using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.CommandClasses.ScreenCommands;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Screens;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Controllers
{
    public class TitleScreenController : KeyboardController
    {
        public TitleScreenController(Game1 game) : base (game) { }
        public override void RegisterCommands()
        {
            commandMapping.Add(Keys.Enter, new SwitchToSaveFilesCommand(game));    
            base.RegisterCommands();
        }
    }
}
