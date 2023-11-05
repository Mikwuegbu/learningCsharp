using System;
using System.IO;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User already logged in - no duplicate logins");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
            : base()
        {
             
        }
        public UserAlreadyLoggedInException(string message)
            : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException)
            : base (message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
