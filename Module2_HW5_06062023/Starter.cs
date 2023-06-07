///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 24/05/2023
// Last Modified On :
// Description: logger run
// Project: Module2_HW1_23052023
///////////////////////////////////////

namespace Module2_HW5_06062023
{
    using System;
    using System.IO;
    using System.Threading;
    using Module2_HW5_06062023.Exeptions;
    using Module2_HW5_06062023.Interfaces;

    /// <summary>
    /// Starter.
    /// </summary>
    internal class Starter
    {
        private const ushort Counter = 100;
        private const ushort StartRand = 1;
        private const ushort StopRand = 4;

        private static Random _random = new Random();

        /// <summary>
        /// Louch logging.
        /// </summary>
        public static void Run()
        {
            // Actions action = new Actions();
            IActions action = new Actions();
            Logger logger = Logger.GetInstatce();

            for (ushort i = 0; i < Counter; ++i)
            {
                ushort rndVol = (ushort)_random.Next(StartRand, StopRand);

                Thread.Sleep(200);

                switch (rndVol)
                {
                    case 1:
                        ResulFalseProcessing(logger, action.StartMethod());
                        UI.PrintLog(logger.Logs[i]);
                        break;

                    case 2:

                        try
                        {
                            action.SkippedMethod();
                        }
                        catch (BusinessException ex)
                        {
                            logger.AddLog($"{DateTime.Now};{MessageType.Warning}" +
                                $": Action failed by a reason; Action got this custom Exception: {ex.Message}");
                        }
                        finally
                        {
                            UI.PrintLog(logger.Logs[i]);
                        }

                        break;
                    case 3:

                        try
                        {
                            action.BrokenMethod();
                        }
                        catch (Exception ex)
                        {
                            logger.AddLog($"{DateTime.Now};{MessageType.Error}" +
                                $": Action failed by reason:: {ex.Message}");
                        }
                        finally
                        {
                            UI.PrintLog(logger.Logs[i]);
                        }

                        break;
                }
            }

            File.WriteAllText("log.txt", string.Join(((char)10).ToString(), logger.Logs));
        }

        /// <summary>
        /// Check if Result has false flag and add info to log.
        /// </summary>
        /// <param name="logger">
        /// loger class.
        /// </param>
        /// <param name="result">
        /// result class.
        /// </param>
        private static void ResulFalseProcessing(Logger logger, Result result)
        {
            if (!result.Status)
            {
                logger.AddLog($"{DateTime.Now};{MessageType.Error}" +
                    $": Action failed by a reason; {result.Message}");
            }
        }
    }
}
