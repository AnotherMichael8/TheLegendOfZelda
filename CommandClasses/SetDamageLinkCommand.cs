using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetDamageLinkCommand : ICommand
    {
        private ILink link;
        public SetDamageLinkCommand(ILink link) 
        {
            this.link = link;
        }

        public void Execute()
        {
            DamageLinkDecorator damagedLink = new DamageLinkDecorator(link);//game);
            damagedLink.GetDamaged(new TopCollision());
        }
        public void Execute(ICollision side)
        {
            DamageLinkDecorator damagedLink = new DamageLinkDecorator(link);
            damagedLink.GetDamaged(side);
        }

    }
}
