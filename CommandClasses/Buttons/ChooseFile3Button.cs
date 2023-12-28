using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses.Buttons
{
    public class ChooseFile3Button : IButton
    {
        private Rectangle position = new Rectangle(542, 303, 227, 383);
        private static Game1 game1;
        public ChooseFile3Button(Game1 game)
        {
            game1 = game;
        }

        public void Invoke()
        {
            SaveFileLoader.Instance.SetFileNum(3);
            InventoryController.LoadFile(3);
            game1.gameState = Game1.GameState.start;
        }

        public bool Pressed(Vector2 mousePosition)
        {
            return (mousePosition.X > position.Left && mousePosition.X < position.Right && mousePosition.Y > position.Top && mousePosition.Y < position.Bottom);
        }
    }
}