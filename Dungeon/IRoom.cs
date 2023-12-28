using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Dungeon.Rooms;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public interface IRoom
    {
        public int RoomNumber { get; }
        public IDungeonRoom room { get;}
        public List<IGameObject> gameObjectList { get;}
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Color color);
        public void SwitchToNorthRoom();
        public void SwitchToSouthRoom();
        public void SwitchToEastRoom();
        public void SwitchToWestRoom();
        public void SetDecorator(IRoom room);
        public void SwitchToLowerRoom();
        public void SwitchToUpperRoom();
        public void ResetRooms();
        public void SwitchRoom(int x, int y, ITransitionHandler transition);
    }
}
