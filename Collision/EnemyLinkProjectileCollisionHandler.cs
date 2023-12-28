using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player.Interfaces;
using System.Collections.Generic;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Sprint2_Attempt3.Enemy.Target;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Collision
{
    internal class EnemyLinkProjectileCollisionHandler
    {
        public EnemyLinkProjectileCollisionHandler() { }

        public static void HandleLinkProjectileEnemyCollision(IEnemy enemy, ILinkProjectile item, ICollision side, List<IGameObject> objects )
        {
            if(item is IBoomerang)
            {
                enemy.Stun();
                ((IBoomerang)item).ReverseDirection();
            }
            else if(item is IArrow)
            {
                if(!(enemy is Dodongo))
                    enemy.GetDamaged(1.0f);
                if(enemy is Target)
                    SoundFactory.PlaySound(SoundFactory.Instance.ping);
                IArrow arrow = (IArrow)item;
                arrow.DestroyArrow();
            }
            else if(item is ISwordBeam)
            {
                if (!(enemy is Dodongo || enemy is Target))
                    enemy.GetDamaged(0.5f);
                ((ISwordBeam)item).RemoveSwordBeam();
            }
            else if(item is IBomb && enemy is Dodongo)
            {
                ((Dodongo)enemy).GetDamaged(2.0f);
                ((IBomb)item).RemoveBomb();
            }
            else if(item is ISword) 
            {
                if (!(enemy is Dodongo || enemy is Target))
                    enemy.GetDamaged(0.5f);
            }
            else if(item is not IBomb)
            {
                if(!(enemy is Dodongo || enemy is Target))
                    enemy.GetDamaged(2.0f);
            }
        }
    }
}
