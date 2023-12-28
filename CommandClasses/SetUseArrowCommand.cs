using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SetUseArrowCommand : ICommand
    {
        private Game1 game;
        public SetUseArrowCommand(Game1 game) 
        {
            this.game = game;
        }

        public void Execute()
        {
            if (InventoryController.HasBow && InventoryController.RupeeCount > 0)
            {
                SoundFactory.PlaySound(SoundFactory.Instance.arrowBoomerang);
                game.link.UseArrow();
                InventoryController.RupeeCount--;
            }
        }
    }
}
