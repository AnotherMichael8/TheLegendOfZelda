﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Controllers;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Sounds;
using System.Collections.Generic;
using System.Net.Mime;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class Reset : ICommand
    {
        private Game1 game1;

        public Reset(Game1 game) { 
            this.game1= game;
        }

        public void Execute()
        {
            PanningTransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            InventoryController.Reset();
            game1.Reset();
            game1.room.ResetRooms();
            SoundFactory.ResetSounds();
            PanningTransitionHandler.Instance.Start = false;
            FadingTransitionHandler.Instance.Start = false;
        }
    }
}
