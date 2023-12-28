using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public enum ItemNames { BlueBoomerang, Boomerang, BlueArrow, Arrow, Fire, Bomb }
    public interface ICommand
    {
        void Execute();
    }
}
