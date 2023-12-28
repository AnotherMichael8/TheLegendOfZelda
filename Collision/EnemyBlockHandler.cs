using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.WallBlocks;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy.SpikeTrap;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyBlockHandler
    {
        public static void HandleEnemyBlockCollision(IEnemy enemy, IGameObject obj, Rectangle collisionRectangle)
        {
            Boolean check = true;
            if (enemy is Hand)
            {
                Hand newHand = (Hand)enemy;
                if (newHand.State is CapturedState)
                {
                    check = false;
                }
            }
            if (check)
            {
                bool blocked = false;
                if (obj is IBlock)
                {
                    var block = (IBlock)obj;
                    if (!block.isWalkable)
                    {
                        blocked = true;
                    }
                }
                else if (obj is IWall)
                {
                    blocked = true;
                }
                else if (obj is IDoor)
                {
                    blocked = true;
                }
                if (blocked)
                {
                    Rectangle hitBox = enemy.GetHitBox();
                    if (enemy is Hand)
                    {
                        hitBox = new Rectangle(hitBox.X, hitBox.Y, hitBox.Width / 2, hitBox.Height / 2);
                    }
                    ICollision side = CollisionDetector.SideDetector(hitBox, collisionRectangle);

                    if (enemy is not Hand)
                    {
                        if (side is BottomCollision)
                        {

                            enemy.MoveDown();
                            enemy.Y = collisionRectangle.Bottom;
                        }
                        else if (side is LeftCollision)
                        {
                            enemy.MoveLeft();
                            enemy.X = collisionRectangle.Left - enemy.Position.Width - 1;
                        }
                        else if (side is RightCollision)
                        {
                            enemy.MoveRight();
                            enemy.X = collisionRectangle.Right + 1;
                        }
                        else
                        {
                            enemy.MoveUp();
                            enemy.Y = collisionRectangle.Top - enemy.Position.Height - 1;
                        }
                    }
                    enemy.numWallCollisions++;
                }
                if (enemy.numWallCollisions > 2)
                {
                    enemy.numWallCollisions = 0;
                    enemy.ChangeDirection();
                }
            }
        }
    }
}
