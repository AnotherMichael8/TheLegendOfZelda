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
    public class TitleScreenController : IController
    {
        private Game1 game1;
        private float timeSinceLastUpdate;
        private Dictionary<Keys, ICommand> commandMapping = new Dictionary<Keys, ICommand>();
        public TitleScreenController(Game1 game)
        {
            game1 = game;
            commandMapping = new Dictionary<Keys, ICommand>();
            RegisterCommands();
            timeSinceLastUpdate = 0;
        }
        public void RegisterCommands()
        {
            commandMapping.Add(Keys.Enter, new SwitchToSaveFilesCommand(game1));    
        }
        public void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (pressedKeys.Length > 0 && timeSinceLastUpdate > 0.1f)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandMapping.ContainsKey(key))
                    {
                        commandMapping[key].Execute();
                    }
                }
                timeSinceLastUpdate = 0;
            }
        }
    }
}
