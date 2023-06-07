namespace Module2_HW5_06062023.Exeptions
{
    using System;
    using Module2_HW5_06062023.Interfaces;

    public class BusinessException : Exception
    {
        public BusinessException(string message)
            : base(message)
        {
        }
    }
}
