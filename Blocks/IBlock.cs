using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Blocks
{
    public interface IBlock : IGameObject
    {
        public bool isWalkable { get; set; }
        //public void Draw(SpriteBatch spriteBatch);
        public void Draw(SpriteBatch spriteBatch, Vector2 change);
        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos);
        public void Draw(SpriteBatch spriteBatch, Color color);

    }
}




