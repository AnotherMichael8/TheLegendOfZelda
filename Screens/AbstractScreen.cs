using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.Screens
{
    public abstract class AbstractScreen : IScreen
    {
        protected Rectangle[] selectorDestinationRectangles1D = null;
        protected Rectangle[][] selectorDestinationRectangles2D = null;
        protected int selectorPositionX;
        protected int selectorPositionY;
        protected IScreenSprite screenSprite;

        public void MoveSelectorUp() 
        {
            if(selectorDestinationRectangles2D != null)
            {
                if (selectorPositionY != 0)
                    selectorPositionY--;
                else
                    selectorPositionY = selectorDestinationRectangles2D.Length - 1;
            }
        }
        public void MoveSelectorDown() 
        {
            if (selectorDestinationRectangles2D != null)
            {
                if (selectorPositionY != selectorDestinationRectangles2D.Length - 1)
                    selectorPositionY++;
                else
                    selectorPositionY = 0;
            }
        }
        public void MoveSelectorLeft()
        {
            if (selectorPositionX != 0)
                selectorPositionX--;
            else
            {
                if (selectorDestinationRectangles1D != null)
                    selectorPositionX = selectorDestinationRectangles1D.Length - 1;
                else
                    selectorPositionX = selectorDestinationRectangles2D.Length - 1;
            }
        }
        public void MoveSelectorRight()
        {
            if (selectorDestinationRectangles1D != null && selectorPositionX != selectorDestinationRectangles1D.Length - 1)
                selectorPositionX++;
            else if (selectorDestinationRectangles2D != null && selectorPositionX != selectorDestinationRectangles2D.Length - 1)
                selectorPositionX++;
            else
                selectorPositionX = 0;
        }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            if (selectorDestinationRectangles2D != null)
                screenSprite.Draw(spritebatch, selectorDestinationRectangles2D[selectorPositionX][selectorPositionY]);
            else
                screenSprite.Draw(spritebatch, selectorDestinationRectangles1D[selectorPositionX]);
        }
        public virtual void SelectInstance() { }
        public abstract void Update();
    }
}
