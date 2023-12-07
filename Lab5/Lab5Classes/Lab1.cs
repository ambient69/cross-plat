using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Classes
{
    public class Lab1
    {
        public static string Run(string inputPath, string outputPath)
        {

            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;
                string result = "";
                while ((line = reader.ReadLine()) != null)
                {
                    int N = int.Parse(line);
                    int numberOfSalads = (int)Math.Pow(2, N) - N - 1;
                    writer.WriteLine(numberOfSalads);
                    result += numberOfSalads + "\n";
                }
                return result;
            }
        }
    }
}
