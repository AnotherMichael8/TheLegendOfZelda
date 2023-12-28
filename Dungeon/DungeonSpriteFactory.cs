using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Doors.DoorSprites;
using Sprint2_Attempt3.Dungeon.Rooms;

namespace Sprint2_Attempt3.Dungeon
{
    internal class DungeonSpriteFactory
    {
        private static Texture2D DungeonTexture;
        private static Texture2D DungeonLayoutTexture;
        private static Texture2D BlockTexture;
        private static DungeonSpriteFactory instance = new DungeonSpriteFactory();
        public static DungeonSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        public DungeonSpriteFactory()
        {

        }

        public void LoadAllTextures(ContentManager content)
        {
            DungeonTexture = content.Load<Texture2D>("Dungeon_Doors");
            DungeonLayoutTexture = content.Load<Texture2D>("DungeonSprites");
            BlockTexture = content.Load<Texture2D>("blocks");
        }

        public DungeonRoomSprite CreateDungeonRoomSprite()
        {
            return new DungeonRoomSprite(DungeonTexture);
        }
        public DungeonRoomSprite CreateWhiteStairRoomSprite()
        {
            return new DungeonRoomSprite(DungeonLayoutTexture);
        }

        public IDoorSprite CreateNorthDoorSprite()
        {
            return new NorthDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateSouthDoorSprite()
        {
            return new SouthDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateEastDoorSprite()
        {
            return new EastDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateWestDoorSprite()
        {
            return new WestDoorSprite(DungeonTexture);
        }
        public IDoorSprite CreateStairExitSprite()
        {
            return new StairExitSprite(DungeonTexture);
        }
        public IDoorSprite CreateStairEntranceSprite()
        {
            return new StairEntranceSprite(BlockTexture);
        }
        public TriggerSquareSprite CreateTriggerSquareSprite()
        {
            return new TriggerSquareSprite(BlockTexture);
        }
    }
}