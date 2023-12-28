using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Collision;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks.Block
{
    public class Room9MovingBlock : BlockSecondary, IMovingBlock
    {
        public bool Moved { get; private set; }
        private ICollision pushedSide;
        private int timer;
        private bool movementComplete;
        public Room9MovingBlock(Rectangle position)
        {
            this.position = position;
            sourceRectangle = new Rectangle(17, 0, 16, 16);
            isWalkable = false;
            Moved = false;
            movementComplete = false;
            //Amount of buffer time for the block to actually move
            timer = -663;
        }
        public override void Update()
        {
            if (!movementComplete && timer > 0)
            {
                position = new Rectangle(position.X + 3, position.Y, position.Width, position.Height);

                if (timer == 1)
                {
                    movementComplete = true;
                }
                timer--;
            }
        }
        public void MoveBlock(ICollision side)
        {
            if (!Moved && side is LeftCollision)
            {
                if (timer <= 0)
                {
                    timer += 17;
                }
                else
                {
                    Moved = true;
                }
            }
        }
    }
}