using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using System.Threading;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon
{
    public class RoomDecorator : IRoom
    {
        private IRoom decoratedRoom;
        public List<IGameObject> gameObjectList { get; set; }
        private int timer;
        public int RoomNumber { get; }
        public IDungeonRoom room { get; protected set; }

        public RoomDecorator(IRoom decoratedRoom)
        {
            this.decoratedRoom = decoratedRoom;
            timer = 0;
            SetDecorator(this);
        }

        public void SwitchToEastRoom()
        {
        }

        public void SwitchToNextRoom()
        {
        }

        public void SwitchToNorthRoom()
        {
        }

        public void SwitchToPrevRoom()
        {
        }

        public void SwitchToSouthRoom()
        {
        }

        public void SwitchToWestRoom()
        {
        }
        public void SwitchToLowerRoom()
        {
        }
        public void SwitchToUpperRoom()
        {
        }
        public void SetDecorator(IRoom room)
        {
            decoratedRoom.SetDecorator(room);
        }
        public void ResetRooms()
        {
        }
        public void SwitchRoom(int x, int y, ITransitionHandler transition) { }
        public void Update()
        {
            decoratedRoom.Update();
            timer++;
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            if (timer <= 80)
                decoratedRoom.Draw(spriteBatch, new Color(255, 50, 25));
            else if (timer <= 90)
                decoratedRoom.Draw(spriteBatch, new Color(200, 30, 20));
            else if (timer <= 100)
                decoratedRoom.Draw(spriteBatch, new Color(150, 10, 5));
            else if (timer <= 110)
                decoratedRoom.Draw(spriteBatch, new Color(50, 0, 0));
            else
                decoratedRoom.Draw(spriteBatch, Color.Black);
        }
    }
}
