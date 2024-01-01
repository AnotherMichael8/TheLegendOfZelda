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
        private Rectangle[][] selectorDestinationRectangles = null;
        private int selectorPositionX = 0;
        private int selectorPositionY = 0;
        protected IScreenSprite screenSprite;
        protected enum SelectorDirection { Horizontal,  Vertical };

        protected int[] GetSelectorsPosition()
        {
            return new int[] { selectorPositionX, selectorPositionY }; 
        }
        protected int GetSelectorsPosition(SelectorDirection direction)
        {
            if (direction == SelectorDirection.Horizontal)
                return selectorPositionX;
            else
                return selectorPositionY;
        }
        protected void Create1DSelector(Rectangle[] selectorPositions, SelectorDirection direction)
        {
            switch (direction)
            {
                case SelectorDirection.Horizontal:
                    selectorDestinationRectangles = new Rectangle[1][];
                    selectorDestinationRectangles[0] = selectorPositions;
                    break;
                case SelectorDirection.Vertical:
                    selectorDestinationRectangles = new Rectangle[selectorPositions.Length][];
                    for (int i = 0; i < selectorPositions.Length; i++)
                        selectorDestinationRectangles[i] = new Rectangle[] { selectorPositions[i] };
                    break;
            }
        }
        protected void Create2DSelector(Rectangle[][] selectorPositions)
        {
            selectorDestinationRectangles = selectorPositions;
        }

        public void MoveSelectorUp() 
        {
            if(selectorDestinationRectangles != null)
            {
                if (selectorPositionY != 0)
                    selectorPositionY--;
                else
                    selectorPositionY = selectorDestinationRectangles.Length - 1;
            }
        }
        public void MoveSelectorDown() 
        {
            if (selectorDestinationRectangles != null)
            {
                if (selectorPositionY != selectorDestinationRectangles.Length - 1)
                    selectorPositionY++;
                else
                    selectorPositionY = 0;
            }
        }
        public void MoveSelectorLeft()
        {
            if (selectorDestinationRectangles != null)
            {
                if (selectorPositionX != 0)
                    selectorPositionX--;
                else
                    selectorPositionX = selectorDestinationRectangles[0].Length - 1;
            }
        }
        public void MoveSelectorRight()
        {
            if (selectorDestinationRectangles != null)
            {
                if (selectorPositionX != selectorDestinationRectangles[0].Length - 1)
                    selectorPositionX++;
                else
                    selectorPositionX = 0;
            }
        }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            if (selectorDestinationRectangles != null)
                screenSprite.Draw(spritebatch, selectorDestinationRectangles[selectorPositionY][selectorPositionX]);
            else
                screenSprite.Draw(spritebatch, Rectangle.Empty);
        }
        public virtual void SelectInstance() { }
        public abstract void Update();
    }
}
