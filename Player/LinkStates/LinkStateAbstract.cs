using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public abstract class LinkStateAbstract : ILinkState
    {
        public LinkStateAbstract() { }
        public virtual void Attack() { }
        public virtual void BecomeIdle() { }
        public virtual void CollectBow() { }
        public virtual void CollectTriForce() { }
        public virtual void GetDamaged() { }
        public virtual void Killed() { }
        public virtual void MoveDown() { }
        public virtual void MoveLeft() { }
        public virtual void MoveRight() { }
        public virtual void MoveUp() { }
        public virtual void Update() { }
        public virtual void UseArrow() { }
        public virtual void UseBlueArrow() { }
        public virtual void UseBlueBoomerang() { }
        public virtual void UseBomb() { }
        public virtual void UseBoomerang() { }
        public virtual void UseFire() { }
      
    }
}
