using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IosTest
{
    public class Game1 : Game
    {
        private SpriteBatch _spriteBatch;
        private Texture2D _alien;

        public Game1()
        {
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _alien = Content.Load<Texture2D>("alien");
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Draw(_alien, new Vector2(100, 100), Color.White);
            base.Draw(gameTime);
        }
    }
}