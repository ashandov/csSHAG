using System;
namespace Lesson07.Properties
{
    public class MyException : Exception
    {
        public DateTime ExceptionTime { get; private set; }
        public MyException() : this("MyException")
        {
            ExceptionTime = DateTime.Now;
        }
        public MyException(string message) : base(message)
        {

        }
        public MyException(string message, Exception inner) : base(message, inner)
        {

        }
        protected MyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }


    }
}
