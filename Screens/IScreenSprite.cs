using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Screens
{
    public interface IScreenSprite
    {
        public void Update();
        public void Draw(SpriteBatch spritebatch, Rectangle selectorDestinationRectangles);
    }
}
