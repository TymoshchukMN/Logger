///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 24/05/2023
// Last Modified On :
// Description: User interface module
// Project: Module2_HW1_23052023
///////////////////////////////////////

namespace Module2_HW5_06062023
{
    using System;

    /// <summary>
    /// User interface class.
    /// </summary>
    internal class UI
    {
        /// <summary>
        /// UI interface.
        /// </summary>
        /// <param name="log">
        /// String for log.
        /// </param>
        public static void PrintLog(string log)
        {
            string firstLogPart = log.Split(';')[0];
            string secondLogPart = log.Split(';')[1];
            string thirdLogPart = log.Split(';')[2];

            Enum.TryParse(secondLogPart, out MessageType type);

            switch (type)
            {
                case MessageType.Error:
                    Console.Write($"{firstLogPart}: ");
                    PrintAnotherColor(secondLogPart, ConsoleColor.Red);
                    Console.WriteLine($": {thirdLogPart}");
                    break;
                case MessageType.Info:
                    Console.Write($"{firstLogPart}: ");
                    PrintAnotherColor(secondLogPart, ConsoleColor.Cyan);
                    Console.WriteLine($": {thirdLogPart}");
                    break;
                case MessageType.Warning:
                    Console.Write($"{firstLogPart}: ");
                    PrintAnotherColor(secondLogPart, ConsoleColor.Yellow);
                    Console.WriteLine($": {thirdLogPart}");
                    break;
            }

            void PrintAnotherColor(string str, ConsoleColor color)
            {
                ConsoleColor defColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(str);
                Console.ForegroundColor = defColor;
            }
        }

        public static void LoggingFinished()
        {
            Console.WriteLine("\nLogging finished.....");
        }
    }
}
