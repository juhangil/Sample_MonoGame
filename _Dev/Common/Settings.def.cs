using Microsoft.Xna.Framework;

namespace SampleMonoGame
{
    public class GraphicsSettings
    {
        public static readonly int SCREEN_WIDTH = 1280;
        public static readonly int SCREEN_HEIGHT = 720;
        public static readonly bool FULL_SCREEN_MODE = false;
        public static readonly Color BASE_OBJECT_COLOR = Color.HotPink;

        public static void SetupResolution(GraphicsDeviceManager manager)
        {
            manager.PreferredBackBufferWidth = GraphicsSettings.SCREEN_WIDTH;
            manager.PreferredBackBufferHeight = GraphicsSettings.SCREEN_HEIGHT;

            manager.IsFullScreen = GraphicsSettings.FULL_SCREEN_MODE;

            manager.ApplyChanges();
        }
    }
}