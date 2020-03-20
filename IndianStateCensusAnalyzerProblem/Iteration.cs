using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace IndianState_Census_Analyzer_Problem
{
   public class Iteration
    {
        public IEnumerable<string> CsvReader()
        {
            string path;
            try
            {
                path = "C:/Users/NK/Downloads/StateCensusData.csv";
                string[] stateCensus = System.IO.File.ReadAllLines(path);
            }
            catch (Exception)
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.CENSUS_FILE_PROBLEM);
            }

            CsvFile csv = new CsvFile();
            List<CsvFile> values = File.ReadAllLines(path).Select(v => csv.CsvValue(v))
                .ToList();


            foreach (var element in values)
            {
                string var = element.State + "," + element.Population + "," + element.AreaInSqKm + "," + element.DensityPerSqKm;
                yield return var;

            }
        }
        public int NumberOfCount()
        {
            int cnt = 0;
            try
            {
                Iteration itr = new Iteration();
                IEnumerable<string> element = itr.CsvReader();
                foreach (var numbers in element)
                {
                    cnt++;
                }
            }
            catch (ExceptionHandle e)
            {
                throw e;
            }
            return cnt++;
        }
    }
}
