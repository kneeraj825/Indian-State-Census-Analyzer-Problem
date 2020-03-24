using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyzerProblem
{
    class CsvFileState1
    {
            public string SrNo { get; set; }
            public string State { get; set; }
            public string Name { get; set; }
            public string Tin { get; set; }
            public string StateCode { get; set; }

            public CsvFileState1 CsvValueState(string CsvLineState)
            {
                string[] values = CsvLineState.Split(',');
                CsvFileState1 csvfilestate = new CsvFileState1();
                csvfilestate.SrNo = Convert.ToString(values[0]);
                csvfilestate.State = Convert.ToString(values[1]);
                csvfilestate.Name = Convert.ToString(values[2]);
                csvfilestate.Tin = Convert.ToString(values[3]);
                csvfilestate.StateCode = Convert.ToString(values[4]);
                return csvfilestate;
            }
        
    }
}

