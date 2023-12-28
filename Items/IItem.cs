using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public interface IItem : IGameObject
    {
        public bool spawned { get; set; }
        public bool exists { get; set; }
        public void Spawn();
        public void Collect();
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
