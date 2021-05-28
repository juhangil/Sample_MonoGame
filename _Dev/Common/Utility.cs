using System;
using Microsoft.Xna.Framework;

namespace SampleMonoGame
{
    public class Utility
    {
        public static UInt32 ColorToInt(Color color)
        {
            UInt32 result = 0x0;

            result += color.R;
            result = result << 8;

            result += color.G;
            result = result << 8;

            result += color.B;
            result = result << 8;

            result += color.A;

            return result;
        }
    }
}