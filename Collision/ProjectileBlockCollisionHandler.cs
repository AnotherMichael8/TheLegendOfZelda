using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Collision
{
    public class ProjectileBlockCollisionHandler
    {
        public static void HandleProjectileBlockCollision(IProjectile projectile, IGameObject block, ICollision side)
        {
            if (projectile is IBoomerang && block is IWall)
            {
                ((IBoomerang)projectile).ReverseDirection();
            }
            else if (projectile is IArrow && block is IWall)
            {
                ((IArrow)projectile).DestroyArrow();
            }
            else if (projectile is IFire && block is IWall)
            {
                ((IFire)projectile).Stop();
            }
            else if (projectile is BombExplosion && block is IDoor) {
                IDoor door = (IDoor)block;
                if (door.IsBombWall) {
                    door.Damage();
                }
            }
            else if(projectile is ISwordBeam && block is IWall)
            {
                if (!((IWall)block).projectilesThrowable)
                ((ISwordBeam)projectile).RemoveSwordBeam();
            }
        }
    }
}
