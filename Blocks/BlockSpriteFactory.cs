using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks.BlockSprites;
//using System.Numerics;

namespace Sprint2_Attempt3.Blocks
{
    public class BlockSpriteFactory
    {
        public Texture2D blocks { get; set; }


        private static BlockSpriteFactory instance = new BlockSpriteFactory();

        public static BlockSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private BlockSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            blocks = content.Load<Texture2D>("blocks");

        }
    }
}