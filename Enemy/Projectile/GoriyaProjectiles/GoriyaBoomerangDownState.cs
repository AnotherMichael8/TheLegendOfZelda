using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;

internal class GoriyaBoomerangDownState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goDown;
    private int currDist;
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;



    public GoriyaBoomerangDownState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingBoomerang();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        currDist = 0;
        goDown = goriyaBoomerang.GoDown;
        change = GoriyaBoomerang.boomerangSpeed;

    }


    public void Update(/*gameTime gametime*/)
    {
        
        currentFrame++;
        if (currentFrame < GoriyaBoomerang.boomerangSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;

            }
            goDown = goriyaBoomerang.GoDown;
            if (goDown)
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y + change);
                currDist += change;
                if (currDist >= goriyaBoomerang.MaxDist)
                {
                    goriyaBoomerang.GoDown = false;
                }
            }
            else
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y - change);
                if (goriyaBoomerang.Position2.Y <= goriyaBoomerang.InitialY + 17)
                {
                    goriyaBoomerang.Throwing = false;
                    CollisionManager.GameObjectList.Remove(goriyaBoomerang);
                    goriyaBoomerang.GoDown = true;

                }
            }
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        GoriyaBoomerang.currentIndex = spriteIndex;
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position2.X + 6, (int)goriyaBoomerang.Position2.Y + 18, GoriyaBoomerang.GoriyaBoomerangLeft[spriteIndex]);
    }
}
