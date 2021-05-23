using System;

namespace Sample_MonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Core())
                game.Run();
        }
    }
}
