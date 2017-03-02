using System;
using System.Runtime.Serialization;

namespace LearnToType
{
    [Serializable]
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {
            System.Windows.Forms.MessageBox.Show("Please check all fields");
        }

        public UserNotFoundException(string message) : base(message)
        {

        }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}