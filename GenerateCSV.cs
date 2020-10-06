using System;
using System.Collections.Generic;


namespace IRCalculator
{
    class GenerateCSV
    {
        public static void GenerateFile(List<List<float>> my2DList)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\results.csv", true))
                {
                    file.WriteLine("Current Month,Current Payment,Current Debt");
                    for(int i = 0; i < my2DList.Count; i++)
                    {
                        file.WriteLine(my2DList[i][0].ToString("F0") + "," + my2DList[i][1].ToString("F2") + "," + my2DList[i][2].ToString("F2"));                        
                    }
                    file.WriteLine();
                    
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error: ", ex);
            }
        }
    }
}