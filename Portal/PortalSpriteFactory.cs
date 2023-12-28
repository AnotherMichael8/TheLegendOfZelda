using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Portal
{
    internal class PortalSpriteFactory
    {
        public Texture2D portal { get; set; }

        private static PortalSpriteFactory instance = new PortalSpriteFactory();

        public static PortalSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private PortalSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            portal = content.Load<Texture2D>("portal");
        }
    }
}