﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.LinkCommands
{
    public class MoveLinkRight : ICommand
    {
        private Game1 game;
        public MoveLinkRight(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.MoveRight();
        }
    }
}