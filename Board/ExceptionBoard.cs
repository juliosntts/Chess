using System;

namespace board
{
    class ExceptionBoard : Exception 
    {
        public ExceptionBoard(string msg) :base(msg) { 
        }
    }
}
