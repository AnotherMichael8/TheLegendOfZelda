using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    public interface IScreen
    {
        public void Update();
        public void Draw(SpriteBatch spritebatch);
        public void MoveSelectorUp();
        public void MoveSelectorDown();
        public void MoveSelectorLeft();
        public void MoveSelectorRight();
        public void SelectInstance();
    }
}
