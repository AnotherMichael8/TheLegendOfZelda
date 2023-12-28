using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Screens;
using Sprint2_Attempt3.Portal;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        public enum GameState { 
            startScreen,
            pause,
            start,
            itemMenu,
            linkDead,
            chooseFile
        }
        public GameState gameState { get; set; }
        public static Texture2D InventoryTexture { get; set; }
        private KeyboardController keyController { get; set; }
        private MouseController mouseController { get; set; }
        private InventoryController inventoryController { get; set; }
        public ILink link { get; set; }
        public IRoom room { get; set; }
        public ISprite screenSprite { get; set; }
        public bool gamePaused { get; set; }
        public bool deathAnimationActive { get; set; }

        private GameTime gameTime;
        public GameTime Gametime { get { return gameTime; } }

        public CollisionManager collisionManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            base.Initialize();
            graphics.PreferredBackBufferHeight = Globals.ScreenHeight;
            graphics.ApplyChanges();
        }
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.MakeFloorGrid();
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            SoundFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            ScreenSpriteFactory.Instance.LoadAllTextures(Content);
            PortalSpriteFactory.Instance.LoadAllTextures(Content);
            //check if we need start screen
            PanningTransitionHandler.Instance.setGame1(this);
            //update into states later
            FadingTransitionHandler.Instance.setGame1(this);
            RoomGenerator.Instance.LoadAllFiles();
            InventoryTexture = Content.Load<Texture2D>("Inventory");
            link = new Link(this);
            collisionManager = new CollisionManager(this, (Link)link);
            gameState = GameState.startScreen;
            screenSprite = ScreenSpriteFactory.Instance.CreateStartScreen();
            inventoryController = new InventoryController(this);
            room = RoomSecondary.LoadRooms(this);
            keyController = new KeyboardController(this);
            mouseController = new MouseController(this);
            deathAnimationActive = false;
        }
        protected override void UnloadContent() { }
        public void Reset()
        {
            link = new Link(this);
            gameState = GameState.start;
            deathAnimationActive = false;
            collisionManager = new CollisionManager(this, (Link)link);
        }

        protected override void Update(GameTime gameTime)
        {
            keyController.Update(gameTime);
            switch (gameState)
            {
                case GameState.start:
                    room.Update();
                    if (!(deathAnimationActive || PanningTransitionHandler.Instance.Start || FadingTransitionHandler.Instance.Start))
                    {
                        inventoryController.Update();
                        collisionManager.Update();
                    }
                    break;
                case GameState.pause:
                    inventoryController.Update();
                    break;
                case GameState.chooseFile:
                    mouseController.Update(gameTime);
                    break;
                case GameState.itemMenu:
                    inventoryController.Update();
                    break;

            } 
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.gameTime = gameTime;
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            switch (gameState) { 
                case GameState.start:
                    room.Draw(spriteBatch, Color.White);
                    inventoryController.Draw(spriteBatch);
                    break;
                case GameState.itemMenu:
                    if (InventoryController.itemMenuState != InventoryController.ItemMenuState.fullView)
                        room.Draw(spriteBatch, Color.White);
                    inventoryController.Draw(spriteBatch);
                    break;
                default:
                    screenSprite.Draw(spriteBatch);
                    break;

            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}