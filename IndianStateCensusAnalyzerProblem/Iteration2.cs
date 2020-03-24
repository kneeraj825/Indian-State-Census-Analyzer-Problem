using IndianState_Census_Analyzer_Problem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IndianStateCensusAnalyzerProblem
{
    public  class Iteration2
    {
        public IEnumerable<string> CsvReaderState()
        {
            string pathState;
            try
            {
                pathState = "C:/Users/NK/Downloads/StateCode1.csv";
            }
            catch(Exception)
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.CENSUS_FILE_PROBLEM);
            }
            if (Path.GetExtension(pathState) != ".csv")
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.NO_SUCH_FEILD, ".CSV_FILE_INCORRECT");
            }
            else if (!File.Exists(pathState))
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.NO_SUCH_FEILD, "FILE_TYPE_INCORRECT");
            }
            string[] stateCensus = System.IO.File.ReadAllLines(pathState);
            CsvFileState1 csv = new CsvFileState1();
            List<CsvFileState1> stateValues = File.ReadAllLines(pathState).Select(v => csv.CsvValueState(v))
                .ToList();
            foreach (var elements in stateValues)
            {
                string var = elements.SrNo + "," + elements.State + "," + elements.Name + "," + elements.Tin + "," + elements.StateCode;
                yield return var;

            }
        }
        public int NumberOfCountState()
        {
            int cnt = 0;
            Iteration2 itr = new Iteration2();
            IEnumerable<string> element = itr.CsvReaderState();
            foreach (var numbers in element)
            {
                cnt++;
            }
            return cnt++;
        }
    }
}

