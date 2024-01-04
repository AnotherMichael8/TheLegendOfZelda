using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.CommandClasses.InventoryCommands;

namespace Sprint2_Attempt3.Controllers
{
    internal class InventoryOpenController : KeyboardController
    {
        public InventoryOpenController(Game1 game) : base(game) { }
        public override void RegisterCommands()
        {
            commandMapping.Add(Keys.W, new ShiftItemSelectorUp());
            commandMapping.Add(Keys.A, new ShiftItemSelectorLeft());
            commandMapping.Add(Keys.S, new ShiftItemSelectorDown());
            commandMapping.Add(Keys.D, new ShiftItemSelectorRight());
            commandMapping.Add(Keys.Up, new ShiftItemSelectorUp());
            commandMapping.Add(Keys.Left, new ShiftItemSelectorLeft());
            commandMapping.Add(Keys.Down, new ShiftItemSelectorDown());
            commandMapping.Add(Keys.Right, new ShiftItemSelectorRight());
            commandMapping.Add(Keys.P, new SetAItem());
            commandMapping.Add(Keys.O, new SetBItem());
            commandMapping.Add(Keys.Space, new ToggleItemMenu(game));
            base.RegisterCommands();
        }
    }
}
