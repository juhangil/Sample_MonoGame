using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using SampleMonoGame.Test;

namespace SampleMonoGame
{
    public class Core : Game
    {
        public Core()
        {
            _graphics = new GDMController(this);

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        #region Properties
        private GDMController _graphics = null;
        private SpriteBatch _spriteBatch;
        #endregion

        #region FrameWork Callbacks
        protected override void Initialize()
        {
            _graphics.Initialize();
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            base.Initialize();
        }

        private Rectangle tracedSize;
        private TestAIObject tester = null;

        protected override void LoadContent()
        {
            tracedSize = GraphicsDevice.PresentationParameters.Bounds;
            tester = new TestAIObject(new Point(100, 100), new Texture2D(GraphicsDevice, 100, 100, false, SurfaceFormat.Color));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                Exit();

            tester.MoveRandomPosition(new Point(tracedSize.Width, tracedSize.Height));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(tester.texture, tester.GetRect(), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        #endregion
    }
}
