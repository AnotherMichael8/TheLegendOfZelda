using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy.Target
{
    public interface ITargetState
    {
        public void MoveRight();
        public void MoveLeft();
        public void MoveUp();
        public void MoveDown();
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
