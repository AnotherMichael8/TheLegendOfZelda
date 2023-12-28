using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Interfaces
{
    public interface ILinkProjectile : IGameObject, IProjectile
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
