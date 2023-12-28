using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Hand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class HandCreator : IGameObject
    {
        List<Hand> createdHands = new List<Hand>();
        private int upCounter;
        private int downCounter;
        private int leftCounter;
        private int rightCounter;
        private int waitTime;
        public HandCreator() 
        {
            waitTime = 120;
            upCounter= 0;
            downCounter= 0;
            leftCounter= 0;
            rightCounter= 0;
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }
        public void CreateHandLeft(Vector2 linkPosition)
        {
            if (leftCounter <= 0)
            {
                Hand newHand = new Hand((int)linkPosition.X - 60, (int)linkPosition.Y + 120);
                newHand.CaptureLeft();
                leftCounter = waitTime;
                createdHands.Add(newHand);
            }
        }
        public void CreateHandRight(Vector2 linkPosition)
        {
            if (rightCounter <= 0)
            {
                Hand newHand = new Hand((int)linkPosition.X + 60, (int)linkPosition.Y + 120);
                newHand.CaptureRight();
                rightCounter = waitTime;
                createdHands.Add(newHand);
            }
        }
        public void CreateHandUp(Vector2 linkPosition)
        {
            if (upCounter <= 0)
            {
                Hand newHand = new Hand((int)linkPosition.X + 120, (int)linkPosition.Y - 60);
                newHand.CaptureUp();
                upCounter = waitTime;
                createdHands.Add(newHand);
            }
        }
        public void Clear()
        {
            createdHands.Clear();
        }
        public void CreateHandDown(Vector2 linkPosition)
        {
            if (downCounter <= 0)
            {
                Hand newHand = new Hand((int)linkPosition.X - 120, (int)linkPosition.Y + 60);
                newHand.CaptureDown();
                downCounter = waitTime;
                createdHands.Add(newHand);
            }
        }
        public List<Hand> AddHands()
        {
            List<Hand> tempList = new List<Hand>();
            for (int i = 0; i < createdHands.Count; i++)
            {
                tempList.Add(createdHands[i]);
            }
            createdHands.Clear();
            return tempList;
        }
        public void Update()
        {
            if(upCounter > 0) upCounter--;
            if(downCounter > 0) downCounter--;
            if(leftCounter > 0) leftCounter--;
            if(rightCounter > 0) rightCounter--;
        }
    }
}
