using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;

namespace Sprint2_Attempt3.Sounds
{
    public class SoundFactory
    {
        public SoundEffect getHeart { get; set; }
        public SoundEffect enemyHit { get; set; }
        public SoundEffect enemyDie { get; set; }
        public SoundEffect linkHit { get; set; }
        public SoundEffect linkDie { get; set; }
        public SoundEffect swordSlash { get; set; }
        public SoundEffect arrowBoomerang { get; set; }
        public SoundEffect bombDrop { get; set; }
        public SoundEffect bombBlow { get; set; }
        public SoundEffect lowHealth { get; set; }
        public SoundEffect getItem { get; set; }
        public SoundEffect getRupee { get; set; }
        public SoundEffect text { get; set; }
        public SoundEffect keyAppear { get; set; }
        public SoundEffect doorUnlock { get; set; }
        public SoundEffect stairs { get; set; }
        public SoundEffect bossScream { get; set; }
        public SoundEffect bossHurt { get; set; }
        public SoundEffect secret { get; set; }
        public SoundEffect triforce { get; set; }
        public SoundEffect teleport { get; set; }

        public SoundEffect rickRoll { get; set; }
        public SoundEffect ping { get; set; }
        public SoundEffect undertale { get; set; }
        public SoundEffect titleScreen { get; set; }

        private SoundEffectInstance backgroundMusicInstance;
        private SoundEffectInstance undertaleMusicInstance;
        private SoundEffectInstance titleScreenMusicInstance;
        private SoundEffectInstance rickRollInstance;

        public SoundEffectInstance rickRollMusic { get => rickRollInstance; }
        public SoundEffectInstance backgroundMusic { get => backgroundMusicInstance; }
        public SoundEffectInstance undertaleMusic { get => undertaleMusicInstance; }
        public SoundEffectInstance titleScreenMusic { get => titleScreenMusicInstance; }

        private static SoundFactory instance = new SoundFactory();

        public static SoundFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public SoundFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            getHeart = content.Load<SoundEffect>("LOZ_Get_Heart");
            enemyHit = content.Load<SoundEffect>("LOZ_Enemy_Hit");
            enemyDie = content.Load<SoundEffect>("LOZ_Enemy_Die");
            linkHit = content.Load<SoundEffect>("LOZ_Link_Hurt");
            linkDie = content.Load<SoundEffect>("LOZ_Link_Die");
            swordSlash = content.Load<SoundEffect>("LOZ_Sword_Slash");
            arrowBoomerang = content.Load<SoundEffect>("LOZ_Arrow_Boomerang");
            bombDrop = content.Load<SoundEffect>("LOZ_Bomb_Drop");
            bombBlow = content.Load<SoundEffect>("LOZ_Bomb_Blow");
            lowHealth = content.Load<SoundEffect>("LOZ_LowHealth");
            getItem = content.Load<SoundEffect>("LOZ_Get_Item");
            getRupee = content.Load<SoundEffect>("LOZ_Get_Rupee");
            text = content.Load<SoundEffect>("LOZ_Text");
            keyAppear = content.Load<SoundEffect>("LOZ_Key_Appear");
            doorUnlock = content.Load<SoundEffect>("LOZ_Door_Unlock");
            stairs = content.Load<SoundEffect>("LOZ_Stairs");
            bossScream = content.Load<SoundEffect>("LOZ_Boss_Scream1");
            bossHurt = content.Load<SoundEffect>("LOZ_Boss_Hit");
            secret = content.Load<SoundEffect>("LOZ_Secret");
            triforce = content.Load<SoundEffect>("triforce_obtained");
            rickRoll = content.Load<SoundEffect>("rickRoll");
            ping = content.Load<SoundEffect>("ping");
            undertale = content.Load<SoundEffect>("Its_Showtime");
            teleport = content.Load<SoundEffect>("TeleportNoise");
            titleScreen = content.Load<SoundEffect>("titleScreenMusic");

            undertaleMusicInstance = undertale.CreateInstance();
            undertaleMusicInstance.IsLooped = true;
            undertaleMusicInstance.Volume *= 0.1f;
            undertaleMusicInstance.Pause();

            titleScreenMusicInstance = titleScreen.CreateInstance();
            titleScreenMusicInstance.IsLooped = true;
            titleScreenMusicInstance.Volume *= 0.1f;
            titleScreenMusicInstance.Play();

            SoundEffect backgroundMusic = content.Load<SoundEffect>("Underworld");
            backgroundMusicInstance = backgroundMusic.CreateInstance();
            backgroundMusicInstance.IsLooped = true;
            backgroundMusicInstance.Volume *= 0.1f;
            backgroundMusicInstance.Pause();

            rickRollInstance = rickRoll.CreateInstance();
            rickRollInstance.IsLooped = false;
            rickRollInstance.Volume *= 0.1f;
            rickRollInstance.Pause();
        }

        public static void PlaySound(SoundEffect sound, float volume = 1)
        {
            float pitch = 0.0f;
            float pan = 0.0f;

            sound.Play(volume, pitch, pan);
        }

        public static void ResetSounds()
        {
            Instance.titleScreenMusic.Pause();
            Instance.undertaleMusic.Pause();
            Instance.rickRollMusic.Stop();
            Instance.backgroundMusic.Resume();
        }

    }
}