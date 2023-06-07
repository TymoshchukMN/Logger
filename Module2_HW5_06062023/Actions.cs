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
        public Result StartMethod()
        {
            Result result = new Result(true, "Start method");
            Logger logger = Logger.GetInstatce();

            logger.AddLog($"{DateTime.Now};{MessageType.Info}" +
                            $";{result.Message} StartMethod");
            return result;
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
            Result result = new Result(true, "Skipped ligic in method");

            logger.AddLog($"{DateTime.Now};{MessageType.Warning}" +
                          $";{result.Message} SkippedMethod");

            return new BusinessException(result.Message);
        }

        /// <summary>
        /// Firts method.
        /// </summary>
        /// <returns>
        /// result.
        /// </returns>
        public Result BrokenMethod()
        {
            Logger logger = Logger.GetInstatce();
            Result result = new Result(false, "I broke a logic");

            logger.AddLog($"{DateTime.Now};{MessageType.Error}" +
                          $";{result.Message} BrokenMethod");

            throw new Exception(result.Message);
        }
    }
}
