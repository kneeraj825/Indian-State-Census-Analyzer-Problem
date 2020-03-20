using System;
using System.Collections.Generic;
using System.Text;

namespace IndianState_Census_Analyzer_Problem
{
    class CsvFile
    {
        public string State { get; set; }
        public string Population { get; set; }
        public string AreaInSqKm { get; set; }
        public string DensityPerSqKm { get; set; }

        public CsvFile CsvValue(string CsvLine)
        {
            string[] values = CsvLine.Split(',');
            CsvFile csvfile = new CsvFile();
            csvfile.State = Convert.ToString(values[0]);
            csvfile.Population = Convert.ToString(values[1]);
            csvfile.AreaInSqKm = Convert.ToString(values[2]);
            csvfile.DensityPerSqKm = Convert.ToString(values[3]);
            return csvfile;
        }
    }
}
