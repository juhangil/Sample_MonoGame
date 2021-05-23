using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sample_MonoGame
{
    public class Core : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Core()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            tracedSize = GraphicsDevice.PresentationParameters.Bounds;
            canvas = new Texture2D(GraphicsDevice, tracedSize.Width, tracedSize.Height, false, SurfaceFormat.Color);
            pixels = new UInt32[tracedSize.Width * tracedSize.Height];

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        Texture2D canvas;
        Rectangle tracedSize;
        UInt32[] pixels;

        Random rnd = new Random();
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            GraphicsDevice.Textures[0] = null;
            pixels[rnd.Next(pixels.Length)] = 0xFF00FF00;
            canvas.SetData<UInt32>(pixels, 0, tracedSize.Width * tracedSize.Height);

            _spriteBatch.Begin();
            _spriteBatch.Draw(canvas, new Rectangle(0, 0, tracedSize.Width, tracedSize.Height), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
