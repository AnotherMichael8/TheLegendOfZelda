using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Net.Http;

namespace Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles
{
    internal class AquamentusFireball : IEnemyProjectile
    {
        private IEnemyProjectileState state;
        private Vector2 position2;
        private static Rectangle AquamentusFireball1 { get { return new Rectangle(100, 3, 9, 11); } }
        private static Rectangle AquamentusFireball2 { get { return new Rectangle(109, 3, 9, 11); } }
        private static Rectangle AquamentusFireball3 { get { return new Rectangle(118, 3, 9, 11); } }
        private static Rectangle AquamentusFireball4 { get { return new Rectangle(127, 3, 9, 11); } }

        public static Rectangle[] AquamentusFireballLeft { get; } = { AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4, AquamentusFireball1, AquamentusFireball2, AquamentusFireball3, AquamentusFireball4 };
        public int fireBallWidth { get; } = 9;
        public int fireBallHeight { get; } = 11;
        public int fireballSpeed { get; } = 5;
        public  int fireballSpriteSwitchSpeed { get; } = 40;
        public  int fireBallMaxDistance { get; } = 500;
        public Vector2 Position2 { get { return position2; } set { position2 = value; } }
        private int count;
        private bool fire;
        public bool Fire { get { return fire; } set { fire = value; } }
        private int HitBoxWidth = 9;
        private int HitBoxHeight = 11;

        public IEnemyProjectileState State
        {
            get { return state; }
            set { state = value; }
        }
        public void GenerateLeft()
        {
            state = new AquamentusFireballLeftState(this);
        }
        public void GenerateRight()
        {
            state = new AquamentusFireballRightState(this);
        }
        public void GenerateTopRight()
        {
            state = new AquamentusFireballTopRightState(this);
        }
        public void GenerateBottomRight()
        {
            state = new AquamentusFireballBottomRightState(this);
        }
        public void GenerateTopLeft()
        {
            state = new AquamentusFireballTopLeftState(this);
        }
        public void GenerateBottomLeft()
        {
            state = new AquamentusFireballBottomLeftState(this);
        }
        public void Disappear()
        {
            state = new AquamentusFireballDisappearState(this);
        }

        public AquamentusFireball(Vector2 fireballPosition)
        {
            position2 = fireballPosition;
            fire = false;
        }
        public void Update()
        {
            state.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            state.Draw(spriteBatch);
        }
        public Rectangle GetHitBox() {
            return new Rectangle((int)Position2.X, (int)Position2.Y, fireBallWidth * (int)Globals.scale, fireBallHeight * (int)Globals.scale);
        }

    }
}
