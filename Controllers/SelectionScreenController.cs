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
    internal class SelectionScreenController : IController
    {
        private Game1 game1;
        private float timeSinceLastUpdate;
        private Dictionary<Keys, ICommand> commandMapping;
        private List<Keys> heldKeys;
        public SelectionScreenController(Game1 game)
        {
            game1 = game;
            commandMapping = new Dictionary<Keys, ICommand>();
            heldKeys = new List<Keys>();
            RegisterCommands();
            timeSinceLastUpdate = 0;
        }
        public void RegisterCommands()
        {
            commandMapping.Add(Keys.W, new MoveSelectorUpCommand(game1));
            commandMapping.Add(Keys.A, new MoveSelectorLeftCommand(game1));
            commandMapping.Add(Keys.S, new MoveSelectorDownCommand(game1));
            commandMapping.Add(Keys.D, new MoveSelectorRightCommand(game1));
            commandMapping.Add(Keys.Up, new MoveSelectorUpCommand(game1));
            commandMapping.Add(Keys.Left, new MoveSelectorLeftCommand(game1));
            commandMapping.Add(Keys.Down, new MoveSelectorDownCommand(game1));
            commandMapping.Add(Keys.Right, new MoveSelectorRightCommand(game1));
        }
        public void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            for (int c = 0; c < heldKeys.Count; c++)
            {
                if (!pressedKeys.Contains(heldKeys[c]))
                {
                    heldKeys.Remove(heldKeys[c]);
                    c--;
                }
            }

            timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (pressedKeys.Length > 0 && timeSinceLastUpdate > 0.1f)
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandMapping.ContainsKey(key) && !heldKeys.Contains(key))
                    {
                        commandMapping[key].Execute();
                        heldKeys.Add(key);
                    }
                }
                timeSinceLastUpdate = 0;
            }
        }
    }
}
