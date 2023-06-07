// Author: Tymoshchuk Maksym
// Created On : 17/05/2023
// Last Modified On :
// Description: Error types
// Project: HW4_16052023
// </copyright>

namespace Module2_HW5_06062023
{
    /// <summary>
    /// Error types.
    /// </summary>
    internal enum MessageType : byte
    {
        /// <summary>
        /// Default value.
        /// </summary>
        None,

        /// <summary>
        /// Error.
        /// </summary>
        Error,

        /// <summary>
        /// Info.
        /// </summary>
        Info,

        /// <summary>
        /// Warning
        /// </summary>
        Warning,
    }
}
