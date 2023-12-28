using Sprint2_Attempt3.Collision;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks
{
    public interface IMovingBlock
    {
        public bool Moved { get; }
        public void MoveBlock(ICollision side);

    }
}
