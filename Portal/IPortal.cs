using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Portal
{
    internal interface IPortal : IGameObject
    {
        public void Draw(SpriteBatch spriteBatch, Vector2 change);
        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos);
        public void Draw(SpriteBatch spriteBatch, Color color);
    }
}
