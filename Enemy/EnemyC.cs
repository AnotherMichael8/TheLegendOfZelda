using Sprint2_Attempt3.Collision;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Items.ItemClasses;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemyC : EnemySecondary
    {
        public override void DropItem()
        {
            int choice = new Random().Next(0, 15);
            Vector2 position = new Vector2(this.X, this.Y);
            bool spawned = true;
            if (choice < 2)
            {
                CollisionManager.GameObjectList.Add(new Heart(position, spawned));
            }
            else if(choice < 3)
            {
                CollisionManager.GameObjectList.Add(new Clock(position, spawned));
            }
            else if(choice < 9)
            {
                CollisionManager.GameObjectList.Add(new Rupee(position, spawned));
            }
        }
    }
}
