using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Screens
{
    public class ScreenSpriteFactory
    {
        private static Texture2D startScreenTexture;
        private static Texture2D deathAndPauseScreenTexture;
        private static Texture2D selectorTexture;
        // More private Texture2Ds follow
        // ...

        private static ScreenSpriteFactory instance = new ScreenSpriteFactory();

        public static ScreenSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private ScreenSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            startScreenTexture = content.Load<Texture2D>("TitleScreen");
            deathAndPauseScreenTexture = content.Load<Texture2D>("DeathAndPauseScreen");
            selectorTexture = content.Load<Texture2D>("FileSelection");
        }
        public IScreenSprite CreateStartScreen()
        {
            return new StartScreenSprite(startScreenTexture, selectorTexture);
        }
        public IScreenSprite CreateDeathScreen()
        {
            return new DeathScreenSprite(deathAndPauseScreenTexture, selectorTexture); 
        }
        public IScreenSprite CreatePauseScreen()
        {
            return new PauseScreenSprite(deathAndPauseScreenTexture, selectorTexture);
        }
        public IScreenSprite CreateChooseFileScreen()
        {
            return new ChooseFileScreenSprite(deathAndPauseScreenTexture, selectorTexture);
        }
    }
}
