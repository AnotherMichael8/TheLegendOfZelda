﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses.InventoryCommands
{
    internal class UseBItem : ICommand
    {
        public UseBItem() { }

        public void Execute()
        {
            Menu.UseBItem();
        }
    }
}
