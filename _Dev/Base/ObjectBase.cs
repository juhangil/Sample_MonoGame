using System;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SampleMonoGame
{
    public class ObjectBase
    {
        public static ObjectCallbacks LoadContentsCallbacks = null;
        public static ObjectCallbacks UpdateCallbacks = null;

        public delegate void ObjectCallbacks();

        public ObjectBase(Point startPosition, Point objectSize, Color color)
        {
            position = startPosition;
            size = objectSize;

            _texture = new Texture2D(Core.instance.GraphicsDevice , size.X, size.Y, false, SurfaceFormat.Color);
            _texture.SetData<UInt32>(Enumerable.Repeat<UInt32>(Utility.ColorToInt(color), size.X * size.Y).ToArray());

            LoadContentsCallbacks += OnLoadContents;
            UpdateCallbacks += OnUpdate;
        }

        public Point size;
        public Point position;

        public Texture2D _texture;

        public virtual void OnLoadContents() {}
        public virtual void OnUpdate() {}
    }
}