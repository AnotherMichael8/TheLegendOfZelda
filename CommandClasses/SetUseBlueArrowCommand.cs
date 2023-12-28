using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetUseBlueArrowCommand : ICommand
    {
        private Game1 game;
        public SetUseBlueArrowCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            if (InventoryController.HasBow && InventoryController.RupeeCount > 0)
            {
                SoundFactory.PlaySound(SoundFactory.Instance.arrowBoomerang);
                game.link.UseBlueArrow();
                InventoryController.RupeeCount--;
            }
        }
    }
}
