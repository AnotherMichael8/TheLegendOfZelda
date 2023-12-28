using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkSprites;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesSprites;

namespace Sprint2_Attempt3.Player
{
    public class LinkSpriteFactory
    {
        private static Texture2D linkTexture;
        private static Texture2D deathTexture;
        private static Texture2D itemTexture;
        private Texture2D items;
        private static LinkSpriteFactory instance = new LinkSpriteFactory();
        public static LinkSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private LinkSpriteFactory() { }
        public void LoadAllTextures(ContentManager content)
        {
            linkTexture = content.Load<Texture2D>("LinkPlayerSpriteSheetFinal");
            deathTexture = content.Load<Texture2D>("characterGenerationSprite");
            itemTexture = content.Load<Texture2D>("Items");
        }

        public ILinkSprite CreateDownAttackLinkSprite()
        {
            return new DownAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateDownIdleLinkSprite()
        {
            return new DownIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateDownMovingLinkSprite()
        {
            return new DownMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftAttackLinkSprite()
        {
            return new LeftAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftIdleLinkSprite()
        {
            return new LeftIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftMovingLinkSprite()
        {
            return new LeftMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightAttackLinkSprite()
        {
            return new RightAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightIdleLinkSprite()
        {
            return new RightIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightMovingLinkSprite()
        {
            return new RightMovingLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpAttackLinkSprite()
        {
            return new UpAttackLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpIdleLinkSprite()
        {
            return new UpIdleLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpMovingLinkSprite()
        {
            return new UpMovingLinkSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateAttackLinkSwordSprite()
        {
            return new AttackSwordSprite(linkTexture);
        }
        public ILinkSprite CreateDownItemLinkSprite()
        {
            return new DownUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateUpItemLinkSprite()
        {
            return new UpUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateLeftItemLinkSprite()
        {
            return new LeftUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateRightItemLinkSprite()
        {
            return new RightUseItemLinkSprite(linkTexture);
        }
        public ILinkSprite CreateCapturedLinkSprite()
        {
            return new CapturedLinkSprite();
        }
        public ILinkProjectileSprite CreateBombItem()
        {
            return new BombSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateArrowItem()
        {
            return new ArrowSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateBoomerangItem()
        {
            return new BoomerangSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateBlueBoomerangItem()
        {
            return new BlueBoomerangSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateBlueArrowItem()
        {
            return new BlueArrowSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateFireItem()
        {
            return new FireSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateItemHitSprite()
        {
            return new ItemHitSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateBombExplosion()
        {
            return new BombExplosionSprite(linkTexture);
        }
        public ILinkProjectileSprite CreatePoofAnimation()
        {
            return new PoofSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateSwordBeamSprite()
        {
            return new SwordBeamSprite(linkTexture);
        }
        public ILinkProjectileSprite CreateSwordBeamExplosionSprite()
        {
            return new SwordBeamExplosionSprite(linkTexture);
        }
        public ILinkSprite CreateDeadLink()
        {
            return new DeadLinkSprite(deathTexture);
        }
        public ILinkSprite CreateTriForceLink()
        {
            return new TriForceLinkSprite(linkTexture, itemTexture);
        }
        public ILinkSprite CreateBowLink()
        {
            return new BowLinkSprite(linkTexture, itemTexture);
        }
    }
}

