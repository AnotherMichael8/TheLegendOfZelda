using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    public interface IDoor : IGameObject
    {
        public bool IsWalkable { get { return IsWalkable; } private set { IsWalkable = value; } }
        public bool IsLocked { get { return IsLocked; } private set { IsLocked = value; } }
        public bool IsDiamondLocked { get { return IsDiamondLocked; } private set { IsDiamondLocked = value; } }
        public bool IsBombWall { get; }
        public bool DoorExists { get; }
        public void Open();
        public void Close();
        public void DiamondLock();
        public void Damage();
        public void NoDoor();
        public void Draw(SpriteBatch spriteBatch, Vector2 change);
        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos);
        public void Draw(SpriteBatch spriteBatch,  Color color);
    }
}
