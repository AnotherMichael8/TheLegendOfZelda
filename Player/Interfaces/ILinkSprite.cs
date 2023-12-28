using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Interfaces
{
    public interface ILinkSprite
    {
        //will not deal with position that will be handled in respective state class
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color);
    }
}
