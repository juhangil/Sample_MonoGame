using Microsoft.Xna.Framework;

namespace SampleMonoGame 
{
    public class GDMController
    {
        public GDMController(Game targetInstance)
        {
            _graphicsManager = new GraphicsDeviceManager(targetInstance);
        }

        public void Initialize()
        {
            GraphicsSettings.SetupResolution(_graphicsManager);
        }

        private GraphicsDeviceManager _graphicsManager = null;
    }
}