using System;
using System.Collections.Generic;
using System.Text;

namespace Q9._6._1._2
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            message = "Мое исключение";
        }
    }
}
