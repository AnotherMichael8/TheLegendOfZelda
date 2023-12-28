using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public interface IWall : IGameObject
    {
        public bool EnemyWalkable { get; }
        public bool projectilesThrowable { get; }

        public static List<IWall> WallBlocks = new List<IWall>
        {
            new NorthEastCollisionBlock(), new NorthWestCollisionBlock(), new SouthEastCollisionBlock(),
            new SouthWestCollisionBlock(), new EastNorthCollisionBlock(), new EastSouthCollisionBlock(),
            new NorthDoorCollisionBlock(), new SouthDoorCollisionBlock(), new EastDoorCollisionBlock(),
            new WestDoorCollisionBlock(), new WestSouthCollisionBlock(), new WestNorthCollisionBlock()
        };

        public static List<IWall> Room16WallBlocks = new List<IWall> {
            new Room16Wall1(),
            new Room16Wall2(),
            new Room16Wall3(),
            new Room16Wall4(),
            new Room16Wall5(),
            new Room16Wall6(),
            new Room16Wall7(),
            new Room16Wall8(),
            new ScreenBottom(),
            new ScreenTop(),
            new ScreenLeft(),
            new ScreenRight()
        };
    }
}
