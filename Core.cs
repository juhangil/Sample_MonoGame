using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using SampleMonoGame.Test;

namespace SampleMonoGame
{
    public class Core : Game
    {
        public static Core instance = null;

        public Core()
        {
            instance = this;

            _graphics = new GDMController(this);

            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            Utility.ColorToInt(Color.White);
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
            MakeObject();

            tracedSize = GraphicsDevice.PresentationParameters.Bounds;
            ObjectBase.LoadContentsCallbacks?.Invoke();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                Exit();

            ObjectBase.UpdateCallbacks?.Invoke();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(tester._texture, tester.GetRect(), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        #endregion

        private void MakeObject()
        {
            tester = new TestAIObject(Point.Zero, new Point(50, 50), Color.Cyan);
        }
    }
}
