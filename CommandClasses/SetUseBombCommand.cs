using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetUseBombCommand : ICommand
    {
        private Game1 game;
        public SetUseBombCommand(Game1 game) 
        { 
            this.game = game;
        }

        public void Execute() {
            if (InventoryController.GetCount("Bomb") > 0)
            {
                game.link.UseBomb();
                InventoryController.DecrementCount("Bomb");
                SoundFactory.PlaySound(SoundFactory.Instance.bombDrop);
            }
        }
    }
}
