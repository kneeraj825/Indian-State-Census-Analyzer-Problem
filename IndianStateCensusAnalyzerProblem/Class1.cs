using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndianState_Census_Analyzer_Problem
{
    public class ExceptionHandle : Exception
    {
        public enum ExceptionType
        {
            CENSUS_FILE_PROBLEM, UNABLE_TO_PARSE, NO_CENSUS_DATA, CSV_FILE_INTERNAL_ISSUES,NO_SUCH_FEILD
        }
        public ExceptionType type;
        public ExceptionHandle(ExceptionType Census_Problem)
        {
        }
        public ExceptionHandle(ExceptionType nO_SUCH_FEILD, string message) : base(message)
        {
        }
        public ExceptionHandle(string message, Exception inner) : base(message, inner)
        {
        }
    }

}
