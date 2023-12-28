using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Sounds;

namespace Sprint2_Attempt3.Portal
{
    public class Portal : IPortal
    {
        public Rectangle position { get; set; }
        public Portal LinkedPortal { get; set; }
        private readonly Rectangle sourceRectangle = new Rectangle(263, 20, 227, 466);

        public Portal(Rectangle position, Portal linkedPortal) 
        {
            this.position = position;
            LinkedPortal = linkedPortal;
        }
        public virtual void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, position, sourceRectangle, color);
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 change)
        {
            Rectangle destinationRectangle = new Rectangle(position.X + (int)(change.X * 3.125), position.Y + (int)(change.Y * 3.125), 50, 50);
            
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos)
        {
            Rectangle destinationRectangle = new Rectangle((int)(position.X + initialPos.X + change.X * 3.125), (int)(position.Y + initialPos.Y + change.Y * 3.125), 50, 50);
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, destinationRectangle, sourceRectangle, Color.White);
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(position.X+24, position.Y+24,  1, 1);
        }
        public Vector2 Teleport()
        {
            SoundFactory.PlaySound(SoundFactory.Instance.teleport);
            return new Vector2(LinkedPortal.position.X, LinkedPortal.position.Y);
        }
    }
}
