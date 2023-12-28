using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Portal;
using Sprint2_Attempt3.WallBlocks;
using System.Collections.Generic;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Dungeon;

namespace Sprint2_Attempt3.Collision
{
    public class CollisionDetector
    {
        public static bool CheckPlayerCollision(ILink link, IGameObject obj, Game1 game)
        {
            Rectangle linkRectangle = link.GetHitBox();
            bool ChangedRooms = false;
            Rectangle collisionRectangle = obj.GetHitBox();
            if(obj is SpikeTrap || obj is HandCreator)
            {
                TripwireHandler.HandleTripwire(obj, link);
            }
            if (collisionRectangle.Intersects(linkRectangle))
            {
                ICollision side = SideDetector(linkRectangle, collisionRectangle);
                if (obj is IEnemy)
                {
                    PlayerEnemyHandler.HandlePlayerEnemyCollision(link, (IEnemy)obj, side);
                }
                else if (obj is IWall)
                {
                    CheckPlayerHitWallCollision.CheckPlayerWallCollision(link, (IWall)obj);
                }
                else if (obj is IBlock)
                {
                    PlayerBlockHandler.HandlePlayerBlockCollision(link, (IBlock)obj, side);
                }
                else if (obj is IDoor)
                {
                    ChangedRooms = PlayerBlockHandler.HandlePlayerDoorCollision(link, (IDoor)obj, side, game);
                }
                else if (obj is IPortal)
                {
                    PlayerPortalHandler.HandlePlayerPortalCollision(link, (Portal.Portal)obj, game);
                }
                else if (obj is ILinkProjectile)
                {
                    PlayerLinkProjectileHandler.HandlePlayerLinkProjectileCollision(link, (ILinkProjectile)obj, side);
                }
                else if (obj is IItem)
                {
                    PlayerItemCollisionHandler.HandlePlayerItemCollision((IItem)obj, link);
                }
                else if (obj is IEnemyProjectile)
                {
                    PlayerEnemyProjectileHandler.HandleLinkProjectileCollision(link, (IEnemyProjectile)obj, side);
                }
                else if (obj is TriggerSquare)
                {
                    ((TriggerSquare)obj).Start();
                }
            }
            return ChangedRooms;
        }
        public static ICollision SideDetector(Rectangle affectedSprite, Rectangle nonAffectedSprite)
        {
            Rectangle intersect = Rectangle.Intersect(affectedSprite, nonAffectedSprite);
            if (intersect.Width > intersect.Height)
            {
                if (affectedSprite.Top < nonAffectedSprite.Top && affectedSprite.Bottom < nonAffectedSprite.Bottom)
                {
                    return new TopCollision();
                }
                else
                {
                    return new BottomCollision();
                }
            }
            else
            {
                if (affectedSprite.Left < nonAffectedSprite.Left && affectedSprite.Right < nonAffectedSprite.Right)
                {
                    return new LeftCollision();
                }
                else
                {
                    return new RightCollision();
                }
            }
        }

        public static void CheckEnemyCollision(IEnemy enemy, IGameObject obj, List<IGameObject> gameObjectList)
        {
            Rectangle enemyRectangle = enemy.GetHitBox();
            Rectangle collisionRectangle = obj.GetHitBox();
            if (collisionRectangle.Intersects(enemyRectangle))
            {
                ICollision side = SideDetector(collisionRectangle, enemyRectangle);
                if (obj is ILinkProjectile)
                {
                    EnemyLinkProjectileCollisionHandler.HandleLinkProjectileEnemyCollision(enemy, (ILinkProjectile)obj, side, gameObjectList);
                }
                else if (obj is IBlock || obj is IDoor)
                {
                    EnemyBlockHandler.HandleEnemyBlockCollision(enemy, obj, collisionRectangle);
                }
            }
        }
        public static void CheckEnemyWallCollision(IWall wall, IEnemy enemy)
        {
            
            if (enemy.GetHitBox().Intersects(wall.GetHitBox()))
            {
                EnemyWallHandler.HandleEnemyWallCollision(wall.GetHitBox(), enemy);
            }
        }
        public static void CheckLinkProjectileCollision(IGameObject projectile, IGameObject obj)
        {
            Rectangle projectileRectangle = projectile.GetHitBox();
            Rectangle collisionRectangle = obj.GetHitBox();
            if (collisionRectangle.Intersects(projectileRectangle))
            {
                ICollision side = SideDetector(collisionRectangle, projectileRectangle);
                if (obj is IBlock)
                {
                    ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IBlock)obj, side);
                }
                else if (obj is IWall)
                {
                    ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IWall)obj, side);
                }
                else if (obj is IDoor)
                {
                    ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IDoor)obj, side);
                }
            }
        }
        public static void CheckEnemyProjectileCollision(IGameObject projectile, IGameObject obj)
        {
            Rectangle projectileRectangle = projectile.GetHitBox();
            Rectangle collisionRectangle = obj.GetHitBox();
            if (collisionRectangle.Intersects(projectileRectangle))
            {
                ICollision side = SideDetector(collisionRectangle, projectileRectangle);
                if (obj is IBlock)
                {
                    //EnemyBlockCollisionHandler.CorrectPositioning();
                }
                else if (obj is IWall)
                {
                    EnemyProjectileBlockHandler.HandleEnemyProjectileBlockCollision((IProjectile)projectile, (IWall)obj, side);
                    //System.Diagnostics.Debug.WriteLine("enemy");
                    //HandleCollision.HandleProjectileBlockCollision((ILinkProjectile)gameObjectList[i]);
                }
                else if (obj is IDoor)
                {

                    EnemyProjectileBlockHandler.HandleEnemyProjectileBlockCollision((IProjectile)projectile, (IDoor)obj, side);
                }
            }
        }
    }
}
