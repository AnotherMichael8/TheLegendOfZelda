using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class SwordPlaceholderSprite : ILinkSprite
    {
        public SwordPlaceholderSprite(Texture2D linkTexture)
        {
        }

        public void Update()
        {

        }
        public void Draw(SpriteBatch spritebatch, Vector2 location, Color color)
        {
        }
    }
}
