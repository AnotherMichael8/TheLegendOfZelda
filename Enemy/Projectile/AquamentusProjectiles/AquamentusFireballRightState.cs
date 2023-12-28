using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

internal class AquamentusFireballRightState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goRight;
    /*private bool finished;
    public bool Finished
    {
        get { return finished; }
        set { finished = value; }
    }*/
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
    private int projDistance;
    private int traveledDistance;


    public AquamentusFireballRightState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;

        projDistance = AquamentusFireball.fireBallMaxDistance;
        change = AquamentusFireball.fireballSpeed;
        traveledDistance = 0;
    }


    public void Update(/*gameTime gametime*/)
    {
        /*
        timeSinceLastUpdate += gametime.ElapsedGameTime;
        spriteIndex = (int)(timeSinceLastUpdate / (0.5f));
        if (spriteIndex > 7)
        {
            spriteIndex = 0;
            timeSinceLastUpdate = 0;
        }*/
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
            AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X + change, AquamentusFireball.Position2.Y);
            traveledDistance += change;
            if (traveledDistance >= projDistance)
            {
                AquamentusFireball.Fire = false;
                //CollisionDetector.GameObjectList.Remove(AquamentusFireball);
            }
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
       sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X, (int)AquamentusFireball.Position2.Y, AquamentusFireball.AquamentusFireballLeft[spriteIndex]);
    }
}
