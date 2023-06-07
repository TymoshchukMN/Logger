using System;

namespace Module2_HW5_06062023
{
    internal class Program
    {
        /// <summary>
        /// Sign-in point.
        /// </summary>
        /// <param name="args">
        /// passed args.
        /// </param>
        private static void Main(string[] args)
        {
            Starter.Run();
            UI.LoggingFinished();
            Console.ReadKey();
        }

    }
}
