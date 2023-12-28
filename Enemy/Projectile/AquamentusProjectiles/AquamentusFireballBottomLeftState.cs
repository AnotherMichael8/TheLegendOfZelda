using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

internal class AquamentusFireballBottomLeftState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
    private IEnemyProjectileSprite sprite;

    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
    private int projDistance;
    private int traveledDistance;
    //private int horDistance = 12;

    public AquamentusFireballBottomLeftState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;

        projDistance = AquamentusFireball.fireBallMaxDistance;
        change = AquamentusFireball.fireballSpeed;
        traveledDistance = 0;

    }
    public void Update()
    {
        currentFrame++;
        if (currentFrame < AquamentusFireball.fireballSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;
            }

            AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X - change, (float)(AquamentusFireball.Position2.Y +change*0.25));
            traveledDistance += change;
            if (traveledDistance >= projDistance)
            {
                AquamentusFireball.Fire = false;
                CollisionManager.GameObjectList.Remove(AquamentusFireball);
            }
            /*if (AquamentusFireball.Position2.X <= 100 || AquamentusFireball.Position2.Y <= 89 || AquamentusFireball.Position2.Y >= 336)
            {
                AquamentusFireball.Fire = false;
            }*/
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X, (int)(AquamentusFireball.Position2.Y), AquamentusFireball.AquamentusFireballLeft[spriteIndex]);
    }
}
