using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.Interfaces
{
    public interface ILinkState
    {
        public void MoveUp();
        public void MoveDown();
        public void MoveLeft();
        public void MoveRight();
        public void GetDamaged();
        public void BecomeIdle();
        public void Attack();
        public void UseBomb();
        public void UseArrow();
        public void UseBoomerang();
        public void UseBlueBoomerang();
        public void UseBlueArrow();
        public void UseFire();
        public void Killed();
        public void CollectBow();
        public void CollectTriForce();
        
        //public void UseItem(ILinkProjectile item);
        public void Update();

    }
}