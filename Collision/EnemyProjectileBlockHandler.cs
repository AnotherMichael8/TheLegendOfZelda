using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyProjectileBlockHandler
    {
        public static void HandleEnemyProjectileBlockCollision(IProjectile projectile, IGameObject block, ICollision side)
        {
            if (projectile is GoriyaBoomerang&&block is IWall)
            {
                ((GoriyaBoomerang)projectile).ReverseBoomerang();
            }
            if (projectile is AquamentusFireball)
            {
                CollisionManager.GameObjectList.Remove(projectile);

                ((AquamentusFireball)projectile).Disappear();
            }
        }
    }
}
