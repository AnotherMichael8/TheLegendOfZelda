using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.CommandClasses.Buttons;
using Sprint2_Attempt3.Items.ItemClasses;

namespace Sprint2_Attempt3
{
    public class MouseController : IController
    {
        private Game1 game1;
        private float timeSinceLastUpdate;
        List<IButton> commands;
        public MouseController(Game1 game)
        {
            this.game1 = game;
            timeSinceLastUpdate = 0;
            commands = new List<IButton>();
            RegisterCommands();

        }
        public void RegisterCommands()
        {
            commands.Add(new ChooseFile1Button(game1));
            commands.Add(new ChooseFile2Button(game1));
            commands.Add(new ChooseFile3Button(game1));
        }

        public void Update(GameTime gameTime)
        {
            MouseState mstate = Mouse.GetState();
            if (mstate.LeftButton.Equals(ButtonState.Pressed))
            {
                Vector2 mposition = new Vector2(mstate.X, mstate.Y);

                timeSinceLastUpdate += (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (timeSinceLastUpdate > 0.1f)
                {
                    foreach (IButton button in commands) {
                        if (button.Pressed(mposition)) { 
                            button.Invoke();
                            break;
                        }
                    }
                    timeSinceLastUpdate = 0;
                }
            }
        }
    }
}
