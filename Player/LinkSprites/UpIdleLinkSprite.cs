using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkSprites
{
    public class UpIdleLinkSprite : ILinkSprite
    {
        Texture2D link2D;

        public UpIdleLinkSprite(Texture2D link2D)
        {
            this.link2D = link2D;
        }
        public void Draw(SpriteBatch _spriteBatch, Vector2 position, Color color)
        {

            Rectangle sourceRectangle;
            Rectangle targetRectangle;

            sourceRectangle = new Rectangle(69, 11, 15, 15);
            targetRectangle = new Rectangle((int)position.X, (int)position.Y, 45, 45);
            _spriteBatch.Draw(link2D, targetRectangle, sourceRectangle, color);
        }

        public void Update()
        {

        }


    }
}
