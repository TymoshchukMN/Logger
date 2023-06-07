///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 24/05/2023
// Last Modified On :
// Description: Result
// Project: Module2_HW1_23052023
///////////////////////////////////////

namespace Module2_HW5_06062023
{
    /// <summary>
    /// Result class.
    /// </summary>
    public class Result
    {
        private bool _status;
        private string _message;

        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> class.
        /// ctor.
        /// </summary>
        /// <param name="status">
        /// operation status.
        /// </param>
        /// <param name="message">
        /// message.
        /// </param>
        public Result(bool status, string message)
        {
            _status = status;
            _message = message;
        }

        /// <summary>
        /// Gets a value indicating whether get operation status.
        /// </summary>
        public bool Status
        {
            get { return _status; }
            private set { _status = value; }
        }

        /// <summary>
        /// Gets get resul message.
        /// </summary>
        public string Message
        {
            get { return _message; }
            private set { _message = value; }
        }
    }
}
