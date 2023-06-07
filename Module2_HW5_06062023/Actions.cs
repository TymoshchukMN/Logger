///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 24/05/2023
// Last Modified On :
// Description: Error types
// Project: Module2_HW1_23052023
///////////////////////////////////////

namespace Module2_HW5_06062023
{
    using System;
    using Module2_HW5_06062023.Exeptions;
    using Module2_HW5_06062023.Interfaces;

    /// <summary>
    /// Actions class.
    /// </summary>
    public class Actions : IActions
    {
        /// <summary>
        /// Firts method.
        /// </summary>
        /// <returns>
        /// result.
        /// </returns>
        public bool StartMethod()
        {
            Logger logger = Logger.GetInstatce();
            string message = "Start method";
            logger.AddLog($"{DateTime.Now};{MessageType.Info}" +
                            $";{message} StartMethod");
            return true;
        }

        /// <summary>
        /// Firts method.
        /// </summary>
        /// <returns>
        /// result.
        /// </returns>
        public BusinessException SkippedMethod()
        {
            Logger logger = Logger.GetInstatce();

            string message = "Skipped ligic in method";
            logger.AddLog($"{DateTime.Now};{MessageType.Warning}" +
                          $";{message} SkippedMethod");

            return new BusinessException(message);
        }

        /// <summary>
        /// Firts method.
        /// </summary>
        /// <returns>
        /// result.
        /// </returns>
        public bool BrokenMethod()
        {
            Logger logger = Logger.GetInstatce();

            string message = "I broke a logic";
            logger.AddLog($"{DateTime.Now};{MessageType.Error}" +
                          $";{message} BrokenMethod");

            throw new Exception(message);
        }
    }
}
