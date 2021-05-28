using System;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SampleMonoGame.Test
{
    public class TestAIObject
    {
        public TestAIObject(Point objSize, Texture2D objTexture)
        {
            texture = objTexture;
            size = objSize;

            texture.SetData<UInt32>(Enumerable.Repeat<UInt32>(0xFFFFFFFF, size.X * size.Y).ToArray());
        }

        public Rectangle GetRect() => new Rectangle(position, size); 

        public static Random rnd = new Random();

        public Texture2D texture = null;
        public Point size;
        public Point position;

        public void MoveRandomPosition(Point maxPosition)
        {
            position.X = rnd.Next(0, maxPosition.X);
            position.Y = rnd.Next(0, maxPosition.Y);
        }
    }
}