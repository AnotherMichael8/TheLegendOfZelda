using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Blocks.Block
{
    public class MovingBlock : BlockSecondary, IMovingBlock
    {
        public bool Moved { get; private set; }
        private ICollision pushedSide;
        private int timer;
        private bool movementComplete;
        public MovingBlock(Rectangle position)
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
                if(pushedSide is LeftCollision)
                {
                    position = new Rectangle(position.X + 3, position.Y, position.Width, position.Height);
                }
                else if (pushedSide is RightCollision)
                {
                    position = new Rectangle(position.X - 3, position.Y, position.Width, position.Height);
                }
                else if (pushedSide is TopCollision)
                {
                    position = new Rectangle(position.X, position.Y + 3, position.Width, position.Height);
                }
                else if (pushedSide is BottomCollision)
                {
                    position = new Rectangle(position.X, position.Y - 3, position.Width, position.Height);
                }
                if(timer == 1)
                {
                    movementComplete = true;
                }
                timer--;
            }
        }
        public void MoveBlock(ICollision side)
        {
            if (!Moved)
            {
                if (timer <= 0)
                {
                    timer += 17;
                }
                else
                {
                    SoundFactory.PlaySound(SoundFactory.Instance.doorUnlock);
                    Moved = true;
                    pushedSide = side;
                }
            }
        }
    }
}
