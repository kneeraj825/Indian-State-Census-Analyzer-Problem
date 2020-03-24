using IndianState_Census_Analyzer_Problem;
using IndianStateCensusAnalyzerProblem;
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
            Iteration2 abs1 = new Iteration2();
            IEnumerable<string> iterating1 = abs1.CsvReaderState();
            foreach (string finalPrint1 in iterating1)
            {
                Console.WriteLine(finalPrint1);
            }
            Iteration itrating = new Iteration();
            var finalCount = itrating.NumberOfCount();
            Console.WriteLine("Final count of State Census Analyzer is " + finalCount);

            Iteration2 itrating2 = new Iteration2();
            var finalCount1 = itrating2.NumberOfCountState();
            Console.WriteLine("Final count of State Code is " + finalCount1);
            
            
        }
    }

}
