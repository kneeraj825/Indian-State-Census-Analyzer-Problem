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
            }
            catch (Exception)
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.CENSUS_FILE_PROBLEM);
            }
            if(Path.GetExtension(path) != ".csv")
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.NO_SUCH_FEILD,".CSV_FILE_INCORRECT");
            }
            else if(!File.Exists(path))
            {
                throw new ExceptionHandle(ExceptionHandle.ExceptionType.NO_SUCH_FEILD, "FILE_TYPE_INCORRECT");
            }
            string[] stateCensus = System.IO.File.ReadAllLines(path);
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
        /*public IEnumerable<string> DelimetiterFile()
        {
            string path;
             path = "C:/ Users / NK / Downloads / StateCensusData.csv";
            String line = "";
            String cvsSplitBy = ",";
            try (StreamReader br = new StreamReader(new FileReader(path)))
            {
                while ((line = br.readLine()) != null)
                {
                    // use comma as separator
                    String[] country = line.Split(cvsSplitBy);
                    Console.WriteLine("StateCensusData [code= " + country[4] + " , name=" + country[5] + "]");
                }
            }
            catch (ExceptionHandle e)
            {
               throw e;
            }
        }*/
    }
}
