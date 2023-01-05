using mg_Reverence.Managers;

namespace mg_Reverence.Core
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private StateManager _stateManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            //set game window
            _graphics.PreferredBackBufferWidth = Data.ScreenWidth;
            _graphics.PreferredBackBufferHeight = Data.ScreenHeight;
            _graphics.ApplyChanges();

            _stateManager = new StateManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _stateManager.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            /*if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();*/

            if (Data.Exit) Exit();

            _stateManager.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            //_spriteBatch.Begin();

            _stateManager.Draw(_spriteBatch);

            //_spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}