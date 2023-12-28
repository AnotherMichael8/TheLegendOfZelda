using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;


namespace Sprint2_Attempt3.Collision
{
    public class PlayerLinkProjectileHandler
    {
        public PlayerLinkProjectileHandler() { }
        public static void HandlePlayerLinkProjectileCollision(ILink link, ILinkProjectile linkProjectile, ICollision side)
        {
            if (linkProjectile is IBoomerang)
            {
                link.Items.Remove(linkProjectile);
                CollisionManager.GameObjectList.Remove(linkProjectile);
            }
        }
    }
}
