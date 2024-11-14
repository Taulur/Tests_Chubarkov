using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rubtsova_3
    {
        public static void Main(string[] args)
        { 
            var inputLines = File.ReadAllLines(args[0]);
            int n = int.Parse(inputLines[0]);
            var diameters = inputLines[1].Split(' ').Select(int.Parse).ToArray();
            var indexedDiameters = diameters.Select((d, i) => new { Diameter = d, Index = i + 1 }).ToArray();
            var sortedDiameters = indexedDiameters.OrderBy(d => d.Diameter).ToArray();
            using (var writer = new StreamWriter(args[1]))
            {
                for (int i = 0; i < n; i++)
                {
                    int lowerBallIndex = sortedDiameters[i].Index;              
                    int upperBallIndex = sortedDiameters[2 * n - 1 - i].Index; 
                    writer.WriteLine($"{upperBallIndex} {lowerBallIndex}");
                }
            }
        }
    }
}
