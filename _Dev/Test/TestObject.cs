using System;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SampleMonoGame.Test
{
    public class TestAIObject : ObjectBase
    {
        public TestAIObject(Point startPosition, Point objectSize, Color color) : base(startPosition, objectSize, color)
        {
        }

        public Rectangle GetRect() => new Rectangle(position, size); 

        public static Random rnd = new Random();

        public override void OnLoadContents()
        {
            
        }

        public override void OnUpdate()
        {
            MoveRandomPosition(GraphicsSettings.SCREEN_WIDTH, GraphicsSettings.SCREEN_HEIGHT);
        }

        private void MoveRandomPosition(int xMax, int yMax)
        {
            position.X = rnd.Next(0, xMax);
            position.Y = rnd.Next(0, yMax);
        }
    }
}