using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    public interface ITransitionHandler
    {
        public List<IGameObject> TransitionGameObjectList { get; set; }
        public bool Start { get; set; }
        public void Transition(IRoom room1, IRoom room2);
    }
}
