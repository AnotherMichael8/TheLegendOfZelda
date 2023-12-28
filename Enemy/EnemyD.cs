using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    public abstract class EnemyD : EnemySecondary
    {
        public override void DropItem()
        {
            int choice = new Random().Next(0, 15);
            Vector2 position = new Vector2(this.X, this.Y);
            bool spawned = true;
            if (choice < 6 && choice >= 0)
            {
                CollisionManager.GameObjectList.Add(new Heart(position, spawned));
            }
            else if (choice < 8)
            {
                CollisionManager.GameObjectList.Add(new Fairy(position, spawned));
            }
            else if(choice < 9)
            {
                CollisionManager.GameObjectList.Add(new Rupee(position, spawned));
            }
        }
    }
}
