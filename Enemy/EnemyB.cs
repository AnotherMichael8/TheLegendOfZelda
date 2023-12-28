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
    public abstract class EnemyB : EnemySecondary
    {
        public override void DropItem()
        {
            int choice = new Random().Next(0, 15);
            Vector2 position = new Vector2(this.X, this.Y);
            bool spawned = true;
            if (choice < 3)
            {
                CollisionManager.GameObjectList.Add(new Heart(position, spawned));
            }
            else if (choice < 4)
            {
                CollisionManager.GameObjectList.Add(new Clock(position, spawned));
            }
            else if (choice < 7)
            {
                CollisionManager.GameObjectList.Add(new Bomb(position, spawned));
            }
            else if (choice < 9)
            {
                CollisionManager.GameObjectList.Add(new Rupee(position, spawned));

            }
        }
    }
}
