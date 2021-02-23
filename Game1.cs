using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Town_Guard
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

//Start the 2D stuff tex2d allows for draw vector2 is for 2d position of sprite.
        private Texture2D _texture;
        private Vector2 _position;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //Loads Texture from Content Manager
            _texture = Content.Load<Texture2D>("Knight");
            
            //loads sprite on screen at top left
            _position = new Vector2(0,0);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _position.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _position.Y += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _position.X -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _position.X += 1;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            //Adding sprites to batch
            _spriteBatch.Begin();

            _spriteBatch.Draw(_texture, _position, Color.White);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
