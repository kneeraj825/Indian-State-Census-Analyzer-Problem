using IndianState_Census_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Indian_State_Test_Census_Problem

{
    class Indian_Census_Analyzer_Problem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Indian State Census");
            Iteration abs = new Iteration();
            IEnumerable<string> iterating = abs.CsvReader();
            foreach (string finalPrint in iterating)
            {
                Console.WriteLine(finalPrint);
            }
            Iteration itr1 = new Iteration();
            var finalCount = itr1.NumberOfCount();
            Console.WriteLine("Final count is " + finalCount);
        }
    }

}
