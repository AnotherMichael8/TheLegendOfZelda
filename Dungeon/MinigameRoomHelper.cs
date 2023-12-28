using Sprint2_Attempt3.Enemy.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class MinigameRoomHelper
    {
        private List<IGameObject> gameObjectList;
        private int roomNumber;
        public MinigameRoomHelper(List<IGameObject> gameObjectList) //int roomNumber)
        {
            //this.roomNumber = roomNumber;
            this.gameObjectList = gameObjectList;
        }
        public void startGame() { 
            Target targetTopRight1 = new Target(105, 275, true);
            Target targetTopRight2 = new Target(190, 275, true);
            Target targetTopRight3 = new Target(280, 275, true);
            Target targetTopRight4 = new Target(370, 275, true);
            Target targetTopRight5 = new Target(460, 275, true);
            Target targetTopRight6 = new Target(550, 275, true);
            Target targetMiddleLeft1 = new Target(155, 340, false);
            Target targetMiddleLeft2 = new Target(245, 340, false);
            Target targetMiddleLeft3 = new Target(335, 340, false);
            Target targetMiddleLeft4 = new Target(425, 340, false);
            Target targetMiddleLeft5 = new Target(515, 340, false);
            Target targetMiddleLeft6 = new Target(605, 340, false);
            Target targetLowerRight1 = new Target(105, 405, true);
            Target targetLowerRight2 = new Target(190, 405, true);
            Target targetLowerRight3 = new Target(280, 405, true);
            Target targetLowerRight4 = new Target(370, 405, true);
            Target targetLowerRight5 = new Target(460, 405, true);
            Target targetLowerRight6 = new Target(550, 405, true);

            gameObjectList.Add(targetTopRight1);
            gameObjectList.Add(targetTopRight2);
            gameObjectList.Add(targetTopRight3);
            gameObjectList.Add(targetTopRight4);
            gameObjectList.Add(targetTopRight5);
            gameObjectList.Add(targetTopRight6);
            gameObjectList.Add(targetMiddleLeft1);
            gameObjectList.Add(targetMiddleLeft2);
            gameObjectList.Add(targetMiddleLeft3);
            gameObjectList.Add(targetMiddleLeft4);
            gameObjectList.Add(targetMiddleLeft5);
            gameObjectList.Add(targetMiddleLeft6);
            gameObjectList.Add(targetLowerRight1);
            gameObjectList.Add(targetLowerRight2);
            gameObjectList.Add(targetLowerRight3);
            gameObjectList.Add(targetLowerRight4);
            gameObjectList.Add(targetLowerRight5);
            gameObjectList.Add(targetLowerRight6);
        }
    }

}
