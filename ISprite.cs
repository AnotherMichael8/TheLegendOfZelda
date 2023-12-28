using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3
{
    public interface ISprite
    {
        public void Update();
        public void Draw(SpriteBatch spritebatch);
    }
}
