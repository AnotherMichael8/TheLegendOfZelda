using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class TriggerSquareSprite
    {
        protected Texture2D texture;
        protected Rectangle destinationRectangle;
        public TriggerSquareSprite(Texture2D texture) 
        { 
            this.texture = texture;
        }
        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle)
        {
            destinationRectangle = new Rectangle(x, y, 45, 45);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.Yellow);
        }
    }
}
